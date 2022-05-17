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
    public partial class DocumentForm : Form
    {
        DocumentOperationRepo repo = new DocumentOperationRepo();

        Document document;

        public DocumentForm(Document document)
        {
            InitializeComponent();

            var productionDepartments = new List<int> { 4, 5, 6, 13, 17, 80, 82 };
            var user = AuthorizationService.User;

            if (user.RoleId == 0)
            {
                addButton.Enabled = false;
                insertButton.Enabled = false;
                openButton.Enabled = false;
                removeButton.Enabled = false;
                closeCancelButton.Enabled = false;
                itemsDataGridView.CellDoubleClick -= itemsDataGridView_CellDoubleClick;
            }

            if (productionDepartments.Contains(user.Department))
            {
                if (document.Card.Department != user.Department)
                {
                    if (document.Department != user.Department)
                    {
                        addButton.Enabled = false;
                        insertButton.Enabled = false;
                        openButton.Enabled = false;
                        removeButton.Enabled = false;
                        closeCancelButton.Enabled = false;
                        itemsDataGridView.CellDoubleClick -= itemsDataGridView_CellDoubleClick;
                    }
                }
            }


            itemsDataGridView.AutoGenerateColumns = false;
            this.document = document;

            numberTextBox.Text = document.Number;

            GetItems();
        }

        void GetItems()
        {
            var items = repo.GetAll(document.Id);
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult dr =  new AddDocumentOperationForm(document).ShowDialog();
            GetItems();
            if (dr == DialogResult.OK)
            {
                addButton_Click(null, null);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as DocumentOperation;
            if (item == null) return;

            var operation = repo.GetClosestControlOperation(item);

            if (operation != null)
            {
                if (operation.ExecutorId != 0)
                {
                    MessageBox.Show("Вы не можете удалить операцию, стоящую перед закрытой операцией контроля ОТК", "Внимание");
                    return;
                }
            }    

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                repo.Remove(item);
                repo.RecalculatePositions(document.Id);
                GetItems();
            }

            //var items = itemsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as DocumentOperation);
            //if (items.Count() == 0) return;

            //var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes)
            //{
            //    foreach (var item in items)
            //    {
            //        repo.Remove(item);
            //    }

            //    repo.RecalculatePositions(document.Id);

            //    GetItems();
            //}

        }

        //private void moveUpButton_Click(object sender, EventArgs e)
        //{
        //    var item = itemsDataGridView.CurrentRow.DataBoundItem as DocumentOperation;
        //    if (item == null) return;

        //    repo.MoveUp(item.Id, item.DocumentId);

        //    GetItems();
        //}

        //private void moveDownButton_Click(object sender, EventArgs e)
        //{
        //    var item = itemsDataGridView.CurrentRow.DataBoundItem as DocumentOperation;
        //    if (item == null) return;

        //    repo.MoveDown(item.Id, item.DocumentId);

        //    GetItems();
        //}

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as DocumentOperation;
            if (item == null) return;

            var operation = repo.GetClosestControlOperation(item);

            if (operation != null)
            {
                if (operation.ExecutorId != 0)
                {
                    MessageBox.Show("Вы не можете редактировать операцию, стоящую перед закрытой операцией контроля ОТК", "Внимание");
                    return;
                }
            }

            new DocumentOperationForm(item).ShowDialog();

            GetItems();
        }

        private void openButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();

        private void closeCancelButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as DocumentOperation;
            if (item == null) return;

            var operation = repo.GetClosestControlOperation(item);

            if (operation != null)
            {
                if (operation.ExecutorId != 0)
                {
                    if (!item.Name.ToUpper().EndsWith("ОТК"))
                    {
                        MessageBox.Show("Вы не можете изменить исполнителя у операции, стоящей перед закрытой операцией контроля ОТК", "Внимание");
                        return;
                    }
                }
            }

            if (item.ExecutorId == 0)
            {
                new CloseOperationForm(item).ShowDialog();
            }
            else
            {
                item.ExecutorId = 0;
                item.StartDate = null;
                item.EndDate = null;
                repo.Update(item);
            }

            GetItems();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as DocumentOperation;
            if (item == null) return;

            var operation = repo.GetClosestControlOperation(item);

            if (operation != null)
            {
                if (operation.ExecutorId != 0)
                {
                    MessageBox.Show("Вы не можете вставить операцию перед закрытой операцией контроля ОТК", "Внимание");
                    return;
                }
            }

            new InsertDocumentOperationForm(item).ShowDialog();

            GetItems();
        }

        private void itemsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = itemsDataGridView.Rows[e.RowIndex];
            var operation = row.DataBoundItem as DocumentOperation;

            if (operation.Name.ToUpper().EndsWith("ОТК") && operation.ExecutorId != 0)
            {
                row.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
    }
}
