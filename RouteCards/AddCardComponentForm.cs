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
    public partial class AddCardComponentForm : Form
    {
        ProductRepo repo = new ProductRepo();
        CardComponentRepo cardComponentRepo = new CardComponentRepo();

        IEnumerable<Product> items;

        Card card;

        public AddCardComponentForm(Card card)
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            this.card = card;

            GetItems();
        }

        void GetItems()
        {
            items = repo.GetOwnProducts();
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Product;
            if (item == null) return;

            var newCardComponent = new CardComponent
            {
                CardId = card.Id,
                Code = item.Code,
                Name = item.Name,
                FactoryNumber = factoryNumberTextBox.Text,
                AccompanyingDocument = accompanyingDocumentTextBox.Text,
                Count = (int)countNumericUpDown.Value
            };

            cardComponentRepo.Add(newCardComponent);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        void Filter()
        {
            itemsDataGridView.DataSource = items.Where(x =>
            x.Code.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Name.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }
    }
}
