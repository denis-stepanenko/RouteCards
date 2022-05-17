using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardForm : Form
    {
        CardRepo repo = new CardRepo();
        CardDocumentRepo cardDocumentRepo = new CardDocumentRepo();
        CardFramelessComponentRepo cardFramelessComponentRepo = new CardFramelessComponentRepo();
        CardReplacedComponentRepo cardReplacedComponentRepo = new CardReplacedComponentRepo();
        DocumentRepo documentRepo = new DocumentRepo();
        CardModificationRepo cardModificationRepo = new CardModificationRepo();
        CardComponentRepo cardComponentRepo = new CardComponentRepo();
        CardRepairRepo cardRepairRepo = new CardRepairRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();

        Card card;

        public CardForm(int id)
        {
            InitializeComponent();

            card = repo.Get(id);

            var productionDepartments = new List<int> { 4, 5, 6, 13, 17, 80, 82 };
            var user = AuthorizationService.User;

            if (user.RoleId == 0)
            {
                okButton.Enabled = false;
                selectMaterialButton.Enabled = false;
                selectMaterialFromProductButton.Enabled = false;
                selectProductButton.Enabled = false;
                selectOrderButton.Enabled = false;

                moveUpButton.Enabled = false;
                moveDownButton.Enabled = false;
                removeDocumentButton.Enabled = false;
                addDocumentButton.Enabled = false;

                addButton.Enabled = false;
                openButton.Enabled = false;
                removeButton.Enabled = false;

                addCardFramelessComponentButton.Enabled = false;
                openCardFramelessComponentButton.Enabled = false;
                removeCardFramelessComponentsButton.Enabled = false;

                addCardReplacedComponentButton.Enabled = false;
                openCardReplacedComponentButton.Enabled = false;
                removeCardReplacedComponentButton.Enabled = false;

                cardModificationsAddButton.Enabled = false;
                cardModificationsOpenButton.Enabled = false;
                cardModificationsRemoveButton.Enabled = false;

                addComponentButton.Enabled = false;
                componentsOpenButton.Enabled = false;
                removeComponentButton.Enabled = false;
            }

            if (productionDepartments.Contains(user.Department))
            {
                if (card.Department != user.Department)
                {
                    okButton.Enabled = false;
                    selectMaterialButton.Enabled = false;
                    selectMaterialFromProductButton.Enabled = false;
                    selectProductButton.Enabled = false;
                    selectOrderButton.Enabled = false;

                    addButton.Enabled = false;
                    openButton.Enabled = false;
                    removeButton.Enabled = false;

                    addCardFramelessComponentButton.Enabled = false;
                    openCardFramelessComponentButton.Enabled = false;
                    removeCardFramelessComponentsButton.Enabled = false;

                    addCardReplacedComponentButton.Enabled = false;
                    openCardReplacedComponentButton.Enabled = false;
                    removeCardReplacedComponentButton.Enabled = false;

                    cardModificationsAddButton.Enabled = false;
                    cardModificationsOpenButton.Enabled = false;
                    cardModificationsRemoveButton.Enabled = false;

                    addComponentButton.Enabled = false;
                    componentsOpenButton.Enabled = false;
                    removeComponentButton.Enabled = false;
                }
            }

            documentsDataGridView.AutoGenerateColumns = false;
            cardFramelessComponentsDataGridView.AutoGenerateColumns = false;
            cardReplacedComponentsDataGridView.AutoGenerateColumns = false;
            cardModificationsDataGridView.AutoGenerateColumns = false;
            componentsDataGridView.AutoGenerateColumns = false;
            repairsDataGridView.AutoGenerateColumns = false;

            numberTextBox.Text = card.Number;
            dateDateTimePicker.Value = card.Date;
            productTextBox.Text = $"{card.ProductCode} - {card.ProductName}";
            productCountNumericUpDown.Value = card.ProductCount;
            stageTextBox.Text = card.Stage;
            directionTextBox.Text = $"{card.GroupName}, {card.Direction}, {card.ClientOrder}";
            materialTextBox.Text = $"{card.MaterialCode}, {card.MaterialName}, {card.MaterialParameter}";
            routeTextBox.Text = card.Route;
            departmentNumericUpDown.Value = card.Department;
            factoryNumberTextBox.Text = card.FactoryNumber;
            pickingListNumberTextBox.Text = card.PickingListNumber;
            ownerProductNameTextBox.Text = card.OwnerProductName;
            ESDProtectionRequiredCheckBox.Checked = card.ESDProtectionRequired;
            orderTextBox.Text = card.Order;

            GetDocuments();

            GetCardDocuments();

            GetCardFramelessComponents();

            GetCardReplacedComponents();

            GetCardModifications();

            GetCardComponents();

            GetRepairs();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            card.Number = numberTextBox.Text;
            card.Date = dateDateTimePicker.Value;
            card.Stage = stageTextBox.Text;
            card.Department = (int)departmentNumericUpDown.Value;
            card.FactoryNumber = factoryNumberTextBox.Text;
            card.PickingListNumber = pickingListNumberTextBox.Text;
            card.OwnerProductName = ownerProductNameTextBox.Text;
            card.ESDProtectionRequired = ESDProtectionRequiredCheckBox.Checked;
            card.ProductCount = (int)productCountNumericUpDown.Value;
            card.Order = orderTextBox.Text;

            repo.Update(card);
        }


        void GetCardDocuments()
        {
            var items = cardDocumentRepo.GetAll(card.Id);
            documentsDataGridView.DataSource = items;
        }

        private void refreshDocumentsButton_Click(object sender, EventArgs e) => GetCardDocuments();

        void GetCardFramelessComponents()
        {
            var items = cardFramelessComponentRepo.GetAll(card.Id);
            cardFramelessComponentsDataGridView.DataSource = items;
        }

        private void refreshCardFramelessComponentsButton_Click(object sender, EventArgs e) => GetCardFramelessComponents();

        private void removeButton_Click(object sender, EventArgs e)
        {
            var item = documentsDataGridView.CurrentRow.DataBoundItem as CardDocument;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cardDocumentRepo.Remove(item);

                GetCardDocuments();
            }
        }


        void OpenDocument()
        {
            var item = documentsDataGridView.CurrentRow?.DataBoundItem as CardDocument;
            if (item == null) return;

            new CardDocumentForm(item, card) { }.ShowDialog();

            GetCardDocuments();
        }

        private void openButton_Click(object sender, EventArgs e) => OpenDocument();

        private void documentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenDocument();

        private void addButton_Click(object sender, EventArgs e)
        {
            new CardDocumentForm(null, card) { }.ShowDialog();

            GetCardDocuments();
        }

        private void documentsListBox_DoubleClick(object sender, EventArgs e)
        {
            var item = documentsListBox.SelectedItem as Document;
            if (item == null) return;

            new DocumentForm(item) { MdiParent = this.MdiParent }.Show();
        }

        private void selectOrderButton_Click(object sender, EventArgs e)
        {
            var f = new SelectOrderForm(card);
            f.ShowDialog();

            if (f.order != null)
            {
                directionTextBox.Text = $"{f.order.GroupName}, {f.order.Direction}, {f.order.ClientOrder}";
                card.GroupName = f.order.GroupName;
                card.Direction = f.order.Direction;
                card.ClientOrder = f.order.ClientOrder;
            }
        }

        private void selectMaterialButton_Click(object sender, EventArgs e)
        {
            var f = new SelectMaterialForm();
            f.ShowDialog();

            if (f.material != null)
            {
                materialTextBox.Text = $"{f.material.Code}, {f.material.Name}, {f.material.Parameter}";
                card.MaterialCode = f.material.Code;
                card.MaterialName = f.material.Name;
                card.MaterialParameter = f.material.Parameter;
            }
        }

        private void selectMaterialFromProductButton_Click(object sender, EventArgs e)
        {
            var f = new SelectMaterialFromProductForm(card);
            f.ShowDialog();

            if (f.material != null)
            {
                materialTextBox.Text = $"{f.material.Code}, {f.material.Name}, {f.material.Parameter}";
                card.MaterialCode = f.material.Code;
                card.MaterialName = f.material.Name;
                card.MaterialParameter = f.material.Parameter;
            }
        }

        private void removeCardFramelessComponentsButton_Click(object sender, EventArgs e)
        {
            var item = cardFramelessComponentsDataGridView.CurrentRow.DataBoundItem as CardFramelessComponent;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cardFramelessComponentRepo.Remove(item);

                GetCardFramelessComponents();
            }
        }

        private void addCardFramelessComponentButton_Click(object sender, EventArgs e)
        {
            new AddCardFramelessComponentForm(card) { }.ShowDialog();

            GetCardFramelessComponents();
        }

        void OpenCardFramelessComponent()
        {
            var item = cardFramelessComponentsDataGridView.CurrentRow.DataBoundItem as CardFramelessComponent;
            if (item == null) return;

            new CardFramelessComponentForm(item.Id) { }.ShowDialog();

            GetCardFramelessComponents();
        }

        private void openCardFramelessComponentButton_Click(object sender, EventArgs e) => OpenCardFramelessComponent();

        private void cardFramelessComponentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenCardFramelessComponent();

        #region Общее

        private void selectProductButton_Click(object sender, EventArgs e)
        {
            var f = new SelectProductForm();
            f.ShowDialog();

            if (f.product != null)
            {
                productTextBox.Text = $"{f.product.Code} - {f.product.Name}";
                card.ProductCode = f.product.Code;
                card.ProductName = f.product.Name;
            }
        }

        List<Document> documents;

        void GetDocuments()
        {
            documents = documentRepo.GetAllByCard(card.Id).ToList();
            documentsListBox.DataSource = documents;
        }

        #endregion

        #region Общее.Документы
        private void addDocumentButton_Click(object sender, EventArgs e)
        {
            int department = (int)newDocumentDepartmentNumericUpDown.Value;

            var user = AuthorizationService.User;
            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
            {
                if (card.Department != user.Department)
                {
                    if (department != user.Department)
                    {
                        MessageBox.Show("Вы можете добавлять только свой цех в карте другого цеха", "Внимание");
                        return;
                    }
                }
            }

            var newDocument = new Document
            {
                CardId = card.Id,
                Number = department.ToString(),
                Department = department
            };

            documentRepo.Add(newDocument);

            GetDocuments();

            string newRoute = documents.Select(x => x.Department.ToString()).Aggregate((a, b) => a + " " + b);
            routeTextBox.Text = newRoute;
            repo.UpdateRoute(card.Id, newRoute);
        }

        private void removeDocumentButton_Click(object sender, EventArgs e)
        {
            var item = documentsListBox.SelectedItem as Document;
            if (item == null) return;

            var user = AuthorizationService.User;
            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
            {
                if (card.Department != user.Department)
                {
                    if (item.Department != user.Department)
                    {
                        MessageBox.Show("Вы не можете удалить другой цех в карте другого цеха", "Внимание");
                        return;
                    }
                }
            }

            bool areThereOperations = documentOperationRepo.AreThereOperationsInDocument(item.Id);
            if (areThereOperations)
            {
                var dialog = MessageBox.Show("В документе содержатся операции. Все равно удалить его?", "Внимание", MessageBoxButtons.YesNo);
                if (dialog != DialogResult.Yes) return;
            }

            documentRepo.Remove(item);
            documentRepo.Reorder(card.Id);

            GetDocuments();

            string newRoute = documents.Select(x => x.Department.ToString()).Aggregate((a, b) => a + " " + b);
            routeTextBox.Text = newRoute;
            repo.UpdateRoute(card.Id, newRoute);
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            var item = documentsListBox.SelectedItem as Document;
            if (item == null) return;

            var user = AuthorizationService.User;
            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
            {
                if (card.Department != user.Department)
                {
                    if (item.Department != user.Department)
                    {
                        MessageBox.Show("Вы не можете перемещать другие цеха в карте другого цеха", "Внимание");
                        return;
                    }
                }
            }

            int idx = documents.IndexOf(item);
            var previousItem = documents.ElementAtOrDefault(idx - 1);

            if (previousItem == null) return;

            documentRepo.Swap(item, previousItem);

            GetDocuments();
            documentsListBox.SelectedItem = documentsListBox.Items.Cast<Document>().ElementAtOrDefault(idx - 1);

            string newRoute = documents.Select(x => x.Department.ToString()).Aggregate((a, b) => a + " " + b);
            routeTextBox.Text = newRoute;
            repo.UpdateRoute(card.Id, newRoute);
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            var item = documentsListBox.SelectedItem as Document;
            if (item == null) return;

            var user = AuthorizationService.User;
            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
            {
                if (card.Department != user.Department)
                {
                    if (item.Department != user.Department)
                    {
                        MessageBox.Show("Вы не можете перемещать другие цеха в карте другого цеха", "Внимание");
                        return;
                    }
                }
            }

            int idx = documents.IndexOf(item);
            var nextItem = documents.ElementAtOrDefault(idx + 1);

            if (nextItem == null) return;

            documentRepo.Swap(item, nextItem);

            GetDocuments();
            documentsListBox.SelectedItem = documentsListBox.Items.Cast<Document>().ElementAtOrDefault(idx + 1);

            string newRoute = documents.Select(x => x.Department.ToString()).Aggregate((a, b) => a + " " + b);
            routeTextBox.Text = newRoute;
            repo.UpdateRoute(card.Id, newRoute);
        }
        #endregion

        #region Комплектация изделия
        void GetCardComponents()
        {
            var items = cardComponentRepo.GetAll(card.Id);
            componentsDataGridView.DataSource = items;
        }

        private void componentsRefreshButton_Click(object sender, EventArgs e) => GetCardComponents();

        private void removeComponentButton_Click(object sender, EventArgs e)
        {
            var item = componentsDataGridView.CurrentRow.DataBoundItem as CardComponent;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cardComponentRepo.Remove(item);

                GetCardComponents();
            }
        }

        private void addComponentButton_Click(object sender, EventArgs e)
        {
            new AddCardComponentForm(card).ShowDialog();

            GetCardComponents();
        }

        void OpenCardComponent()
        {
            var item = componentsDataGridView.CurrentRow?.DataBoundItem as CardComponent;
            if (item == null) return;

            new CardComponentForm(item).ShowDialog();

            GetCardComponents();
        }

        private void componentsOpenButton_Click(object sender, EventArgs e) => OpenCardComponent();

        private void componentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenCardComponent();

        #endregion

        #region Замена комплектующих

        void GetCardReplacedComponents()
        {
            var items = cardReplacedComponentRepo.GetAll(card.Id);
            cardReplacedComponentsDataGridView.DataSource = items;
        }

        private void cardReplacedComponentsRefreshButton_Click(object sender, EventArgs e) => GetCardReplacedComponents();

        private void addCardReplacedComponentButton_Click(object sender, EventArgs e)
        {
            new AddCardReplacedComponentForm(card).ShowDialog();

            GetCardReplacedComponents();
        }

        private void removeCardReplacedComponentButton_Click(object sender, EventArgs e)
        {
            var item = cardReplacedComponentsDataGridView.CurrentRow.DataBoundItem as CardReplacedComponent;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cardReplacedComponentRepo.Remove(item);

                GetCardReplacedComponents();
            }
        }

        void OpenCardReplacedComponent()
        {
            var item = cardReplacedComponentsDataGridView.CurrentRow.DataBoundItem as CardReplacedComponent;
            if (item == null) return;

            new CardReplacedComponentForm(item.Id).ShowDialog();

            GetCardReplacedComponents();
        }

        private void openCardReplacedComponentButton_Click(object sender, EventArgs e) => OpenCardReplacedComponent();

        private void cardReplacedComponentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenCardReplacedComponent();

        #endregion

        #region Выполненные доработки

        void GetCardModifications()
        {
            var items = cardModificationRepo.GetAll(card.Id);
            cardModificationsDataGridView.DataSource = items;
        }

        private void cardModificationsRefreshButton_Click(object sender, EventArgs e) => GetCardModifications();

        private void cardModificationsRemoveButton_Click(object sender, EventArgs e)
        {
            var item = cardModificationsDataGridView.CurrentRow.DataBoundItem as CardModification;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                cardModificationRepo.Remove(item);

                GetCardModifications();
            }
        }

        private void cardModificationsAddButton_Click(object sender, EventArgs e)
        {
            new AddCardModificationForm(card).ShowDialog();

            GetCardModifications();
        }

        void CardModificationOpen()
        {
            var item = cardModificationsDataGridView.CurrentRow?.DataBoundItem as CardModification;
            if (item == null) return;

            new CardModificationForm(item.Id).ShowDialog();

            GetCardModifications();
        }

        private void cardModificationsOpenButton_Click(object sender, EventArgs e) => CardModificationOpen();
        private void cardModificationsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => CardModificationOpen();

        #endregion

        #region Отчеты
        private void cardReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LeanProductionReportForm(card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void operationsReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LeanProductionOperationsReportForm(card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void mechanicalDepartmentCardReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MechanicalDepartmentReportForm(card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void assemblyDepartmentReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AssemblyDepartmentReportForm(card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void passportReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PassportReportForm(card.Id) { MdiParent = this.MdiParent }.Show();
        }
        #endregion

        #region Ремонты
        void GetRepairs()
        {
            var items = cardRepairRepo.GetAll(card.Id);
            repairsDataGridView.DataSource = items;
        }
        
        private void refreshRepairsButton_Click(object sender, EventArgs e) => GetRepairs();

        #endregion
    }
}
