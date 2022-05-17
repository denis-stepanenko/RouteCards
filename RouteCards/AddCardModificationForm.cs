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
    public partial class AddCardModificationForm : Form
    {
        OperationRepo operationRepo = new OperationRepo();
        ExecutorRepo executorRepo = new ExecutorRepo();
        CardModificationRepo cardModificationRepo = new CardModificationRepo();

        IEnumerable<Operation> operations;
        IEnumerable<Executor> executors;

        Card card;

        public AddCardModificationForm(Card card)
        {
            InitializeComponent();

            operationsDataGridView.AutoGenerateColumns = false;
            executorsDataGridView.AutoGenerateColumns = false;

            this.card = card;

            GetOperations();

            GetExecutors();
        }

        void GetOperations()
        {
            int department = AuthorizationService.User.Department;
            operations = operationRepo.GetAllByDepartment(department);
            operationsDataGridView.DataSource = operations;
            FilterOperations();
        }

        void GetExecutors()
        {
            int department = AuthorizationService.User.Department;
            executors = executorRepo.GetAllByDepartment(department);
            executorsDataGridView.DataSource = executors;
            FilterExecutors();
        }

        void FilterOperations()
        {
            operationsDataGridView.DataSource = operations.Where(x =>
            x.Code.ToLower().Contains(operationsPlaceholderTextBox.Value.ToLower())
            || x.Name.ToLower().Contains(operationsPlaceholderTextBox.Value.ToLower())
            || x.Code.ToLower().Contains(operationsPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().Contains(operationsPlaceholderTextBox.Value.ToLower())
            ).ToList();
        }

        void FilterExecutors()
        {
            executorsDataGridView.DataSource = executors.Where(x =>
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
                CardId = card.Id,
                Code = operation.Code,
                Name = operation.Name,
                ExecutorId = executor.Id,
                DocumentNumber = documentNumberTextBox.Text
            };

            cardModificationRepo.Add(newCardModification);
        }

    }
}
