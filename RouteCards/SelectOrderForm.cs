using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class SelectOrderForm : Form
    {
        private readonly OrderRepo _repo = new OrderRepo();

        private readonly Card _card;

        public Order Order;

        public SelectOrderForm(Card card)
        {
            InitializeComponent();
            _card = card;

            GetItems();
        }

        void GetItems()
        {
            var items = _repo.GetOrders(_card.ProductCode);
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Order;
            Order = item;
        }
    }
}
