using Microsoft.Reporting.WinForms;
using RouteCards.Data;
using RouteCards.Infrastructure;
using RouteCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RouteCards
{
    public partial class RouteCardForProductReportForm : Form
    {
        private readonly SettingsService _settingsService = new SettingsService();

        private readonly CardRepo _cardRepo = new CardRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly int _cardId;

        public RouteCardForProductReportForm(int cardId)
        {
            InitializeComponent();
            _cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            var settings = _settingsService.Load();

            reportViewer.Reset();

            var card = _cardRepo.Get(_cardId);

            var operations = _cardOperationRepo.GetByCard(_cardId).ToList();

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.RouteCardForProductReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetItems();
        }
    }
}
