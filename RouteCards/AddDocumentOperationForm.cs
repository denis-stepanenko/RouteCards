using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddDocumentOperationForm : Form
    {
        OperationRepo repo = new OperationRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();

        Document document;

        IEnumerable<Operation> items;

        public AddDocumentOperationForm(Document document)
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            this.document = document;

            // Если в карте еще нет операций, то подтягиваем количество операции из карты
            var areThereOperations = documentOperationRepo.AreThereOperationsInCard(document.CardId);
            if (!areThereOperations)
            {
                countNumericUpDown.Value = document.Card.ProductCount;
            }
         
            int number = documentOperationRepo.GetMaxOperationNumber(document.CardId);
            numberTextBox.Text = (number - (number % 5) + 5).ToString("000");
            GetItems();
        }

        void GetItems()
        {
            items = repo.GetAllByDepartment(document.Department);
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

        void Add()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Operation;
            if (item == null) return;


            if (!Regex.IsMatch(numberTextBox.Text, @"\d{3}"))
            {
                MessageBox.Show("Номер операции должен состоять из 3 цифр");
                return;
            }

            var newDocumentOperation = new DocumentOperation
            {
                DocumentId = document.Id,
                Code = item.Code,
                Name = item.Name,
                Department = item.Department,
                Count = (int)countNumericUpDown.Value,
                Description = descriptionTextBox.Text,
                Number = numberTextBox.Text
            };

            documentOperationRepo.Add(newDocumentOperation);
            documentOperationRepo.RecalculatePositions(document.Id);

            this.DialogResult = DialogResult.OK;
        }

        private void okButton_Click(object sender, EventArgs e) => Add();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Add();

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

    }
}
