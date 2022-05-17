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
    public partial class AddCardReplacedComponentForm : Form
    {
        ProductRepo productRepo = new ProductRepo();
        ExecutorRepo executorRepo = new ExecutorRepo();
        CardReplacedComponentRepo cardReplacedComponentRepo = new CardReplacedComponentRepo();

        Card card;

        //IEnumerable<Product> products;
        IEnumerable<Executor> executors;

        public AddCardReplacedComponentForm(Card card)
        {
            InitializeComponent();

            productsDataGridView.AutoGenerateColumns = false;
            executorsDataGridView.AutoGenerateColumns = false;

            this.card = card;

            GetProducts();
            GetExecutors();
        }

        void GetProducts()
        {
            //products = productRepo.GetAll();
            //productsDataGridView.DataSource = products;
            var items = productRepo.GetAll(productsFilterPlaceholderTextBox.Value);
            productsDataGridView.DataSource = items;
        }

        void GetExecutors()
        {
            int department = AuthorizationService.User.Department;
            executors = executorRepo.GetAllByDepartment(department);
            executorsDataGridView.DataSource = executors;
        }

        //void FilterProducts()
        //{
        //    productsDataGridView.DataSource = products.Where(x =>
        //    x.Code.ToLower().Contains(productsFilterPlaceholderTextBox.Value.ToLower())
        //    || (x.Name?.ToLower() ?? "").Contains(productsFilterPlaceholderTextBox.Value.ToLower())).ToList();
        //}

        void FilterExecutors()
        {
            executorsDataGridView.DataSource = executors.Where(x =>
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
                CardId = card.Id,
                Code = product.Code,
                Name = product.Name,
                ReplacementReason = replacementReasonTextBox.Text,
                FactoryNumber = factoryNumberTextBox.Text,
                Date = dateDateTimePicker.Value,
                ExecutorId = executor.Id
            };

            cardReplacedComponentRepo.Add(newComponent);
        }


        private void executorFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => FilterExecutors();

        private void productsFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetProducts();
    }
}
