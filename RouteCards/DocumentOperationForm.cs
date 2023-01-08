using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class DocumentOperationForm : Form
    {
        private readonly DocumentOperationRepo _repo = new DocumentOperationRepo();

        private readonly DocumentOperation _documentOperation;

        public DocumentOperationForm(DocumentOperation documentOperation)
        {
            InitializeComponent();
            _documentOperation = documentOperation;

            codeTextBox.Text = documentOperation.Code;
            nameTextBox.Text = documentOperation.Name;
            countNumericUpDown.Value = documentOperation.Count;
            descriptionTextBox.Text = documentOperation.Description;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(numberTextBox.Text, @"\d{3}"))
            {
                MessageBox.Show("Номер операции должен состоять из 3 цифр");
                return;
            }

            _documentOperation.Count = (int)countNumericUpDown.Value;
            _documentOperation.Description = descriptionTextBox.Text;
            _documentOperation.Number = numberTextBox.Text;

            _repo.Update(_documentOperation);
        }
    }
}
