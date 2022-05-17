using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class OperationsForm : Form
    {
        OperationRepo repo = new OperationRepo();

        IEnumerable<Operation> items;

        public OperationsForm()
        {
            InitializeComponent();

            var user = AuthorizationService.User;

            if (user.RoleId == 0)
            {
                addButton.Enabled = false;
                openButton.Enabled = false;
                removeButton.Enabled = false;
                duplicateButton.Enabled = false;
                itemsDataGridView.CellDoubleClick -= itemsDataGridView_CellDoubleClick;
            }

            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            //var currentRow = itemsDataGridView.CurrentRow;
            items = repo.GetAll();
            itemsDataGridView.DataSource = items;
            //if(currentRow != null)
            //    if(currentRow.Index != -1)
            //itemsDataGridView.FirstDisplayedScrollingRowIndex = currentRow.Index;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        void Filter()
        {
            itemsDataGridView.DataSource = items.Where(x =>
            x.Department.ToString().Contains(filterPlaceholderTextBox.Value)
            || (x.Code?.ToLower() ?? "").Contains(filterPlaceholderTextBox.Value.ToLower())
            || (x.Name?.ToLower() ?? "").Contains(filterPlaceholderTextBox.Value.ToLower())
            || (x.GroupName?.ToLower() ?? "").Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        private void removeButton_Click(object sender, EventArgs e)
        {
            var items = itemsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Operation);
            if (items.Count() == 0) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            foreach (var item in items)
            {
                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (new[] { 4, 5, 6 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 4, 5, 6 }.Contains(item.Department))
                        {
                            MessageBox.Show("Вы можете удалять только операции механических цехов", "Внимание");
                            return;
                        }
                    }

                    if (new[] { 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 13, 17, 80, 82 }.Contains(item.Department))
                        {
                            MessageBox.Show("Вы можете удалять только операции сборочных цехов", "Внимание");
                            return;
                        }
                    }
                }

                //if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                //{
                //    if (item.Department != AuthorizationService.User.Department)
                //    {
                //        MessageBox.Show("Среди выбранного есть операции, которые принадлежат другому цеху", "Внимание");
                //        return;
                //    }
                //}
            }

            foreach (var item in items)
            {
                repo.Remove(item);
            }

            GetItems();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new OperationForm(null).ShowDialog();

            GetItems();
        }

        void Open()
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Operation;
            if (item == null) return;

            new OperationForm(item).ShowDialog();

            GetItems();
        }


        private void openButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            var items = itemsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Operation);
            if (items.Count() == 0) return;

            int department = (int)duplicateDepartmentNumericUpDown.Value;


            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
            {
                if (new[] { 4, 5, 6 }.Contains(AuthorizationService.User.Department))
                {
                    if (!new[] { 4, 5, 6 }.Contains(department))
                    {
                        MessageBox.Show("Вы можете редактировать только операции механических цехов", "Внимание");
                        return;
                    }
                }

                if (new[] { 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (!new[] { 13, 17, 80, 82 }.Contains(department))
                    {
                        MessageBox.Show("Вы можете редактировать только операции сборочных цехов", "Внимание");
                        return;
                    }
                }
            }

            //if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
            //{
            //    if (department != AuthorizationService.User.Department)
            //    {
            //        MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
            //        return;
            //    }
            //}

            foreach (var item in items)
            {

                bool result = repo.IsThereOperationWithDepartmentAndName(item);

                if (result)
                {
                    MessageBox.Show("Среди дублируемых операций уже есть операции в выбранном цехе с таким названием", "Внимание");
                    return;
                }
            }

            try
            {
                foreach (var item in items)
                {
                    var newOperation = new Operation
                    {
                        Department = department,
                        Code = item.Code,
                        Name = item.Name,
                        GroupName = item.GroupName
                    };

                    repo.Add(newOperation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GetItems();

        }
    }
}
