using Microsoft.Reporting.WinForms;
using RouteCards.Data;
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
    public partial class LeanProductionOperationsReportForm : Form
    {
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();

        int cardId;

        public LeanProductionOperationsReportForm(int cardId)
        {
            InitializeComponent();
            this.cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            reportViewer.Reset();

            var operations = documentOperationRepo.GetAllByCard(cardId);

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.LeanProductionOperationsReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();
    }
}
