using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddDocumentOperationForm : Form
    {
        private readonly OperationRepo _repo = new OperationRepo();
        private readonly DocumentOperationRepo _documentOperationRepo = new DocumentOperationRepo();

        private readonly Document _document;

        private IEnumerable<Operation> _items;

        public AddDocumentOperationForm(Document document)
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            _document = document;

            // Если в карте еще нет операций, то подтягиваем количество операции из карты
            var areThereOperations = _documentOperationRepo.AreThereOperationsInCard(document.CardId);
            if (!areThereOperations)
            {
                countNumericUpDown.Value = document.Card.ProductCount;
            }
         
            int number = _documentOperationRepo.GetMaxOperationNumber(document.CardId);
            numberTextBox.Text = (number - (number % 5) + 5).ToString("000");
            GetItems();
        }

        void GetItems()
        {
            _items = _repo.GetAllByDepartment(_document.Department);
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
                DocumentId = _document.Id,
                Code = item.Code,
                Name = item.Name,
                Department = item.Department,
                Count = (int)countNumericUpDown.Value,
                Description = descriptionTextBox.Text,
                Number = numberTextBox.Text
            };

            _documentOperationRepo.Add(newDocumentOperation);
            _documentOperationRepo.RecalculatePositions(_document.Id);

            DialogResult = DialogResult.OK;
        }

        private void okButton_Click(object sender, EventArgs e) => Add();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Add();

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

    }
}
