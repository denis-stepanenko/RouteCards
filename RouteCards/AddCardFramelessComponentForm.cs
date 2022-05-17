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
    public partial class AddCardFramelessComponentForm : Form
    {
        ProductRepo productRepo = new ProductRepo();
        CardFramelessComponentRepo cardFramelessComponentRepo = new CardFramelessComponentRepo();

        Card card;

        IEnumerable<Product> items;

        public AddCardFramelessComponentForm(Card card)
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            this.card = card;


            GetItems();
        }

        void GetItems()
        {
            items = productRepo.GetPurchasedProducts();
            itemsDataGridView.DataSource = items;
        }

        void Filter()
        {
            itemsDataGridView.DataSource = items.Where(x =>
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
                CardId = card.Id,
                DateOfIssueForProduction = dateOfIssueForProductionDateTimePicker.Value,
                DateOfSealing = dateOfSealingDateTimePicker.Value,
                DaysBeforeSealing = (int)daysBeforeSealingNumericUpDown.Value,
                Code = item.Code,
                Name = item.Name
            };

            cardFramelessComponentRepo.Add(newCardFramelessComponenet);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
