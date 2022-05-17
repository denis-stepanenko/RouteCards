using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardModificationForm : Form
    {
        CardModificationRepo repo = new CardModificationRepo();

        CardModification cardModification;

        public CardModificationForm(int id)
        {
            InitializeComponent();

            cardModification = repo.Get(id);

            codeTextBox.Text = cardModification.Code;
            nameTextBox.Text = cardModification.Name;
            executorNameTextBox.Text = cardModification.ExecutorName;
            documentTextBox.Text = cardModification.DocumentNumber;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            cardModification.DocumentNumber = documentTextBox.Text;

            repo.Update(cardModification);
        }
    }
}
