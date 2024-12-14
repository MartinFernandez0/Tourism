using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismServices.Interfaces;
using TourismServices.Services;

namespace TourismDesktop.ViewReports
{
    public partial class ClientViewReport : Form
    {
        ReportViewer reporte;
        IClientService clientService = new ClientService();
        public ClientViewReport()
        {
            InitializeComponent();
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private async void ClientViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "TourismDesktop.Reports.ClientViewReport.rdlc";

            var clients = await clientService.GetAllAsync();

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSClient", clients));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            //definimos zoom 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;
            reporte.RefreshReport();
        }
    }
}
