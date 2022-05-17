using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class DocumentOperationForm : Form
    {
        DocumentOperationRepo repo = new DocumentOperationRepo();

        DocumentOperation documentOperation;

        public DocumentOperationForm(DocumentOperation documentOperation)
        {
            InitializeComponent();
            this.documentOperation = documentOperation;

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

            documentOperation.Count = (int)countNumericUpDown.Value;
            documentOperation.Description = descriptionTextBox.Text;
            documentOperation.Number = numberTextBox.Text;

            repo.Update(documentOperation);
        }
    }
}
