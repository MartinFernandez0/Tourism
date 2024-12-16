using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using TourismServices.Enums;
using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismDesktop.ViewReports
{
    public partial class ClientViewReport : Form
    {
        private ReportViewer reporte;
        private readonly IClientService clientService;
        private readonly pfClient selectedClient;

        public ClientViewReport(pfClient client)
        {
            InitializeComponent();
            clientService = new ClientService();
            selectedClient = client;
        }

        private async void ClientViewReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Inicializa y configura el ReportViewer
                reporte = new ReportViewer
                {
                    Dock = DockStyle.Fill
                };
                this.Controls.Add(reporte);

                // Configura el reporte embebido
                reporte.LocalReport.ReportEmbeddedResource = "TourismDesktop.Reports.ClientViewReport.rdlc";

                // Obtén los datos de forma asincrónica
                var clients = new List<pfClient> { selectedClient };

                // Configurar el tamaño de la página y los márgenes
                PageSettings pageSettings = new PageSettings()
                {
                    PaperSize = new PaperSize("A4", 827, 1169), // Tamaño A4 en centésimas de pulgada
                    Margins = new Margins(10, 10, 10, 10) // Márgenes
                };
                reporte.SetPageSettings(pageSettings);

                // Limpia y añade la fuente de datos
                reporte.LocalReport.DataSources.Clear();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSClients", clients));

                // Configura el modo de visualización
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;

                // Refresca el reporte
                reporte.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
