using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardReplacedComponentForm : Form
    {
        CardReplacedComponentRepo repo = new CardReplacedComponentRepo();

        CardReplacedComponent item;

        public CardReplacedComponentForm(int id)
        {
            InitializeComponent();

            item = repo.Get(id);

            codeTextBox.Text = item.Code;
            nameTextBox.Text = item.Name;
            executorTextBox.Text = item.ExecutorName;
            replacementReasonTextBox.Text = item.ReplacementReason;
            factoryNumberTextBox.Text = item.FactoryNumber;
            dateDateTimePicker.Value = item.Date;
        }

        private void selectExecutorButton_Click(object sender, EventArgs e)
        {
            var f = new SelectExecutorForm();
            f.ShowDialog();
            if (f.executor == null) return;

            item.ExecutorId = f.executor.Id;
            executorTextBox.Text = f.executor.FullName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            item.ReplacementReason = replacementReasonTextBox.Text;
            item.FactoryNumber = factoryNumberTextBox.Text;
            item.Date = dateDateTimePicker.Value;

            repo.Update(item);
        }
    }
}
