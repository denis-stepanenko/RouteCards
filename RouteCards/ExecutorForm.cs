using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class ExecutorForm : Form
    {
        ExecutorRepo repo = new ExecutorRepo();

        Executor executor;

        public ExecutorForm(Executor executor)
        {
            InitializeComponent();
            this.executor = executor;

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
            if (executor == null)
            {
                var newExecutor = new Executor
                {
                    FirstName = firstNameTextBox.Text,
                    SecondName = secondNameTextBox.Text,
                    Patronymic = patronymicTextBox.Text,
                    Department = (int)departmentNumericUpDown.Value
                };

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (newExecutor.Department != AuthorizationService.User.Department)
                    {
                        MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                        return;
                    }
                }

                repo.Add(newExecutor);
            }
            else
            {
                executor.FirstName = firstNameTextBox.Text;
                executor.SecondName = secondNameTextBox.Text;
                executor.Patronymic = patronymicTextBox.Text;
                executor.Department = (int)departmentNumericUpDown.Value;

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (executor.Department != AuthorizationService.User.Department)
                    {
                        MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                        return;
                    }
                }

                repo.Update(executor);
            }

            this.Close();
        }
    }
}
