using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardModificationForm : Form
    {
        private readonly CardModificationRepo _repo = new CardModificationRepo();

        private readonly CardModification _cardModification;

        public CardModificationForm(int id)
        {
            InitializeComponent();

            _cardModification = _repo.Get(id);

            codeTextBox.Text = _cardModification.Code;
            nameTextBox.Text = _cardModification.Name;
            executorNameTextBox.Text = _cardModification.ExecutorName;
            documentTextBox.Text = _cardModification.DocumentNumber;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _cardModification.DocumentNumber = documentTextBox.Text;

            _repo.Update(_cardModification);
        }
    }
}
