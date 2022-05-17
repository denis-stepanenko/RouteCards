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
    public partial class ExecutorsForm : Form
    {
        ExecutorRepo repo = new ExecutorRepo();

        IEnumerable<Executor> items;

        public ExecutorsForm()
        {
            InitializeComponent();

            var user = AuthorizationService.User;

            if (user.RoleId == 0)
            {
                addButton.Enabled = false;
                editButton.Enabled = false;
                removeButton.Enabled = false;
                itemsDataGridView.CellDoubleClick -= itemsDataGridView_CellDoubleClick;
            }

            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }


        void GetItems()
        {
            items = repo.GetAll();
            itemsDataGridView.DataSource = items;
            Filter();
        }

        void Filter()
        {
            itemsDataGridView.DataSource = items.Where(x =>
            x.FirstName.ToLower().Contains(firstNamePlaceholderTextBox.Value.ToLower())
            && x.SecondName.ToLower().Contains(secondNamePlaceholderTextBox.Value.ToLower())
            && x.Patronymic.ToLower().Contains(patronymicPlaceholderTextBox.Value.ToLower())
            && x.Department.ToString().ToLower().Contains(departmentPlaceholderTextBox.Value.ToLower())
            ).ToList();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void removeButton_Click(object sender, EventArgs e)
        {
            var items = itemsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Executor);
            if (items.Count() == 0) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            foreach (var item in items)
            {
                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (item.Department != AuthorizationService.User.Department)
                    {
                        MessageBox.Show("Среди выбранного есть исполнители, которые принадлежат другому цеху", "Внимание");
                        return;
                    }
                }
            }

            foreach (var item in items)
            {
                repo.Remove(item);
            }

            GetItems();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new ExecutorForm(null).ShowDialog();

            GetItems();
        }

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Executor;
            new ExecutorForm(item).ShowDialog();

            GetItems();
        }

        private void editButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();

        private void firstNamePlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
        private void secondNamePlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
        private void patronymicPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
        private void departmentPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
