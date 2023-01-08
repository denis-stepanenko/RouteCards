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
        private readonly SettingsService _settingsService = new SettingsService();

        private readonly CardRepo _cardRepo = new CardRepo();
        private readonly CardOperationRepo _cardOperationRepo = new CardOperationRepo();

        private readonly int _cardId;

        public MechanicalDepartmentReportForm(int cardId)
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

            var operations = _cardOperationRepo.GetByCard(_cardId);

            var parameters = new ReportParameterCollection
            {
                new ReportParameter("PDBWorkerName", settings.MechanicalReportSettings.PDBWorkerName),
                new ReportParameter("TCBWorkerName", settings.MechanicalReportSettings.TCBWorkerName),
                new ReportParameter("TechnologistName", settings.MechanicalReportSettings.TechnologistName),
                new ReportParameter("WarehouseWorkerName", settings.MechanicalReportSettings.WarehouseWorkerName),
            };

            reportViewer.LocalReport.ReportEmbeddedResource = "RouteCards.Reports.MechanicalDepartmentCardReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Card", new List<Card> { card }));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("Operations", operations));
            reportViewer.LocalReport.SetParameters(parameters);
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
