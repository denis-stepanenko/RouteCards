using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class OperationForm : Form
    {
        OperationRepo repo = new OperationRepo();

        Operation item;

        public OperationForm(Operation item)
        {
            InitializeComponent();
            this.item = item;

            if (item != null)
            {
                codeTextBox.Text = item.Code;
                nameTextBox.Text = item.Name;
                groupNameTextBox.Text = item.GroupName;
                departmentNumericUpDown.Value = item.Department;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (item == null)
            {
                var newOperation = new Operation
                {
                    Code = codeTextBox.Text,
                    Name = nameTextBox.Text,
                    GroupName = groupNameTextBox.Text,
                    Department = (int)departmentNumericUpDown.Value
                };

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (new[] { 4, 5, 6 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 4, 5, 6 }.Contains(newOperation.Department))
                        {
                            MessageBox.Show("Вы можете редактировать только операции механических цехов", "Внимание");
                            return;
                        }
                    }

                    if (new[] { 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 13, 17, 80, 82 }.Contains(newOperation.Department))
                        {
                            MessageBox.Show("Вы можете редактировать только операции сборочных цехов", "Внимание");
                            return;
                        }
                    }
                }

                bool result = repo.IsThereOperationWithDepartmentAndName(newOperation);
                if (result)
                {
                    MessageBox.Show("В указанном цехе уже есть операция с указанным именем");
                    return;
                }

                try
                {
                    repo.Add(newOperation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                item.Code = codeTextBox.Text;
                item.Name = nameTextBox.Text;
                item.GroupName = groupNameTextBox.Text;
                item.Department = (int)departmentNumericUpDown.Value;

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (new[] { 4, 5, 6 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 4, 5, 6 }.Contains(item.Department))
                        {
                            MessageBox.Show("Вы можете редактировать только операции механических цехов", "Внимание");
                            return;
                        }
                    }

                    if (new[] { 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 13, 17, 80, 82 }.Contains(item.Department))
                        {
                            MessageBox.Show("Вы можете редактировать только операции сборочных цехов", "Внимание");
                            return;
                        }
                    }
                }

                //if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                //{
                //    if (item.Department != AuthorizationService.User.Department)
                //    {
                //        MessageBox.Show("Вы не можете использовать номер другого цеха", "Внимание");
                //        return;
                //    }
                //}

                bool result = repo.IsThereOperationWithDepartmentAndName(item);
                if (result)
                {
                    MessageBox.Show("В указанном цехе уже есть операция с указанным именем");
                    return;
                }

                try
                {
                    repo.Update(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Close();
        }

    }
}

