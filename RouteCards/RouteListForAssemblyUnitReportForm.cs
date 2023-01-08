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
    public partial class RouteListForAssemblyUnitReportForm : Form
    {
        private readonly SettingsService _settingsService = new SettingsService();

        private readonly CardRepo _cardRepo = new CardRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();
        private readonly CardFramelessComponentRepo _cardFramelessComponentRepo = new CardFramelessComponentRepo();
        private readonly CardComponentRepo _cardComponentRepo = new CardComponentRepo();
        private readonly CardDocumentRepo _cardDocumentRepo = new CardDocumentRepo();
        private readonly CardRepairRepo _cardRepairRepo = new CardRepairRepo();
        private readonly CardReplacedComponentRepo _cardReplacedComponentRepo = new CardReplacedComponentRepo();

        private readonly int _cardId;

        public RouteListForAssemblyUnitReportForm(int cardId)
        {
            InitializeComponent();
            _cardId = cardId;

            GetItems();
        }

        void GetItems()
        {
            var settings = _settingsService.Load();

            PDBWorkerNameTextBox.Text = settings.MechanicalReportSettings.PDBWorkerName;
            TCBWorkerNameTextBox.Text = settings.MechanicalReportSettings.TCBWorkerName;
            TechnologistNameTextBox.Text = settings.MechanicalReportSettings.TechnologistName;
            WarehouseWorkerNameTextBox.Text = settings.MechanicalReportSettings.WarehouseWorkerName;

            reportViewer.Reset();

            var card = _cardRepo.Get(_cardId);

            var operations = _cardOperationRepo.GetByCard(_cardId).ToList();
            var operationsPart1 = operations.Take(40);
            var operationsPart2 = operations.Skip(40);

            var cardFramelessComponents = _cardFramelessComponentRepo.GetAll(_cardId);
            var cardComponents = _cardComponentRepo.GetAll(_cardId);
            var cardDocuments = _cardDocumentRepo.GetAll(_cardId);
            var cardRepairs = _cardRepairRepo.GetAll(_cardId);
            var cardReplacedComponents = _cardReplacedComponentRepo.GetAll(_cardId);

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.RouteListForAssemblyUnitReportForm.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardFramelessComponents", cardFramelessComponents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardComponents", cardComponents));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardOperationsPart1", operationsPart1));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardOperationsPart2", operationsPart2));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardDocuments", cardDocuments));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardRepairs", cardRepairs));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("CardReplacedComponents", cardReplacedComponents));
            reportViewer.RefreshReport();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var settings = _settingsService.Load();

            settings.MechanicalReportSettings.PDBWorkerName = PDBWorkerNameTextBox.Text;
            settings.MechanicalReportSettings.TCBWorkerName = TCBWorkerNameTextBox.Text;
            settings.MechanicalReportSettings.TechnologistName = TechnologistNameTextBox.Text;
            settings.MechanicalReportSettings.WarehouseWorkerName = WarehouseWorkerNameTextBox.Text;

            _settingsService.Save(settings);

            GetItems();
        }
    }
}
