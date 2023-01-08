using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddCardFramelessComponentForm : Form
    {
        private readonly ProductRepo _productRepo = new ProductRepo();
        private readonly CardFramelessComponentRepo _cardFramelessComponentRepo = new CardFramelessComponentRepo();

        private readonly Card _card;

        private IEnumerable<Product> _items;

        public AddCardFramelessComponentForm(Card card)
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            _card = card;

            GetItems();
        }

        void GetItems()
        {
            _items = _productRepo.GetPurchasedProducts();
            itemsDataGridView.DataSource = _items;
        }

        void Filter()
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.Code.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || (x.Name?.ToLower() ?? "").Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Product;
            if (item == null) return;

            var newCardFramelessComponenet = new CardFramelessComponent
            {
                CardId = _card.Id,
                DateOfIssueForProduction = dateOfIssueForProductionDateTimePicker.Value,
                DateOfSealing = dateOfSealingDateTimePicker.Value,
                DaysBeforeSealing = (int)daysBeforeSealingNumericUpDown.Value,
                Code = item.Code,
                Name = item.Name
            };

            _cardFramelessComponentRepo.Add(newCardFramelessComponenet);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
