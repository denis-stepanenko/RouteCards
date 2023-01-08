using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class TechProcessesForm : Form
    {
        private readonly TechProcessRepo _repo = new TechProcessRepo();

        private IEnumerable<TechProcess> _items;

        public TechProcessesForm()
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            if (!(new[] { 3 }.Contains(AuthorizationService.User.RoleId) || AuthorizationService.User.RoleId == 2))
            {
                addButton.Enabled = false;
                removeButton.Enabled = false;
                confirmButton.Enabled = false;
            }

            GetItems();
        }

        void GetItems()
        {
            _items = _repo.GetAll();
            itemsDataGridView.DataSource = _items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void addButton_Click(object sender, EventArgs e)
        {
            new NewTechProcessForm().ShowDialog();
            GetItems();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var items = itemsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as TechProcess).ToList();
            if (items.Count() == 0) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            items.ForEach(x => _repo.Remove(x));

            GetItems();
        }

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as TechProcess;
            if (item == null) return;

            new TechProcessForm(item.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void openButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();

        private void confirmButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as TechProcess;
            var user = AuthorizationService.User;

            if(item.IsConfirmed) 
                _repo.Confirm(item, null);
            else
                _repo.Confirm(item, user.Name);

            GetItems();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.ProductCode.ToLower().Contains(filterTextBox.Text.ToLower())
            || x.ProductName.ToLower().Contains(filterTextBox.Text.ToLower())
            || x.Description.ToLower().Contains(filterTextBox.Text.ToLower())).ToList();
        }
    }
}
