using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardFramelessComponentForm : Form
    {
        CardFramelessComponentRepo repo = new CardFramelessComponentRepo();

        int id;
        CardFramelessComponent item;

        public CardFramelessComponentForm(int id)
        {
            InitializeComponent();
            this.id = id;

            item = repo.Get(id);

            codeTextBox.Text = item.Code;
            nameTextBox.Text = item.Name;
            dateOfIssueForProductionDateTimePicker.Value = item.DateOfIssueForProduction;
            dateOfSealingDateTimePicker.Value = item.DateOfSealing;
            daysBeforeSealingNumericUpDown.Value = item.DaysBeforeSealing;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            item.DateOfIssueForProduction = dateOfIssueForProductionDateTimePicker.Value;
            item.DateOfSealing = dateOfSealingDateTimePicker.Value;
            item.DaysBeforeSealing = (int)daysBeforeSealingNumericUpDown.Value;

            repo.Update(item);
        }
    }
}
