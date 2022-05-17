using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardComponentForm : Form
    {
        CardComponentRepo repo = new CardComponentRepo();

        CardComponent item;

        public CardComponentForm(CardComponent item)
        {
            InitializeComponent();
            this.item = item;

            codeTextBox.Text = item.Code;
            nameTextBox.Text = item.Name;
            factoryNumberTextBox.Text = item.FactoryNumber;
            accompanyingDocumentTextBox.Text = item.AccompanyingDocument;
            countNumericUpDown.Value = item.Count;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            item.FactoryNumber = item.FactoryNumber;
            item.AccompanyingDocument = item.AccompanyingDocument;
            item.Count = (int)countNumericUpDown.Value;

            repo.Update(item);
        }
    }
}
