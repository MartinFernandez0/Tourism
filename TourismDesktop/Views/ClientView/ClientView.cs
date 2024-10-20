using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;
using System.Data;
using System.Globalization;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDocument.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            DateBirth.Value = DateTime.Now;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridClientView.SelectedRows.Count > 0)
            {
                int index = dataGridClientView.SelectedRows[0].Index;
                int id = (int)dataGridClientView.Rows[index].Cells["ID"].Value;

                txtFirstName.Text = ClientCurrent.FirstName;
                txtLastName.Text = ClientCurrent.LastName;
                txtDocument.Text = ClientCurrent.Document;
                txtEmail.Text = ClientCurrent.Email;
                txtPhoneNumber.Text = ClientCurrent.PhoneNumber;
                DateBirth.Value = ClientCurrent.DateBirth;

                tabControl1.SelectTab(tabPageAddEdit);
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ClientCurrent == null)
            {
                // Add new client
                var client = new pfClient
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Document = txtDocument.Text,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    DateBirth = DateBirth.Value
                };

                await ClientService.AddAsync(client);
            }
            else
            {
                // Edit existing client
                ClientCurrent.FirstName = txtFirstName.Text;
                ClientCurrent.LastName = txtLastName.Text;
                ClientCurrent.Document = txtDocument.Text;
                ClientCurrent.Email = txtEmail.Text;
                ClientCurrent.PhoneNumber = txtPhoneNumber.Text;
                ClientCurrent.DateBirth = DateBirth.Value;

                await ClientService.UpdateAsync(ClientCurrent);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //HAcemo el delete

        }
    }
}

