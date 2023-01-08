using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class TechProcessOperationForm : Form
    {
        private readonly TechProcessOperationRepo _repo = new TechProcessOperationRepo();

        private readonly TechProcessOperation _operation;

        public TechProcessOperationForm(TechProcessOperation operation)
        {
            InitializeComponent();
            _operation = _repo.Get(operation.Id);

            codeTextBox.Text = operation.Code;
            nameTextBox.Text = operation.Name;
            countNumericUpDown.Value = operation.Count;
            descriptionTextBox.Text = operation.Description;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _operation.Count = (int)countNumericUpDown.Value;
            _operation.Description = descriptionTextBox.Text;

            _repo.Update(_operation);

            Close();
        }
    }
}
