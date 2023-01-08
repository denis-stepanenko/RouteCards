using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddCardModificationForm : Form
    {
        private readonly OperationRepo _operationRepo = new OperationRepo();
        private readonly ExecutorRepo _executorRepo = new ExecutorRepo();
        private readonly CardModificationRepo _cardModificationRepo = new CardModificationRepo();

        private readonly Card _card;

        private IEnumerable<Operation> _operations;
        private IEnumerable<Executor> _executors;

        public AddCardModificationForm(Card card)
        {
            InitializeComponent();

            operationsDataGridView.AutoGenerateColumns = false;
            executorsDataGridView.AutoGenerateColumns = false;

            _card = card;

            GetOperations();

            GetExecutors();
        }

        void GetOperations()
        {
            int department = AuthorizationService.User.Department;
            _operations = _operationRepo.GetAllByDepartment(department);
            operationsDataGridView.DataSource = _operations;
            FilterOperations();
        }

        void GetExecutors()
        {
            int department = AuthorizationService.User.Department;
            _executors = _executorRepo.GetAllByDepartment(department);
            executorsDataGridView.DataSource = _executors;
            FilterExecutors();
        }

        void FilterOperations()
        {
            operationsDataGridView.DataSource = _operations.Where(x =>
            x.Code.ToLower().Contains(operationsPlaceholderTextBox.Value.ToLower())
            || x.Name.ToLower().Contains(operationsPlaceholderTextBox.Value.ToLower())
            || x.Code.ToLower().Contains(operationsPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().Contains(operationsPlaceholderTextBox.Value.ToLower())
            ).ToList();
        }

        void FilterExecutors()
        {
            executorsDataGridView.DataSource = _executors.Where(x =>
            x.FirstName.ToLower().Contains(executorsPlaceholderTextBox.Value.ToLower())
            || x.SecondName.ToLower().Contains(executorsPlaceholderTextBox.Value.ToLower())
            || x.Patronymic.ToLower().Contains(executorsPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().Contains(executorsPlaceholderTextBox.Value.ToLower())
            ).ToList();
        }

        private void operationsPlaceholderTextBox_TextChanged(object sender, EventArgs e) => FilterOperations();

        private void executorsPlaceholderTextBox_TextChanged(object sender, EventArgs e) => FilterExecutors();

        private void refreshOperationsButton_Click(object sender, EventArgs e) => GetOperations();

        private void refreshExecutorsButton_Click(object sender, EventArgs e) => GetExecutors();

        private void okButton_Click(object sender, EventArgs e)
        {
            var operation = operationsDataGridView.CurrentRow?.DataBoundItem as Operation;
            var executor = executorsDataGridView.CurrentRow?.DataBoundItem as Executor;
            if (operation == null) return;
            if (executor == null) return;

            var newCardModification = new CardModification
            {
                CardId = _card.Id,
                Code = operation.Code,
                Name = operation.Name,
                ExecutorId = executor.Id,
                DocumentNumber = documentNumberTextBox.Text
            };

            _cardModificationRepo.Add(newCardModification);
        }

    }
}
