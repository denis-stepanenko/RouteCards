using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardForm : Form
    {
        private readonly CardRepo _repo = new CardRepo();
        private readonly CardDocumentRepo _cardDocumentRepo = new CardDocumentRepo();
        private readonly CardFramelessComponentRepo _cardFramelessComponentRepo = new CardFramelessComponentRepo();
        private readonly CardReplacedComponentRepo _cardReplacedComponentRepo = new CardReplacedComponentRepo();
        private readonly CardModificationRepo _cardModificationRepo = new CardModificationRepo();
        private readonly CardComponentRepo _cardComponentRepo = new CardComponentRepo();
        private readonly CardRepairRepo _cardRepairRepo = new CardRepairRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly Card _card;

        public CardForm(int id)
        {
            InitializeComponent();

            _card = _repo.Get(id);

            var user = AuthorizationService.User;

            if (user.RoleId == 0)
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

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(user.Department))
                if (_card.Department != user.Department)
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

            documentsDataGridView.AutoGenerateColumns = false;
            cardFramelessComponentsDataGridView.AutoGenerateColumns = false;
            cardReplacedComponentsDataGridView.AutoGenerateColumns = false;
            cardModificationsDataGridView.AutoGenerateColumns = false;
            componentsDataGridView.AutoGenerateColumns = false;
            repairsDataGridView.AutoGenerateColumns = false;

            numberTextBox.Text = _card.Number;
            dateDateTimePicker.Value = _card.Date;
            productTextBox.Text = $"{_card.ProductCode} - {_card.ProductName}";
            productCountNumericUpDown.Value = _card.ProductCount;
            stageTextBox.Text = _card.Stage;
            directionTextBox.Text = $"{_card.GroupName}, {_card.Direction}, {_card.ClientOrder}";
            materialTextBox.Text = $"{_card.MaterialCode}, {_card.MaterialName}, {_card.MaterialParameter}";
            routeTextBox.Text = _card.Route;
            departmentNumericUpDown.Value = _card.Department;
            factoryNumberTextBox.Text = _card.FactoryNumber;
            pickingListNumberTextBox.Text = _card.PickingListNumber;
            ownerProductNameTextBox.Text = _card.OwnerProductName;
            ESDProtectionRequiredCheckBox.Checked = _card.ESDProtectionRequired;
            orderTextBox.Text = _card.Order;
            informationAboutReplacementTextBox.Text = _card.InformationAboutReplacement;
            pickerTextBox.Text = _card.Picker;
            recipientTextBox.Text = _card.Recipient;

            GetCardDocuments();

            GetCardFramelessComponents();

            GetCardReplacedComponents();

            GetCardModifications();

            GetCardComponents();

            GetRepairs();

            GetOperations();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(routeTextBox.Text, @"^[0-9\s]+$"))
            {
                MessageBox.Show("Маршрут должен быть заполнен и состоять только из цифр и пробелов");
                return;
            }

            if (Regex.IsMatch(routeTextBox.Text, @"\s\s+"))
            {
                MessageBox.Show("В маршруте не должно быть более одного пробела, идущих подряд");
                return;
            }

            _card.Number = numberTextBox.Text;
            _card.Date = dateDateTimePicker.Value;
            _card.Stage = stageTextBox.Text;
            _card.Department = (int)departmentNumericUpDown.Value;
            _card.FactoryNumber = factoryNumberTextBox.Text;
            _card.PickingListNumber = pickingListNumberTextBox.Text;
            _card.OwnerProductName = ownerProductNameTextBox.Text;
            _card.ESDProtectionRequired = ESDProtectionRequiredCheckBox.Checked;
            _card.ProductCount = (int)productCountNumericUpDown.Value;
            _card.Order = orderTextBox.Text;
            _card.Route = routeTextBox.Text;
            _card.InformationAboutReplacement = informationAboutReplacementTextBox.Text;
            _card.Picker = pickerTextBox.Text;
            _card.Recipient = recipientTextBox.Text;

            _repo.Update(_card);
            _cardOperationRepo.UpdateCountForOperation005(_card.Id, _card.ProductCount);

            GetOperations();
        }


        void GetCardDocuments()
        {
            var items = _cardDocumentRepo.GetAll(_card.Id);
            documentsDataGridView.DataSource = items;
        }

        private void refreshDocumentsButton_Click(object sender, EventArgs e) => GetCardDocuments();

        void GetCardFramelessComponents()
        {
            var items = _cardFramelessComponentRepo.GetAll(_card.Id);
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
                _cardDocumentRepo.Remove(item);

                GetCardDocuments();
            }
        }


        void OpenDocument()
        {
            var item = documentsDataGridView.CurrentRow?.DataBoundItem as CardDocument;
            if (item == null) return;

            new CardDocumentForm(item, _card) { }.ShowDialog();

            GetCardDocuments();
        }

        private void openButton_Click(object sender, EventArgs e) => OpenDocument();

        private void documentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenDocument();

        private void addButton_Click(object sender, EventArgs e)
        {
            new CardDocumentForm(null, _card) { }.ShowDialog();

            GetCardDocuments();
        }

        private void selectOrderButton_Click(object sender, EventArgs e)
        {
            var f = new SelectOrderForm(_card);
            f.ShowDialog();

            if (f.Order != null)
            {
                directionTextBox.Text = $"{f.Order.GroupName}, {f.Order.Direction}, {f.Order.ClientOrder}";
                _card.GroupName = f.Order.GroupName;
                _card.Direction = f.Order.Direction;
                _card.ClientOrder = f.Order.ClientOrder;
            }
        }

        private void selectMaterialButton_Click(object sender, EventArgs e)
        {
            var f = new SelectMaterialForm();
            f.ShowDialog();

            if (f.Material != null)
            {
                materialTextBox.Text = $"{f.Material.Code}, {f.Material.Name}, {f.Material.Parameter}";
                _card.MaterialCode = f.Material.Code;
                _card.MaterialName = f.Material.Name;
                _card.MaterialParameter = f.Material.Parameter;
            }
        }

        private void selectMaterialFromProductButton_Click(object sender, EventArgs e)
        {
            var f = new SelectMaterialFromProductForm(_card);
            f.ShowDialog();

            if (f.Material != null)
            {
                materialTextBox.Text = $"{f.Material.Code}, {f.Material.Name}, {f.Material.Parameter}";
                _card.MaterialCode = f.Material.Code;
                _card.MaterialName = f.Material.Name;
                _card.MaterialParameter = f.Material.Parameter;
            }
        }

        private void removeCardFramelessComponentsButton_Click(object sender, EventArgs e)
        {
            var item = cardFramelessComponentsDataGridView.CurrentRow.DataBoundItem as CardFramelessComponent;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            _cardFramelessComponentRepo.Remove(item);

            GetCardFramelessComponents();
        }

        private void addCardFramelessComponentButton_Click(object sender, EventArgs e)
        {
            new AddCardFramelessComponentForm(_card) { }.ShowDialog();

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

            if (f.Product != null)
            {
                productTextBox.Text = $"{f.Product.Code} - {f.Product.Name}";
                _card.ProductCode = f.Product.Code;
                _card.ProductName = f.Product.Name;
            }
        }

        List<Document> _documents;

        #endregion

        #region Комплектация изделия
        void GetCardComponents()
        {
            var items = _cardComponentRepo.GetAll(_card.Id);
            componentsDataGridView.DataSource = items;
        }

        private void componentsRefreshButton_Click(object sender, EventArgs e) => GetCardComponents();

        private void removeComponentButton_Click(object sender, EventArgs e)
        {
            var item = componentsDataGridView.CurrentRow.DataBoundItem as CardComponent;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            _cardComponentRepo.Remove(item);

            GetCardComponents();
        }

        private void addComponentButton_Click(object sender, EventArgs e)
        {
            new AddCardComponentForm(_card).ShowDialog();

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
            var items = _cardReplacedComponentRepo.GetAll(_card.Id);
            cardReplacedComponentsDataGridView.DataSource = items;
        }

        private void cardReplacedComponentsRefreshButton_Click(object sender, EventArgs e) => GetCardReplacedComponents();

        private void addCardReplacedComponentButton_Click(object sender, EventArgs e)
        {
            new AddCardReplacedComponentForm(_card).ShowDialog();

            GetCardReplacedComponents();
        }

        private void removeCardReplacedComponentButton_Click(object sender, EventArgs e)
        {
            var item = cardReplacedComponentsDataGridView.CurrentRow.DataBoundItem as CardReplacedComponent;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            _cardReplacedComponentRepo.Remove(item);

            GetCardReplacedComponents();
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
            var items = _cardModificationRepo.GetAll(_card.Id);
            cardModificationsDataGridView.DataSource = items;
        }

        private void cardModificationsRefreshButton_Click(object sender, EventArgs e) => GetCardModifications();

        private void cardModificationsRemoveButton_Click(object sender, EventArgs e)
        {
            var item = cardModificationsDataGridView.CurrentRow.DataBoundItem as CardModification;
            if (item == null) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            _cardModificationRepo.Remove(item);

            GetCardModifications();
        }

        private void cardModificationsAddButton_Click(object sender, EventArgs e)
        {
            new AddCardModificationForm(_card).ShowDialog();

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
            new LeanProductionReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void operationsReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LeanProductionOperationsReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void mechanicalDepartmentCardReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new MechanicalDepartmentReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void assemblyDepartmentReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AssemblyDepartmentReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void passportReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PassportReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void ShortRouteListForAssemblyUnitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ShortRouteListForAssemblyUnitReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }

        private void routeListForAssemblyUnitLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RouteListForAssemblyUnitReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }
        #endregion

        #region Ремонты
        void GetRepairs()
        {
            var items = _cardRepairRepo.GetAll(_card.Id);
            repairsDataGridView.DataSource = items;
        }
        
        private void refreshRepairsButton_Click(object sender, EventArgs e) => GetRepairs();

        #endregion

        LinkedList<CardOperation> _operations;

        #region Операции
        void GetOperations()
        {
            _operations = new LinkedList<CardOperation>(_cardOperationRepo.GetByCard(_card.Id));
            operationsDataGridView.DataSource = _operations.ToList();
        }

        private void removeOperationButton_Click(object sender, EventArgs e)
        {
            var item = operationsDataGridView.CurrentRow.DataBoundItem as CardOperation;
            if (item == null) return;

            _cardOperationRepo.Remove(item);

            GetOperations();
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            new AddCardOperationForm(_card).ShowDialog();

            GetOperations();
        }

        void Open()
        {
            var item = operationsDataGridView.CurrentRow.DataBoundItem as CardOperation;
            if (item == null) return;

            new CardOperationForm(item).ShowDialog();

            GetOperations();
        }

        private void editButton_Click(object sender, EventArgs e) => Open();
        #endregion

        private void moveOperationDownButton_Click(object sender, EventArgs e)
        {
            var item = operationsDataGridView.CurrentRow?.DataBoundItem as CardOperation;
            if (item == null) return;

            var nextItem = _operations.Find(item).Next?.Value;
            if (nextItem == null) return;

            _cardOperationRepo.Swap(item, nextItem);

            GetOperations();
        }

        private void moveOperationUpButton_Click(object sender, EventArgs e)
        {
            var item = operationsDataGridView.CurrentRow?.DataBoundItem as CardOperation;
            if (item == null) return;
            var previousItem = _operations.Find(item).Previous?.Value;
            if (previousItem == null) return;

            _cardOperationRepo.Swap(item, previousItem);

            GetOperations();
        }

        private void routeCardForProductLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RouteCardForProductReportForm(_card.Id) { MdiParent = this.MdiParent }.Show();
        }
    }
}
