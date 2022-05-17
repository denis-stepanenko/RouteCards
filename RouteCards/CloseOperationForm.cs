using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CloseOperationForm : Form
    {
        ExecutorRepo repo = new ExecutorRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();
        DocumentRepo documentRepo = new DocumentRepo();

        DocumentOperation documentOperation;

        IEnumerable<Executor> items;

        public CloseOperationForm(DocumentOperation documentOperation)
        {
            InitializeComponent();
            itemsDataGridView.AutoGenerateColumns = false;

            this.documentOperation = documentOperation;

            GetItems();
        }

        void GetItems()
        {
            var document = documentRepo.Get(documentOperation.DocumentId);
            int department = document.Department;
            //items = repo.GetAllByDepartment(department);
            items = repo.GetAll();
            itemsDataGridView.DataSource = items;
        }

        void Filter()
        {
            itemsDataGridView.DataSource = items.Where(x =>
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
                documentOperation.StartDate = startDateDateTimePicker.Value;
                documentOperation.EndDate = endDateDateTimePicker.Value;
            }

            documentOperation.ExecutorId = item.Id;

            documentOperationRepo.Update(documentOperation);
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();
    }
}
