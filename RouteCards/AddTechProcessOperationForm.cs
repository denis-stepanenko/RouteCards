using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddTechProcessOperationForm : Form
    {
        private readonly TechProcessOperationRepo _repo = new TechProcessOperationRepo();
        private readonly OperationRepo _operationRepo = new OperationRepo();
        
        private readonly int _techProcessId;

        private IEnumerable<Operation> _items;


        public AddTechProcessOperationForm(int techProcessId)
        {
            InitializeComponent();
            _techProcessId = techProcessId;

            itemsDataGridView.AutoGenerateColumns = false;

            GetItems();
        }

        void GetItems()
        {
            _items = _operationRepo.GetAll();
            itemsDataGridView.DataSource = _items;
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();

        void Filter()
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.Code.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Name.ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().ToLower().Contains(filterPlaceholderTextBox.Value.ToLower())).ToList();
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => Filter();

        void Add()
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Operation;
            if (item == null) return;

            int count = (int)countNumericUpDown.Value;
            string description = descriptionTextBox.Text;

            var operation = new TechProcessOperation
            {
                TechProcessId = _techProcessId,
                Code = item.Code,
                Name = item.Name,
                Department = item.Department,
                Count = count,
                Description = description
            };

            _repo.Add(operation);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Add();

            Close();
        }

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Add();

            Close();
        }

        private void itemsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) AcceptButton?.PerformClick();
            e.Handled = true;
        }
    }
}
