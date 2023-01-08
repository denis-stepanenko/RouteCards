using Microsoft.Reporting.WinForms;
using RouteCards.Data;
using System;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class LeanProductionOperationsReportForm : Form
    {
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly int _cardId;

        public LeanProductionOperationsReportForm(int cardId)
        {
            InitializeComponent();
            _cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            reportViewer.Reset();

            var operations = _cardOperationRepo.GetByCard(_cardId);

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.LeanProductionOperationsReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();
    }
}
