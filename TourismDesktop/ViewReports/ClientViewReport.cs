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
using TourismServices.Models;
using TourismServices.Services;

namespace TourismDesktop.ViewReports
{
    public partial class ClientViewReport : Form
    {
        ReportViewer reporte;
        IClientService clientService = new ClientService();
        private pfClient selectedClient;

        public ClientViewReport(pfClient client)
        {
            InitializeComponent();
            //reporte = new ReportViewer();
            //reporte.Dock = DockStyle.Fill;
            //Controls.Add(reporte);
            selectedClient = client;
        }

        private void ClientViewReport_Load(object sender, EventArgs e)
        {
            try
            {
                reporte = new ReportViewer();
                reporte.Dock = DockStyle.Fill;
                Controls.Add(reporte);

                reporte.LocalReport.ReportEmbeddedResource = "TourismDesktop.Reports.ClientViewReport.rdlc";

                // Crea una lista con el cliente seleccionado
                var clients = new List<pfClient> { selectedClient };

                // Añade la lista como fuente de datos del reporte
                reporte.LocalReport.DataSources.Clear();
                reporte.LocalReport.DataSources.Add(new ReportDataSource("DSClients", clients));
                reporte.SetDisplayMode(DisplayMode.PrintLayout);
                reporte.ZoomMode = ZoomMode.Percent;
                reporte.ZoomPercent = 100;
                reporte.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
