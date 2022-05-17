using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardDocumentForm : Form
    {
        CardDocumentRepo repo = new CardDocumentRepo();

        CardDocument document;
        Card card;

        public CardDocumentForm(CardDocument document, Card card)
        {
            InitializeComponent();
            this.document = document;
            this.card = card;

            nameTextBox.Text = document?.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (document == null)
            {
                var item = new CardDocument
                {
                    CardId = card.Id,
                    Name = nameTextBox.Text
                };

                repo.Add(item);
            }
            else
            {
                document.Name = nameTextBox.Text;
                repo.Update(document);
            }
        }
    }
}
