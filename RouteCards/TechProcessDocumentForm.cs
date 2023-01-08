using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class TechProcessDocumentForm : Form
    {
        private readonly TechProcessDocumentRepo _repo = new TechProcessDocumentRepo();

        private readonly TechProcessDocument _document;
        private readonly TechProcess _techProcess;

        public TechProcessDocumentForm(TechProcessDocument document, TechProcess techProcess)
        {
            InitializeComponent();
            _document = document;
            _techProcess = techProcess;

            nameTextBox.Text = document?.Name;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (_document == null)
            {
                var item = new TechProcessDocument
                {
                    TechProcessId = _techProcess.Id,
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
