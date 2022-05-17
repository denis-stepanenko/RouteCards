using Microsoft.VisualBasic;
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
        CardRepo repo = new CardRepo();
        DocumentRepo documentRepo = new DocumentRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();

        IEnumerable<Card> items;

        public CardsForm()
        {
            InitializeComponent();

            var productionDepartments = new List<int> { 4, 5, 6, 13, 17, 80, 82 };
            var user = AuthorizationService.User;

            if (user.RoleId == 0)
            {
                addButton.Enabled = false;
                duplicateButton.Enabled = false;
                removeButton.Enabled = false;
            }

            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();

            if (productionDepartments.Contains(user.Department))
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
            items = repo.GetAll();

            itemsDataGridView.DataSource = items;

            Filter();
        }

        void Filter()
        {
            string department = departmentsComboBox.SelectedIndex == 0 ? null : (string)departmentsComboBox.SelectedItem;

            itemsDataGridView.DataSource = items.Where(x =>
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

            foreach (var item in items)
            {
                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (item.Department != AuthorizationService.User.Department)
                    {
                        MessageBox.Show("Среди выбранного есть карты, которые принадлежат другому цеху", "Внимание");
                        return;
                    }
                }
            }

            items.ForEach(x => repo.Remove(x));

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
            {
                if (item.Department != AuthorizationService.User.Department)
                {
                    MessageBox.Show("Вы не можете продублировать карту другого цеха", "Внимание");
                    return;
                }
            }

            //string newCardNumber = Interaction.InputBox("Введите номер новой карты", "Внимание");
            //if (newCardNumber == "") return;

            string newCardNumber = repo.GetNewCardNumberWithinDepartment(item.Department).ToString();

            var card = repo.Get(item.Id);
            card.Number = newCardNumber;
            int newCardId = repo.Add(card);

            var documents = documentRepo.GetAllByCard(card.Id);
            foreach (var document in documents)
            {
                document.CardId = newCardId;
                int newDocumentId = documentRepo.Add(document);

                var operations = documentOperationRepo.GetAll(document.Id);
                foreach (var operation in operations)
                {
                    operation.DocumentId = newDocumentId;
                    documentOperationRepo.Add(operation);
                }
            }

            GetItems();

        }

        private void departmentsComboBox_SelectedIndexChanged(object sender, EventArgs e) => Filter();
    }
}
