using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class UsersForm : Form
    {
        private readonly UserRepo _repo = new UserRepo();

        private IEnumerable<User> _items;

        public UsersForm()
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            _items = _repo.GetAll();
            itemsDataGridView.DataSource = _items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void removeButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as User;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            _repo.Remove(item);

            GetItems();
        }

        void Filter()
        {
            itemsDataGridView.DataSource = _items.Where(x => 
            x.Name.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        private void addButton_Click(object sender, EventArgs e)
        {
            new UserForm(null).ShowDialog();

            GetItems();
        }

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as User;
            if (item == null) return;

            new UserForm(item).ShowDialog();

            GetItems();
        }

        private void openButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();
    }
}
