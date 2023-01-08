using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class OperationForm : Form
    {
        private readonly OperationRepo _repo = new OperationRepo();

        private readonly Operation _item;

        public OperationForm(Operation item)
        {
            InitializeComponent();
            _item = item;

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
            if (_item == null)
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

                bool result = _repo.IsThereOperationWithDepartmentAndName(newOperation);
                if (result)
                {
                    MessageBox.Show("В указанном цехе уже есть операция с указанным именем");
                    return;
                }

                try
                {
                    _repo.Add(newOperation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                _item.Code = codeTextBox.Text;
                _item.Name = nameTextBox.Text;
                _item.GroupName = groupNameTextBox.Text;
                _item.Department = (int)departmentNumericUpDown.Value;

                if (new[] { 4, 5, 6, 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                {
                    if (new[] { 4, 5, 6 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 4, 5, 6 }.Contains(_item.Department))
                        {
                            MessageBox.Show("Вы можете редактировать только операции механических цехов", "Внимание");
                            return;
                        }
                    }

                    if (new[] { 13, 17, 80, 82 }.Contains(AuthorizationService.User.Department))
                    {
                        if (!new[] { 13, 17, 80, 82 }.Contains(_item.Department))
                        {
                            MessageBox.Show("Вы можете редактировать только операции сборочных цехов", "Внимание");
                            return;
                        }
                    }
                }

                bool result = _repo.IsThereOperationWithDepartmentAndName(_item);
                if (result)
                {
                    MessageBox.Show("В указанном цехе уже есть операция с указанным именем");
                    return;
                }

                try
                {
                    _repo.Update(_item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Close();
        }

    }
}

