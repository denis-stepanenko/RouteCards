using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class UserForm : Form
    {
        private readonly UserRepo _repo = new UserRepo();

        private readonly User _item;

        public UserForm(User item)
        {
            InitializeComponent();
            _item = item;

            if (item != null)
            {
                nameTextBox.Text = item.Name;
                departmentNumericUpDown.Value = item.Department;
                passwordTextBox.Text = item.Password;
                roleIdNumericUpDown.Value = item.RoleId;
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_item == null)
            {
                var newUser = new User
                {
                    Name = nameTextBox.Text,
                    Department = (int)departmentNumericUpDown.Value,
                    Password = passwordTextBox.Text,
                    RoleId = (int)roleIdNumericUpDown.Value
                };

                bool isThereUser = _repo.IsThereUser(newUser);
                if (isThereUser)
                {
                    MessageBox.Show("Такой пользователь уже существует в указанном подразделении", "Внимание");
                    return;
                }

                _repo.Add(newUser);
            }
            else
            {
                _item.Name = nameTextBox.Text;
                _item.Department = (int)departmentNumericUpDown.Value;
                _item.Password = passwordTextBox.Text;
                _item.RoleId = (int)roleIdNumericUpDown.Value;

                bool isThereUser = _repo.IsThereUser(_item);
                if (isThereUser)
                {
                    MessageBox.Show("Такой пользователь уже существует в указанном подразделении", "Внимание");
                    return;
                }

                _repo.Update(_item);

                var currentUser = AuthorizationService.User;
                if (_item.Id == currentUser.Id)
                {
                    MessageBox.Show("Изменения вступят в силу после перезапуска", "Внимание");
                }
            }

            Close();
        }

        private void generatePsdButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = GeneratePwd();
        }

        string GeneratePwd()
        {
            var random = new Random();
            var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return string.Join("", Enumerable.Range(1, 6).Select(x => chars[random.Next(chars.Length)]));
        }
    }
}
