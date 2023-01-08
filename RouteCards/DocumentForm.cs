using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class DocumentForm : Form
    {
        private readonly DocumentOperationRepo _repo = new DocumentOperationRepo();

        private readonly Document _document;

        public DocumentForm(Document document)
        {
            InitializeComponent();

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

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
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
            _document = document;

            numberTextBox.Text = document.Number;

            GetItems();
        }

        void GetItems()
        {
            var items = _repo.GetAll(_document.Id);
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult dr =  new AddDocumentOperationForm(_document).ShowDialog();
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

            var operation = _repo.GetClosestControlOperation(item);

            if (operation != null)
            {
                if (operation.ExecutorId != 0)
                {
                    MessageBox.Show("Вы не можете удалить операцию, стоящую перед закрытой операцией контроля ОТК", "Внимание");
                    return;
                }
            }    

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            _repo.Remove(item);
            _repo.RecalculatePositions(_document.Id);
            GetItems();
        }

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as DocumentOperation;
            if (item == null) return;

            var operation = _repo.GetClosestControlOperation(item);

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

            var operation = _repo.GetClosestControlOperation(item);

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
                _repo.Update(item);
            }

            GetItems();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as DocumentOperation;
            if (item == null) return;

            var operation = _repo.GetClosestControlOperation(item);

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
