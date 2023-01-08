using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardComponentForm : Form
    {
        private readonly CardComponentRepo _repo = new CardComponentRepo();

        private readonly CardComponent _item;

        public CardComponentForm(CardComponent item)
        {
            InitializeComponent();
            _item = item;

            codeTextBox.Text = item.Code;
            nameTextBox.Text = item.Name;
            factoryNumberTextBox.Text = item.FactoryNumber;
            accompanyingDocumentTextBox.Text = item.AccompanyingDocument;
            countNumericUpDown.Value = item.Count;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _item.FactoryNumber = _item.FactoryNumber;
            _item.AccompanyingDocument = _item.AccompanyingDocument;
            _item.Count = (int)countNumericUpDown.Value;

            _repo.Update(_item);
        }
    }
}
