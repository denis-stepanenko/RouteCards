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
        OperationRepo repo = new OperationRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();

        DocumentOperation insertBeforeOperation;

        IEnumerable<Operation> items;

        public InsertDocumentOperationForm(DocumentOperation insertBeforeOperation)
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            this.insertBeforeOperation = insertBeforeOperation;

            GetItems();
        }

        void GetItems()
        {
            items = repo.GetAll();
            itemsDataGridView.DataSource = items;
        }

        void Filter()
        {
            itemsDataGridView.DataSource = items.Where(x =>
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
                DocumentId = insertBeforeOperation.DocumentId,
                Code = item.Code,
                Name = item.Name,
                Department = item.Department,
                Labor = laborNumericUpDown.Value,
                Count = (int)countNumericUpDown.Value,
                Description = descriptionTextBox.Text,
                Position = insertBeforeOperation.Position
            };

            documentOperationRepo.Insert(newDocumentOperation);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
