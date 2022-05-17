using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class SelectExecutorForm : Form
    {
        ExecutorRepo repo = new ExecutorRepo();

        public Executor executor;

        public SelectExecutorForm()
        {
            InitializeComponent();

            GetItems();
        }

        void GetItems()
        {
            var items = repo.GetAll();
            itemsDataGridView.DataSource = items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Executor;
            if (item == null) return;

            executor = item;
        }
    }
}
