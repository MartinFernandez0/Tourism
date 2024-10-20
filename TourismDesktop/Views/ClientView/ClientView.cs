using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;
using System.Data;
using System.Globalization;
using Stripe;

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
            ListClient.DataSource = await ClientService.GetAllAsync();
            Filterlist = (List<pfClient>)ListClient.DataSource;
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
            ClientCurrent = (pfClient)ListClient.Current;
            txtFirstName.Text = ClientCurrent.FirstName;
            txtLastName.Text = ClientCurrent.LastName;
            txtDocument.Text = ClientCurrent.Document;
            txtEmail.Text = ClientCurrent.Email;
            txtPhoneNumber.Text = ClientCurrent.PhoneNumber;
            DateBirth.Value = DateTime.Now;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtDocument.Text))
            {
                MessageBox.Show("Los campos nombre, apellido y DNI son obligatorios");
                return;
            }

            var pfClient = new pfClient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Document = txtDocument.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                DateBirth = DateBirth.Value
            };

            if (ClientCurrent != null)
            {
                ClientCurrent.FirstName = txtFirstName.Text;
                ClientCurrent.LastName = txtLastName.Text;
                ClientCurrent.Document = txtDocument.Text;
                ClientCurrent.Email = txtEmail.Text;
                ClientCurrent.PhoneNumber = txtPhoneNumber.Text;
                DateBirth.Value = DateTime.Now;

                await ClientService.UpdateAsync(ClientCurrent);
                ClientCurrent = null;
                MessageBox.Show("Cliente modificado correctamente");
            }
            else
            {
                await ClientService.AddAsync(pfClient);
                MessageBox.Show("Cliente agregado correctamente");
            }

            MessageBox.Show("Cliente guardado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadGrid();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDocument.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            DateBirth.Value = DateTime.Now;
            tabControl1.SelectTab(tabPageList);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada");
            tabControl1.SelectTab(tabPageList);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListClient.Current is pfClient pfClient)
            {
                var result = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await ClientService.DeleteAsync(pfClient.ID);
                    await LoadGrid();
                    MessageBox.Show("Cliente eliminado correctamente");
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterClient();
        }

        private void FilterClient()
        {
            var filteredClient = Filterlist.Where(c => c.FirstName.Contains(txtFilter.Text)).ToList();
            ListClient.DataSource = new BindingSource(filteredClient, null);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterClient();
        }
    }
}

