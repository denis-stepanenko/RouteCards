using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardFramelessComponentForm : Form
    {
        private readonly CardFramelessComponentRepo _repo = new CardFramelessComponentRepo();

        private readonly int _id;
        private readonly CardFramelessComponent _item;

        public CardFramelessComponentForm(int id)
        {
            InitializeComponent();
            _id = id;

            _item = _repo.Get(id);

            codeTextBox.Text = _item.Code;
            nameTextBox.Text = _item.Name;
            dateOfIssueForProductionDateTimePicker.Value = _item.DateOfIssueForProduction;
            dateOfSealingDateTimePicker.Value = _item.DateOfSealing;
            daysBeforeSealingNumericUpDown.Value = _item.DaysBeforeSealing;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _item.DateOfIssueForProduction = dateOfIssueForProductionDateTimePicker.Value;
            _item.DateOfSealing = dateOfSealingDateTimePicker.Value;
            _item.DaysBeforeSealing = (int)daysBeforeSealingNumericUpDown.Value;

            _repo.Update(_item);
        }
    }
}
