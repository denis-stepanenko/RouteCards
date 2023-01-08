using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class NewTechProcessForm : Form
    {
        private readonly ProductRepo _repo = new ProductRepo();
        private readonly TechProcessRepo _techProcessRepo = new TechProcessRepo();

        public NewTechProcessForm()
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            var items = _repo.GetAll(codeFilterPlaceholderTextBox.Value, nameFilterPlaceholderTextBox.Value);
            itemsDataGridView.DataSource = items;
        }

        private void codeFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();

        private void nameFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Product;
            if (item == null) return;

            string description = descriptionTextBox.Text;
            string creatorName = AuthorizationService.User.Name;

            var newTechProcess = new TechProcess
            {
                ProductCode = item.Code,
                ProductName = item.Name,
                Description = description,
                CreatorName = creatorName
            };

            _techProcessRepo.Add(newTechProcess);

            Close();
        }
    }
}
