using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddCardReplacedComponentForm : Form
    {
        private readonly ProductRepo _productRepo = new ProductRepo();
        private readonly ExecutorRepo _executorRepo = new ExecutorRepo();
        private readonly CardReplacedComponentRepo _cardReplacedComponentRepo = new CardReplacedComponentRepo();

        private readonly Card _card;

        private IEnumerable<Executor> _executors;

        public AddCardReplacedComponentForm(Card card)
        {
            InitializeComponent();

            productsDataGridView.AutoGenerateColumns = false;
            executorsDataGridView.AutoGenerateColumns = false;

            _card = card;

            GetProducts();
            GetExecutors();
        }

        void GetProducts()
        {
            var items = _productRepo.GetAll(productsFilterPlaceholderTextBox.Value);
            productsDataGridView.DataSource = items;
        }

        void GetExecutors()
        {
            int department = AuthorizationService.User.Department;
            _executors = _executorRepo.GetAllByDepartment(department);
            executorsDataGridView.DataSource = _executors;
        }

        void FilterExecutors()
        {
            executorsDataGridView.DataSource = _executors.Where(x =>
            x.FirstName.ToLower().Contains(executorsFilterPlaceholderTextBox.Value.ToLower())
            || x.SecondName.ToLower().Contains(executorsFilterPlaceholderTextBox.Value.ToLower())
            || x.Patronymic.ToLower().Contains(executorsFilterPlaceholderTextBox.Value.ToLower())
            || x.Department.ToString().ToLower().Contains(executorsFilterPlaceholderTextBox.Value.ToLower())
            ).ToList();
        }

        private void refreshProductsButton_Click(object sender, EventArgs e) => GetProducts();

        private void refreshExecutorsButton_Click(object sender, EventArgs e) => GetExecutors();

        private void okButton_Click(object sender, EventArgs e)
        {
            var product = productsDataGridView.CurrentRow.DataBoundItem as Product;
            var executor = executorsDataGridView.CurrentRow.DataBoundItem as Executor;
            if (product == null) return;
            if (executor == null) return;

            var newComponent = new CardReplacedComponent
            {
                CardId = _card.Id,
                Code = product.Code,
                Name = product.Name,
                ReplacementReason = replacementReasonTextBox.Text,
                FactoryNumber = factoryNumberTextBox.Text,
                Date = dateDateTimePicker.Value,
                ExecutorId = executor.Id
            };

            _cardReplacedComponentRepo.Add(newComponent);
        }


        private void executorFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => FilterExecutors();

        private void productsFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetProducts();
    }
}
