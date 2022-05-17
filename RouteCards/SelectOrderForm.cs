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
    public partial class SelectOrderForm : Form
    {
        OrderRepo repo = new OrderRepo();

        Card card;

        public Order order;

        public SelectOrderForm(Card card)
        {
            InitializeComponent();
            this.card = card;

            GetItems();
        }


        void GetItems()
        {
            var items = repo.GetOrders(card.ProductCode);
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Order;
            order = item;
        }
    }
}
