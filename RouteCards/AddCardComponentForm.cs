using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddCardComponentForm : Form
    {
        private readonly ProductRepo _repo = new ProductRepo();
        private readonly CardComponentRepo _cardComponentRepo = new CardComponentRepo();

        private readonly Card _card;

        private IEnumerable<Product> _items;


        public AddCardComponentForm(Card card)
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            _card = card;

            GetItems();
        }

        void GetItems()
        {
            _items = _repo.GetOwnProducts();
            itemsDataGridView.DataSource = _items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Product;
            if (item == null) return;

            var newCardComponent = new CardComponent
            {
                CardId = _card.Id,
                Code = item.Code,
                Name = item.Name,
                FactoryNumber = factoryNumberTextBox.Text,
                AccompanyingDocument = accompanyingDocumentTextBox.Text,
                Count = (int)countNumericUpDown.Value
            };

            _cardComponentRepo.Add(newCardComponent);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        void Filter()
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.Code.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Name.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }
    }
}
