using Microsoft.Reporting.WinForms;
using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class AssemblyDepartmentReportForm : Form
    {
        CardRepo cardRepo = new CardRepo();
        DocumentOperationRepo documentOperationRepo = new DocumentOperationRepo();
        CardDocumentRepo cardDocumentRepo = new CardDocumentRepo();
        CardFramelessComponentRepo cardFramelessComponentRepo = new CardFramelessComponentRepo();
        CardReplacedComponentRepo cardReplacedComponentRepo = new CardReplacedComponentRepo();
        CardModificationRepo cardModificationRepo = new CardModificationRepo();
        CardComponentRepo cardComponentRepo = new CardComponentRepo();

        int cardId;

        public AssemblyDepartmentReportForm(int cardId)
        {
            InitializeComponent();
            this.cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            reportViewer1.Reset();

            var card = cardRepo.Get(cardId);

            var operations = documentOperationRepo.GetAllByCard(cardId);

            var documents = cardDocumentRepo.GetAll(cardId);

            var framelessComponents = cardFramelessComponentRepo.GetAll(cardId);

            var replacedComponents = cardReplacedComponentRepo.GetAll(cardId);

            var modifications = cardModificationRepo.GetAll(cardId);

            var components = cardComponentRepo.GetAll(cardId);

            reportViewer1.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.AssemblyDepartmentReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Documents", documents));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("FramelessComponents", framelessComponents));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReplacedComponents", replacedComponents));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Modifications", modifications));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Components", components));
            reportViewer1.RefreshReport();

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);


            reportViewer2.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.AssemblyDepartmentLiner1Report.rdlc";
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("Documents", documents));
            reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("Modifications", modifications));
            reportViewer2.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();
    }
}
