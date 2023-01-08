using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardDocumentForm : Form
    {
        private readonly CardDocumentRepo _repo = new CardDocumentRepo();

        private readonly CardDocument _document;
        private readonly Card _card;

        public CardDocumentForm(CardDocument document, Card card)
        {
            InitializeComponent();
            _document = document;
            _card = card;

            nameTextBox.Text = document?.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_document == null)
            {
                var item = new CardDocument
                {
                    CardId = _card.Id,
                    Name = nameTextBox.Text
                };

                _repo.Add(item);
            }
            else
            {
                _document.Name = nameTextBox.Text;
                _repo.Update(_document);
            }
        }
    }
}
