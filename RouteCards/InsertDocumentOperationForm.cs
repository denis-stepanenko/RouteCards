using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class InsertDocumentOperationForm : Form
    {
        private readonly OperationRepo _repo = new OperationRepo();
        private readonly DocumentOperationRepo _documentOperationRepo = new DocumentOperationRepo();

        private readonly DocumentOperation _insertBeforeOperation;

        private IEnumerable<Operation> _items;

        public InsertDocumentOperationForm(DocumentOperation insertBeforeOperation)
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            _insertBeforeOperation = insertBeforeOperation;

            GetItems();
        }

        void GetItems()
        {
            _items = _repo.GetAll();
            itemsDataGridView.DataSource = _items;
        }

        void Filter()
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.Code.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Name.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Operation;
            if (item == null) return;

            var newDocumentOperation = new DocumentOperation
            {
                DocumentId = _insertBeforeOperation.DocumentId,
                Code = item.Code,
                Name = item.Name,
                Department = item.Department,
                Labor = laborNumericUpDown.Value,
                Count = (int)countNumericUpDown.Value,
                Description = descriptionTextBox.Text,
                Position = _insertBeforeOperation.Position
            };

            _documentOperationRepo.Insert(newDocumentOperation);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
