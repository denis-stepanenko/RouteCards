using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class UserForm : Form
    {
        UserRepo repo = new UserRepo();

        User item;

        public UserForm(User item)
        {
            InitializeComponent();
            this.item = item;

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
            if (item == null)
            {
                var newUser = new User
                {
                    Name = nameTextBox.Text,
                    Department = (int)departmentNumericUpDown.Value,
                    Password = passwordTextBox.Text,
                    RoleId = (int)roleIdNumericUpDown.Value
                };

                bool isThereUser = repo.IsThereUser(newUser);
                if (isThereUser)
                {
                    MessageBox.Show("Такой пользователь уже существует в указанном подразделении", "Внимание");
                    return;
                }

                repo.Add(newUser);
            }
            else
            {
                item.Name = nameTextBox.Text;
                item.Department = (int)departmentNumericUpDown.Value;
                item.Password = passwordTextBox.Text;
                item.RoleId = (int)roleIdNumericUpDown.Value;

                bool isThereUser = repo.IsThereUser(item);
                if (isThereUser)
                {
                    MessageBox.Show("Такой пользователь уже существует в указанном подразделении", "Внимание");
                    return;
                }

                repo.Update(item);

                var currentUser = AuthorizationService.User;
                if (item.Id == currentUser.Id)
                {
                    MessageBox.Show("Изменения вступят в силу после перезапуска", "Внимание");
                }
            }

            this.Close();
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
