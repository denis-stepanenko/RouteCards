using Microsoft.Reporting.WinForms;
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
    public partial class PassportReportForm : Form
    {
        CardRepo cardRepo = new CardRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();
        CardDocumentRepo cardDocumentRepo = new CardDocumentRepo();
        CardFramelessComponentRepo cardFramelessComponentRepo = new CardFramelessComponentRepo();
        CardReplacedComponentRepo cardReplacedComponentRepo = new CardReplacedComponentRepo();
        CardModificationRepo cardModificationRepo = new CardModificationRepo();
        CardComponentRepo cardComponentRepo = new CardComponentRepo();
        CardRepairRepo cardRepairRepo = new CardRepairRepo();

        int cardId;

        public PassportReportForm(int cardId)
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

            var documents = cardDocumentRepo.GetAll(cardId);

            var framelessComponents = cardFramelessComponentRepo.GetAll(cardId);

            var replacedComponents = cardReplacedComponentRepo.GetAll(cardId);

            var modifications = cardModificationRepo.GetAll(cardId);

            var components = cardComponentRepo.GetAll(cardId);

            var repairs = cardRepairRepo.GetAll(cardId);

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.PassportReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Documents", documents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("FramelessComponents", framelessComponents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ReplacedComponents", replacedComponents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Modifications", modifications));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Components", components));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Repairs", repairs));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();
    }
}
