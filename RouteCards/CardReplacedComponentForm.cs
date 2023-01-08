using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class CardReplacedComponentForm : Form
    {
        private readonly CardReplacedComponentRepo _repo = new CardReplacedComponentRepo();

        private readonly CardReplacedComponent _item;

        public CardReplacedComponentForm(int id)
        {
            InitializeComponent();

            _item = _repo.Get(id);

            codeTextBox.Text = _item.Code;
            nameTextBox.Text = _item.Name;
            executorTextBox.Text = _item.ExecutorName;
            replacementReasonTextBox.Text = _item.ReplacementReason;
            factoryNumberTextBox.Text = _item.FactoryNumber;
            dateDateTimePicker.Value = _item.Date;
        }

        private void selectExecutorButton_Click(object sender, EventArgs e)
        {
            var f = new SelectExecutorForm();
            f.ShowDialog();
            if (f.Executor == null) return;

            _item.ExecutorId = f.Executor.Id;
            executorTextBox.Text = f.Executor.FullName;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _item.ReplacementReason = replacementReasonTextBox.Text;
            _item.FactoryNumber = factoryNumberTextBox.Text;
            _item.Date = dateDateTimePicker.Value;

            _repo.Update(_item);
        }
    }
}
