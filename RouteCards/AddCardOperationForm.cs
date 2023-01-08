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
    public partial class AddCardOperationForm : Form
    {
        private readonly OperationRepo _repo = new OperationRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly Card _card;

        private IEnumerable<Operation> _items;

        public AddCardOperationForm(Card card)
        {
            InitializeComponent();
            _card = card;

            itemsDataGridView.AutoGenerateColumns = false;


            // Если в карте еще нет операций, то подтягиваем количество операции из карты
            var areThereOperations = _cardOperationRepo.AreThereOperationsInCard(_card.Id);
            if (!areThereOperations)
            {
                countNumericUpDown.Value = _card.ProductCount;
            }
         
            int number = _cardOperationRepo.GetMaxOperationNumber(_card.Id);
            numberTextBox.Text = (number - (number % 5) + 5).ToString("000");
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

        void Add()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Operation;
            if (item == null) return;


            if (!Regex.IsMatch(numberTextBox.Text, @"\d{3}"))
            {
                MessageBox.Show("Номер операции должен состоять из 3 цифр");
                return;
            }

            var newOperation = new CardOperation
            {
                CardId = _card.Id,
                Code = item.Code,
                Name = item.Name,
                Department = item.Department,
                Count = (int)countNumericUpDown.Value,
                Description = descriptionTextBox.Text,
                Number = numberTextBox.Text
            };

            _cardOperationRepo.Add(newOperation);
            _cardOperationRepo.RecalculateOperationPositions(_card.Id);

            DialogResult = DialogResult.OK;
        }

        private void okButton_Click(object sender, EventArgs e) => Add();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Add();

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

    }
}
