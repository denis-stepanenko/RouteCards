using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CloseOperationForm : Form
    {
        private readonly ExecutorRepo _repo = new ExecutorRepo();
        private readonly DocumentOperationRepo _documentOperationRepo = new DocumentOperationRepo();
        private readonly DocumentRepo _documentRepo = new DocumentRepo();

        private readonly DocumentOperation _documentOperation;

        private IEnumerable<Executor> _items;

        public CloseOperationForm(DocumentOperation documentOperation)
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            _documentOperation = documentOperation;

            GetItems();
        }

        void GetItems()
        {
            var document = _documentRepo.Get(_documentOperation.DocumentId);
            int department = document.Department;
            _items = _repo.GetAll();
            itemsDataGridView.DataSource = _items;
        }

        void Filter()
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.FirstName.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.SecondName.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Patronymic.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().Contains(filterPlaceholderTextBox.Value.ToLower())
            ).ToList();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Executor;
            if (item == null) return;

            if (usingDateCheckBox.Checked)
            {
                _documentOperation.StartDate = startDateDateTimePicker.Value;
                _documentOperation.EndDate = endDateDateTimePicker.Value;
            }

            _documentOperation.ExecutorId = item.Id;

            _documentOperationRepo.Update(_documentOperation);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
