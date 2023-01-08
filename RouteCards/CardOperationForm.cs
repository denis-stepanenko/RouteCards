using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardOperationForm : Form
    {
        private readonly CardOperationRepo _repo = new CardOperationRepo();

        private readonly CardOperation _cardOperation;

        public CardOperationForm(CardOperation cardOperation)
        {
            InitializeComponent();
            _cardOperation = cardOperation;

            codeTextBox.Text = cardOperation.Code;
            nameTextBox.Text = cardOperation.Name;
            countNumericUpDown.Value = cardOperation.Count;
            descriptionTextBox.Text = cardOperation.Description;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(numberTextBox.Text, @"\d{3}"))
            {
                MessageBox.Show("Номер операции должен состоять из 3 цифр");
                return;
            }

            _cardOperation.Count = (int)countNumericUpDown.Value;
            _cardOperation.Description = descriptionTextBox.Text;
            _cardOperation.Number = numberTextBox.Text;

            _repo.Update(_cardOperation);
        }
    }
}
