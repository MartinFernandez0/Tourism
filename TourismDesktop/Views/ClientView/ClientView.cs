using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;
using System.Data;

namespace TourismDesktop.Views
{
    public partial class ClientView : Form
    {
        IClientService ClientService = new ClientService();

        BindingSource ListClient = new BindingSource();
        List<pfClient> Filterlist = new List<pfClient>();

        pfClient ClientCurrent;

        public ClientView()
        {
            InitializeComponent();
            dataGridClientView.DataSource = ListClient;
            LoadGrid();
        }

        private async Task LoadGrid()
        {
            var client = await ClientService.GetAllAsync(null);
            ListClient.DataSource = client;
            dataGridClientView.AutoGenerateColumns = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
