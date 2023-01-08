using Microsoft.Reporting.WinForms;
using RouteCards.Data;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class LeanProductionReportForm : Form
    {
        private readonly CardRepo _cardRepo = new CardRepo();
        private readonly CardDocumentRepo _cardDocumentRepo = new CardDocumentRepo();
        private readonly CardFramelessComponentRepo _cardFramelessComponentRepo = new CardFramelessComponentRepo();
        private readonly CardReplacedComponentRepo _cardReplacedComponentRepo = new CardReplacedComponentRepo();
        private readonly CardModificationRepo _cardModificationRepo = new CardModificationRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly int _cardId;

        public LeanProductionReportForm(int cardId)
        {
            InitializeComponent();
            _cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            reportViewer.Reset();

            var card = _cardRepo.Get(_cardId);

            var operations = _cardOperationRepo.GetByCard(_cardId);

            var documents = _cardDocumentRepo.GetAll(_cardId);

            var framelessComponents = _cardFramelessComponentRepo.GetAll(_cardId);

            var replacedComponents = _cardReplacedComponentRepo.GetAll(_cardId);

            var modifications = _cardModificationRepo.GetAll(_cardId);

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.LeanProductionReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Documents", documents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("FramelessComponents", framelessComponents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ReplacedComponents", replacedComponents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Modifications", modifications));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e) => GetItems();
    }
}
