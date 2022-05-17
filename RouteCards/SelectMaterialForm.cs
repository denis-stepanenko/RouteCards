using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class SelectMaterialForm : Form
    {
        MaterialRepo repo = new MaterialRepo();

        public Material material;

        public SelectMaterialForm()
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            itemsDataGridView.DataSource = repo.Find(filterPlaceholderTextBox.Value);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            Ok();
        }

        void Ok()
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Material;
            if (item == null) return;
            material = item;
            this.Close();
        }

        private void itemsDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Ok();
        }
    }
}
