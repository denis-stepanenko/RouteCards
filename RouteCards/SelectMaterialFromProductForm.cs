using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class SelectMaterialFromProductForm : Form
    {
        private readonly MaterialRepo _repo = new MaterialRepo();

        private readonly Card _card;

        public Material Material;

        public SelectMaterialFromProductForm(Card card)
        {
            InitializeComponent();
            _card = card;
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            IEnumerable<Material> items;

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(_card.Department))
                items = _repo.GetAllByProductAndDepartment(_card.ProductCode, _card.Department);
            else
                items = _repo.GetAllByProduct(_card.ProductCode);

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
            Material = item;
            Close();
        }
        private void itemsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ok();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();


    }
}
