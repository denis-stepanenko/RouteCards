using RouteCards.Data;
using RouteCards.Infrastructure;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class TechProcessForm : Form
    {
        private readonly TechProcessRepo _repo = new TechProcessRepo();
        private readonly TechProcessOperationRepo _techProcessOperationRepo = new TechProcessOperationRepo();
        private readonly TechProcessDocumentRepo _techProcessDocumentRepo = new TechProcessDocumentRepo();
        private readonly ProductRepo _productRepo = new ProductRepo();
        private readonly TechProcessPurchasedProductRepo _techProcessPurchasedProductRepo = new TechProcessPurchasedProductRepo();

        private TechProcess _techProcess;

        private LinkedList<TechProcessOperation> _operations;

        private List<Product> _products;

        public TechProcessForm(int id)
        {
            InitializeComponent();
            operationsDataGridView.AutoGenerateColumns = false;
            documentsDataGridView.AutoGenerateColumns = false;
            productsDataGridView.AutoGenerateColumns = false;
            productRelationsDataGridView.AutoGenerateColumns = false;
            purchasedProductsDataGridView.AutoGenerateColumns = false;

            _techProcess = _repo.Get(id);

            if (!(new[] { 3 }.Contains(AuthorizationService.User.RoleId) || AuthorizationService.User.RoleId == 2) 
                || _techProcess.IsConfirmed)
            {
                saveButton.Enabled = false;
                addButton.Enabled = false;
                openButton.Enabled = false;
                removeButton.Enabled = false;
                moveUpButton.Enabled = false;
                moveDownButton.Enabled = false;
                addDocumentButton.Enabled = false;
                openDocumentButton.Enabled = false;
                removeDocumentButton.Enabled = false;
                вставитьToolStripMenuItem.Enabled = false;
                копироватьToolStripMenuItem.Enabled = false;
                вставитьToolStripMenuItem1.Enabled = false;
                копироватьToolStripMenuItem1.Enabled = false;
                removePurchasedProductsButton.Enabled = false;
                addToPurchasedProductsButton.Enabled = false;
                operationsDataGridView.CellDoubleClick -= operationsDataGridView_CellDoubleClick;
                documentsDataGridView.CellDoubleClick -= documentsDataGridView_CellDoubleClick;
                operationsDataGridView.KeyDown -= operationsDataGridView_KeyDown;
                documentsDataGridView.KeyDown -= documentsDataGridView_KeyDown;
            }

            productTextBox.Text = $"{_techProcess.ProductCode} - {_techProcess.ProductName}";
            descriptionTextBox.Text = _techProcess.Description;
            pickerTextBox.Text = _techProcess.Picker;
            recipientTextBox.Text = _techProcess.Recipient;

            GetOperations();

            GetDocuments();

            GetProducts();

            GetPurchasedProducts();
        }

        void GetPurchasedProducts()
        {
            var items = _techProcessPurchasedProductRepo.GetAll(_techProcess.Id).ToList();
            purchasedProductsDataGridView.DataSource = items;
        }

        void GetProducts()
        {
            _products = _productRepo.GetOwnProducts().ToList();
            productsDataGridView.DataSource = _products;
        }

        void GetOperations()
        {
            var items = _techProcessOperationRepo.GetAll(_techProcess.Id);
            _operations = new LinkedList<TechProcessOperation>(items);
            operationsDataGridView.DataSource = _operations.ToList();
        }

        private void refreshOperationsButton_Click(object sender, EventArgs e) => GetOperations();

        private void selectProductButton_Click(object sender, EventArgs e)
        {
            var f = new SelectProductForm();
            f.ShowDialog();

            if (f.Product != null)
            {
                productTextBox.Text = $"{f.Product.Code} - {f.Product.Name}";
                _techProcess.ProductCode = f.Product.Code;
                _techProcess.ProductName = f.Product.Name;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text;
            _techProcess.Description = description;
            _techProcess.Picker = pickerTextBox.Text;
            _techProcess.Recipient = recipientTextBox.Text;

            _repo.Update(_techProcess);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddTechProcessOperationForm(_techProcess.Id).ShowDialog();

            GetOperations();
        }

        void Remove()
        {
            var items = operationsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as TechProcessOperation).ToList();
            if (items.Count() == 0) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            foreach (var item in items)
                _techProcessOperationRepo.Remove(item);

            _techProcessOperationRepo.Reorder(_techProcess.Id);

            GetOperations();
        }


        void Open()
        {
            var item = operationsDataGridView.CurrentRow?.DataBoundItem as TechProcessOperation;
            if (item == null) return;

            new TechProcessOperationForm(item).ShowDialog();

            GetOperations();
        }

        private void operationsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => Open();

        private void openButton_Click(object sender, EventArgs e) => Open();

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            var item = operationsDataGridView.CurrentRow?.DataBoundItem as TechProcessOperation;
            if (item == null) return;

            var previousItem = _operations.Find(item).Previous?.Value;
            if (previousItem == null) return;

            _techProcessOperationRepo.Swap(item, previousItem);

            GetOperations();

            // Костыль для выделения строки
            int idx = operationsDataGridView.Rows.OfType<DataGridViewRow>().Where(x => (x.DataBoundItem as TechProcessOperation).Id == item.Id).ToList().First().Index;
            operationsDataGridView.CurrentCell = operationsDataGridView.Rows[idx].Cells[0];
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            var item = operationsDataGridView.CurrentRow?.DataBoundItem as TechProcessOperation;
            if (item == null) return;

            var nextItem = _operations.Find(item).Next?.Value;
            if (nextItem == null) return;

            _techProcessOperationRepo.Swap(item, nextItem);

            GetOperations();

            // Костыль для выделения строки
            int idx = operationsDataGridView.Rows.OfType<DataGridViewRow>().Where(x => (x.DataBoundItem as TechProcessOperation).Id == item.Id).ToList().First().Index;
            operationsDataGridView.CurrentCell = operationsDataGridView.Rows[idx].Cells[0];
        }

        private void operationsDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e) => e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;

        void GetDocuments()
        {
            var items = _techProcessDocumentRepo.GetAll(_techProcess.Id);
            documentsDataGridView.DataSource = items;
        }

        private void refreshDocumentsButton_Click(object sender, EventArgs e) => GetDocuments();

        private void addDocumentButton_Click(object sender, EventArgs e)
        {
            new TechProcessDocumentForm(null, _techProcess).ShowDialog();

            GetDocuments();
        }

        void OpenDocument()
        {
            var item = documentsDataGridView.CurrentRow?.DataBoundItem as TechProcessDocument;
            if (item == null) return;

            new TechProcessDocumentForm(item, _techProcess).ShowDialog();

            GetDocuments();
        }

        private void openDocumentButton_Click(object sender, EventArgs e) => OpenDocument();

        private void documentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenDocument();

        void RemoveDocument()
        {
            var items = documentsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as TechProcessDocument).ToList();
            if (items.Count() == 0) return;

            var dialog = MessageBox.Show("Удалить выбранные записи?", "Внимание", MessageBoxButtons.YesNo);
            if (dialog != DialogResult.Yes) return;

            items.ForEach(x => _techProcessDocumentRepo.Remove(x));

            GetDocuments();
        }

        private void removeDocumentButton_Click(object sender, EventArgs e) => RemoveDocument();

        void CopyOperations()
        {
            var items = operationsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as TechProcessOperation).ToList();
            if (items.Count() == 0) return;

            LocalClipboardService.Set<TechProcessOperation>(items);
        }

        void PasteOperations()
        {
            var items = LocalClipboardService.Get<TechProcessOperation>();

            foreach (var item in items)
            {
                item.TechProcessId = _techProcess.Id;
                _techProcessOperationRepo.Add(item);
            }

            GetOperations();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e) => CopyOperations();

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) => PasteOperations();

        private void removeButton_Click(object sender, EventArgs e) => Remove();

        private void operationsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) Remove();
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C) CopyOperations();
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V) PasteOperations();
        }

        void CopyDocuments()
        {
            var items = documentsDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as TechProcessDocument).ToList();
            if (items.Count() == 0) return;

            LocalClipboardService.Set<TechProcessDocument>(items);
        }

        void PasteDocuments()
        {
            var items = LocalClipboardService.Get<TechProcessDocument>();

            foreach (var item in items)
            {
                item.TechProcessId = _techProcess.Id;
                _techProcessDocumentRepo.Add(item);
            }

            GetDocuments();
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e) => CopyDocuments();

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e) => PasteDocuments();

        private void documentsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveDocument();
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C) CopyDocuments();
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V) PasteDocuments();
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = filterTextBox.Text;

            productsDataGridView.DataSource = _products.Where(x => 
            (x.Code ?? "").ToLower().Contains(filter.ToLower()) 
            || (x.Name ?? "").ToLower().Contains(filter.ToLower())).ToList();
        }

        private void showProductRelationsButton_Click(object sender, EventArgs e)
        {
            var item = productsDataGridView.CurrentRow.DataBoundItem as Product;
            if (item == null) return;

            var relations = _productRepo.GetPurchasedProductRelationsForPickingList(item.Code, 1).ToList();
            productRelationsDataGridView.DataSource = relations;
        }

        private void addToPurchasedProductsButton_Click(object sender, EventArgs e)
        {
            var items = productRelationsDataGridView.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => x.DataBoundItem as ProductRelation).ToList();

            if (items.Count == 0) return;

            foreach (var item in items)
            {
                _techProcessPurchasedProductRepo.Add(new TechProcessPurchasedProduct
                {
                    TechProducessId = _techProcess.Id,
                    Code = item.Code,
                    Name = item.Name,
                    Count = (double)item.Count
                });
            }

            GetPurchasedProducts();
        }

        private void removePurchasedProductsButton_Click(object sender, EventArgs e)
        {
            var items = purchasedProductsDataGridView.SelectedRows.Cast<DataGridViewRow>()
                .Select(x => x.DataBoundItem as TechProcessPurchasedProduct).ToList();

            if (items.Count == 0) return;

            items.ForEach(x => _techProcessPurchasedProductRepo.Remove(x));

            GetPurchasedProducts();
        }
    }
}
