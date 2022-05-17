using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class SelectMaterialFromProductForm : Form
    {
        MaterialRepo repo = new MaterialRepo();

        public Material material;

        Card card;

        public SelectMaterialFromProductForm(Card card)
        {
            InitializeComponent();
            this.card = card;
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            IEnumerable<Material> items;

            var productionDepartments = new List<int> { 4, 5, 6, 13, 17, 80, 82};
            if (productionDepartments.Contains(card.Department))
            {
                items = repo.GetAllByProductAndDepartment(card.ProductCode, card.Department);
            }
            else
            {
                items = repo.GetAllByProduct(card.ProductCode);
            }

            itemsDataGridView.DataSource = items;
        }

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
        private void itemsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ok();
        }


        private void refreshButton_Click(object sender, EventArgs e) => GetItems();


    }
}
