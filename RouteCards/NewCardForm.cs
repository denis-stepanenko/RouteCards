using RouteCards.Data;
using RouteCards.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class NewCardForm : Form
    {
        private readonly CardRepo _repo = new CardRepo();
        private readonly ProductRepo _productRepo = new ProductRepo();

        public NewCardForm()
        {
            InitializeComponent();

            itemsDataGridView.AutoGenerateColumns = false;

            departmentNumericUpDown.Value = AuthorizationService.User.Department;

            GenerateCardNumber();

            GetItems();
        }

        void GenerateCardNumber()
        {
            int department = AuthorizationService.User.Department;
            int number = _repo.GetNewCardNumberWithinDepartment(department);
            numberTextBox.Text = number.ToString();
        }

        private void getNewCardNumberButton_Click(object sender, EventArgs e) => GenerateCardNumber();


        void GetItems()
        {
            var items = _productRepo.GetAll(codeFilterPlaceholderTextBox.Value, nameFilterPlaceholderTextBox.Value);
            itemsDataGridView.DataSource = items;
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow?.DataBoundItem as Product;
            if (item == null) return;

            if (string.IsNullOrWhiteSpace(routeTextBox.Text))
            {
                MessageBox.Show("Нет маршрута", "Внимание");
                return;
            }

            string number = numberTextBox.Text;
            int cardDepartment = (int)departmentNumericUpDown.Value;
            bool isThereCardWithNumber = _repo.IsThereCardWithNumberWithinDepartment(number, cardDepartment);
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
                ProductCode = item.Code,
                ProductName = item.Name,
                ProductCount = (int)productCountNumericUpDown.Value,
                Route = routeTextBox.Text,
                Department = (int)departmentNumericUpDown.Value
            };

            int newCardId = _repo.Add(newCard);

            new CardForm(newCardId) { MdiParent = (Owner as CardsForm).MdiParent }.Show();

            Close();
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();

        private void nameFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();


        BindingList<string> departments = new BindingList<string>();

        private void getRouteButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Product;
            if (item == null) return;

            string route = _productRepo.GetRouteByProduct(item.Id, item.TableId);
            routeTextBox.Text = route;
        }

        private void itemsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            routeTextBox.Text = null;
            departments.Clear();
        }
    }
}
