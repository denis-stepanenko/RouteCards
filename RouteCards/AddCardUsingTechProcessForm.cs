using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AddCardUsingTechProcessForm : Form
    {
        private readonly TechProcessRepo _repo = new TechProcessRepo();
        private readonly TechProcessOperationRepo _techProcessOperationRepo = new TechProcessOperationRepo();
        private readonly CardRepo _cardRepo = new CardRepo();
        private readonly ProductRepo _productRepo = new ProductRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();
        private readonly CardDocumentRepo _cardDocumentRepo = new CardDocumentRepo();
        private readonly TechProcessDocumentRepo _techProcessDocumentRepo = new TechProcessDocumentRepo();
        private readonly TechProcessPurchasedProductRepo _techProcesssPurchasedProductRepo = new TechProcessPurchasedProductRepo();
        private readonly CardComponentRepo _cardComponentRepo = new CardComponentRepo();

        private IEnumerable<TechProcess> _items;

        public AddCardUsingTechProcessForm()
        {
            InitializeComponent();
            _items = _repo.GetAll();

            itemsDataGridView.DataSource = _items;
            itemsDataGridView.AutoGenerateColumns = false;
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            itemsDataGridView.DataSource = _items.Where(x =>
            x.ProductCode.ToLower().Contains(filterTextBox.Text.ToLower())
            || x.ProductName.ToLower().Contains(filterTextBox.Text.ToLower())
            || x.Description.ToLower().Contains(filterTextBox.Text.ToLower())).ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as TechProcess;
            if (item == null) return;

            if (string.IsNullOrWhiteSpace(routeTextBox.Text))
            {
                MessageBox.Show("Нет маршрута", "Внимание");
                return;
            }

            string number = numberTextBox.Text;
            int cardDepartment = (int)departmentNumericUpDown.Value;
            bool isThereCardWithNumber = _cardRepo.IsThereCardWithNumberWithinDepartment(number, cardDepartment);
            if (isThereCardWithNumber)
            {
                MessageBox.Show("Маршрутный лист с таким номером уже существует", "Внимание");
                return;
            }

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                if (cardDepartment != AuthorizationService.User.Department)
                {
                    MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                    return;
                }

            var newCard = new Card
            {
                Number = numberTextBox.Text,
                Date = dateDateTimePicker.Value,
                ProductCode = item.ProductCode,
                ProductName = item.ProductName,
                ProductCount = (int)productCountNumericUpDown.Value,
                Route = routeTextBox.Text,
                Department = (int)departmentNumericUpDown.Value,
                Picker = item.Picker,
                Recipient = item.Recipient
            };

            int newCardId = _cardRepo.Add(newCard);

            // Перенос операций
            var operations = _techProcessOperationRepo.GetAll(item.Id);
            foreach (var operation in operations)
            {
                _cardOperationRepo.Add(new CardOperation
                {
                    CardId = newCardId,
                    Code = operation.Code,
                    Name = operation.Name,
                    Department = operation.Department,
                    Count = operation.Count,
                    Description = operation.Description,
                    Position = operation.Position,
                });
            }

            // Перенос документов
            var documents = _techProcessDocumentRepo.GetAll(item.Id);
            foreach (var document in documents)
            {
                _cardDocumentRepo.Add(new CardDocument
                {
                    CardId = newCardId,
                    Name = document.Name,
                });
            }

            // Комплектовочные изделия
            var purchasedProducts = _techProcesssPurchasedProductRepo.GetAll(item.Id);
            foreach (var product in purchasedProducts)
            {
                _cardComponentRepo.Add(new CardComponent
                {
                    CardId = newCardId,
                    Code = product.Code,
                    Name = product.Name,
                    Count = (int)product.Count
                });
            }

            new CardForm(newCardId) { MdiParent = (Owner as CardsForm).MdiParent }.Show();

            Close();
        }

        private void getNewCardNumberButton_Click(object sender, EventArgs e) => GenerateCardNumber();

        private void getRouteButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as TechProcess;
            if (item == null) return;

            Product product = _productRepo.GetByCode(item.ProductCode);

            string route = _productRepo.GetRouteByProduct(product.Id, product.TableId);
            routeTextBox.Text = route;
        }

        void GenerateCardNumber()
        {
            int department = AuthorizationService.User.Department;
            int number = _cardRepo.GetNewCardNumberWithinDepartment(department);
            numberTextBox.Text = number.ToString();
        }
    }
}
