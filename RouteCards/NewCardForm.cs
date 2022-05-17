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
        CardRepo repo = new CardRepo();
        DocumentRepo documentRepo = new DocumentRepo();
        ProductRepo productRepo = new ProductRepo();

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
            int number = repo.GetNewCardNumberWithinDepartment(department);
            numberTextBox.Text = number.ToString();
        }

        private void getNewCardNumberButton_Click(object sender, EventArgs e) => GenerateCardNumber();


        void GetItems()
        {
            var items = productRepo.GetAll(codeFilterPlaceholderTextBox.Value, nameFilterPlaceholderTextBox.Value);
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
            bool isThereCardWithNumber = repo.IsThereCardWithNumberWithinDepartment(number, cardDepartment);
            if (isThereCardWithNumber)
            {
                MessageBox.Show("Маршрутный лист с таким номером уже существует", "Внимание");
                return;
            }

            if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
            {
                if (cardDepartment != AuthorizationService.User.Department)
                {
                    MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                    return;
                }
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

            int newCardId = repo.Add(newCard);

            var departments = newCard.Route.Split(' ');
            foreach (var department in departments)
            {
                var newDocument = new Document
                {
                    CardId = newCardId,
                    Number = department,
                    Department = Convert.ToInt32(department)
                };
                documentRepo.Add(newDocument);
            }

            new CardForm(newCardId) { MdiParent = (this.Owner as CardsForm).MdiParent }.Show();

            this.Close();
        }

        private void filterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();

        private void nameFilterPlaceholderTextBox_TextChanged(object sender, EventArgs e) => GetItems();


        BindingList<string> departments = new BindingList<string>();

        private void getRouteButton_Click(object sender, EventArgs e)
        {
            var item = itemsDataGridView.CurrentRow.DataBoundItem as Product;
            if (item == null) return;

            string route = productRepo.GetRouteByProduct(item.Id, item.TableId);
            routeTextBox.Text = route;

            var items = route.Split(' ').ToList();

            departments.Clear();
            items.ForEach(x => departments.Add(x));

            departmentsListBox.DataSource = departments;
        }

        private void itemsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            routeTextBox.Text = null;
            departments.Clear();
        }

        private void removeDepartmentButton_Click(object sender, EventArgs e)
        {
            var item = departmentsListBox.SelectedItem;
            if (item == null) return;

            int idx = departmentsListBox.SelectedIndex;
            departments.RemoveAt(idx);

            routeTextBox.Text = departments.Aggregate((a, b) => a + " " + b);
        }

        private void addDepartmentButton_Click(object sender, EventArgs e)
        {
            var department = addedDepartmentNumericUpDown.Value.ToString();
            departments.Add(department);

            routeTextBox.Text = departments.Aggregate((a, b) => a + " " + b);
        }

        private void moveDepartmentUpButton_Click(object sender, EventArgs e)
        {
            var item = departmentsListBox.SelectedItem as string;
            if (item == null) return;

            int idx = departmentsListBox.SelectedIndex;

            departments.RemoveAt(idx);
            int newIdx = idx - 1 > 0 ? idx - 1 : 0;
            departments.Insert(newIdx, item);
            departmentsListBox.SelectedIndex = newIdx;

            routeTextBox.Text = departments.Aggregate((a, b) => a + " " + b);
        }

        private void moveDepartmentDownButton_Click(object sender, EventArgs e)
        {
            var item = departmentsListBox.SelectedItem as string;
            if (item == null) return;

            int idx = departmentsListBox.SelectedIndex;

            departments.RemoveAt(idx);
            int newIdx = (idx + 1 <= departments.Count ? idx + 1 : departments.Count);
            departments.Insert(newIdx, item);
            departmentsListBox.SelectedIndex = newIdx;

            routeTextBox.Text = departments.Aggregate((a, b) => a + " " + b);
        }
    }
}
