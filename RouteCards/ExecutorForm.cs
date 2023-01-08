using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class ExecutorForm : Form
    {
        private readonly ExecutorRepo _repo = new ExecutorRepo();

        private readonly Executor _executor;

        public ExecutorForm(Executor executor)
        {
            InitializeComponent();
            _executor = executor;

            if (executor != null)
            {
                firstNameTextBox.Text = executor.FirstName;
                secondNameTextBox.Text = executor.SecondName;
                patronymicTextBox.Text = executor.Patronymic;
                departmentNumericUpDown.Value = executor.Department;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_executor == null)
            {
                var newExecutor = new Executor
                {
                    FirstName = firstNameTextBox.Text,
                    SecondName = secondNameTextBox.Text,
                    Patronymic = patronymicTextBox.Text,
                    Department = (int)departmentNumericUpDown.Value
                };

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                    if (newExecutor.Department != AuthorizationService.User.Department)
                    {
                        MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                        return;
                    }

                _repo.Add(newExecutor);
            }
            else
            {
                _executor.FirstName = firstNameTextBox.Text;
                _executor.SecondName = secondNameTextBox.Text;
                _executor.Patronymic = patronymicTextBox.Text;
                _executor.Department = (int)departmentNumericUpDown.Value;

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                    if (_executor.Department != AuthorizationService.User.Department)
                    {
                        MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                        return;
                    }

                _repo.Update(_executor);
            }

            Close();
        }
    }
}
