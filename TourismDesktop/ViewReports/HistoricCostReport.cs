using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourismServices.Enums;
using TourismServices.Interfaces;
using TourismServices.Models;

namespace TourismDesktop.ViewReports
{
    public partial class HistoricCostReport : Form
    {
        private ReportViewer reporte;
        private readonly IClientService clientService;
        List<pfClient> ListClients = new List<pfClient>();

        public HistoricCostReport(List<pfClient> clients)
        {
            InitializeComponent();
            ListClients = clients;
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void HistoricCostReport_Load(object sender, EventArgs e)
        {
            // Configura el reporte embebido
            reporte.LocalReport.ReportEmbeddedResource = "TourismDesktop.Reports.HistoricCostReport.rdlc";

            var clients = ListClients
                .OrderBy(c => c.ReservationDate)
                .Select(clients => new
                {
                    ReservationDate = clients.ReservationDate,
                    FirstName = clients.FirstName,
                    Document = clients.Document,
                    PostalCode = clients.PostalCode,
                    ReservationStatus = clients.ReservationStatus.ToString(),
                    TotalAmount = clients.TotalAmount.ToString("F2"),
                })
                .ToList();

            // Configurar el tamaño de la página y los márgenes
            PageSettings pageSettings = new PageSettings()
            {
                PaperSize = new PaperSize("A4", 827, 1169), // Tamaño A4 en centésimas de pulgada
                Margins = new Margins(10, 10, 10, 10) // Márgenes
            };
            reporte.SetPageSettings(pageSettings);

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSClients", clients));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
