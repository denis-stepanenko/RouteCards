using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class DocumentsForm : Form
    {
        private readonly DocumentRepo _repo = new DocumentRepo();

        public DocumentsForm()
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            var items = _repo.GetAll();
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Document;
            if (item == null) return;

            new DocumentForm(item) { MdiParent = this.MdiParent }.Show();
        }

        private void openButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();
    }
}
