using Microsoft.Reporting.WinForms;
using RouteCards.Data;
using RouteCards.Infrastructure;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class MechanicalDepartmentReportForm : Form
    {
        CardRepo cardRepo = new CardRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();

        int cardId;

        public MechanicalDepartmentReportForm(int cardId)
        {
            InitializeComponent();
            this.cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            reportViewer.Reset();

            var card = cardRepo.Get(cardId);

            var operations = documentOperationRepo.GetAllByCard(cardId);

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.MechanicalDepartmentCardReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();
    }
}
