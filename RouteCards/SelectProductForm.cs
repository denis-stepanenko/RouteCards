using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class SelectProductForm : Form
    {
        private readonly ProductRepo _repo = new ProductRepo();

        public Product Product;

        public SelectProductForm()
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            var items = _repo.GetOwnProducts(filterPlaceholderTextBox.Value);
            itemsDataGridView.DataSource = items;
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();

        void Ok()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Product;
            if (item == null) return;

            Product = item;

            Close();
        }

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Ok();

        private void okButton_Click(object sender, EventArgs e) => Ok();
    }
}
