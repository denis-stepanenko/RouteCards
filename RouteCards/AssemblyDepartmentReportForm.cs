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
        private readonly CardRepo _cardRepo = new CardRepo();
        private readonly CardDocumentRepo _cardDocumentRepo = new CardDocumentRepo();
        private readonly CardFramelessComponentRepo _cardFramelessComponentRepo = new CardFramelessComponentRepo();
        private readonly CardReplacedComponentRepo _cardReplacedComponentRepo = new CardReplacedComponentRepo();
        private readonly CardModificationRepo _cardModificationRepo = new CardModificationRepo();
        private readonly CardComponentRepo _cardComponentRepo = new CardComponentRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly int _cardId;

        public AssemblyDepartmentReportForm(int cardId)
        {
            InitializeComponent();
            _cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            reportViewer1.Reset();

            var card = _cardRepo.Get(_cardId);

            var operations = _cardOperationRepo.GetByCard(_cardId);

            var documents = _cardDocumentRepo.GetAll(_cardId);

            var framelessComponents = _cardFramelessComponentRepo.GetAll(_cardId);

            var replacedComponents = _cardReplacedComponentRepo.GetAll(_cardId);

            var modifications = _cardModificationRepo.GetAll(_cardId);

            var components = _cardComponentRepo.GetAll(_cardId);

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
