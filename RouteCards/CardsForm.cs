using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardsForm : Form
    {
        private readonly CardRepo _repo = new CardRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private IEnumerable<Card> _items;

        public CardsForm()
        {
            InitializeComponent();

            var user = AuthorizationService.User;

            if (user.RoleId == 0)
            {
                duplicateButton.Enabled = false;
                removeButton.Enabled = false;
                addUsingTechProcessButton.Enabled = false;
            }

            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
            {
                int idx = departmentsComboBox.Items.IndexOf(user.Department.ToString());
                departmentsComboBox.SelectedIndex = idx;
            }
            else
            {
                departmentsComboBox.SelectedIndex = 0;
            }
        }

        void GetItems()
        {
            _items = _repo.GetAll();

            itemsDataGridView.DataSource = _items;

            Filter();
        }

        void Filter()
        {
            string department = departmentsComboBox.SelectedIndex == 0 ? null : (string)departmentsComboBox.SelectedItem;

            itemsDataGridView.DataSource = _items.Where(x =>
            (x.Number ?? "").Contains(filterPlaceholderTextBox.Value.ToLower())
            && (
                (x.ProductCode ?? "").ToString().ToLower().Contains(codeNameStageFilterPlaceholderTextBox.Value.ToLower())
                || (x.ProductName ?? "").ToString().ToLower().Contains(codeNameStageFilterPlaceholderTextBox.Value.ToLower())
                || (x.Stage ?? "").ToString().ToLower().Contains(codeNameStageFilterPlaceholderTextBox.Value.ToLower())
                )
            && (x.Department.ToString() == department || department == null)
            ).ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new NewCardForm() { Owner = this }.ShowDialog();

            GetItems();
        }

        void Open()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Card;
            if (item == null) return;

            new CardForm(item.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void openButton_Click(object sender, EventArgs e) => Open();

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();

        private void removeButton_Click(object sender, EventArgs e)
        {
            var items = itemsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as Card).ToList();
            if (items.Count() == 0) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                if (items.Any(x => x.Department != AuthorizationService.User.Department))
                {
                    MessageBox.Show("Среди выбранного есть карты, которые принадлежат другому цеху");
                    return;
                }

            items.ForEach(x => _repo.Remove(x));

            GetItems();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        private void filterPlaceholderDseNameEtapTextBox_TextChanged(object sender, EventArgs e) => Filter();

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Card;
            if (item == null) return;

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                if (item.Department != AuthorizationService.User.Department)
                {
                    MessageBox.Show("Вы не можете продублировать карту другого цеха", "Внимание");
                    return;
                }

            string newCardNumber = _repo.GetNewCardNumberWithinDepartment(item.Department).ToString();

            var card = _repo.Get(item.Id);
            card.Number = newCardNumber;
            int newCardId = _repo.Add(card);

            var operations = _cardOperationRepo.GetByCard(item.Id);
            foreach (var operation in operations)
            {
                operation.CardId = newCardId;
                _cardOperationRepo.Add(operation);
            }

            GetItems();
        }

        private void departmentsComboBox_SelectedIndexChanged(object sender, EventArgs e) => Filter();

        private void addUsingTechProcessButton_Click(object sender, EventArgs e)
        {
            new AddCardUsingTechProcessForm { Owner = this }.ShowDialog();
            GetItems();
        }
    }
}
