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

        pfClient? ClientCurrent;

        //Manejo boton Eliminados IsDeleted Funcionando
        private bool showingDeleted = false;

        public ClientView()
        {
            InitializeComponent();
            dataGridClientView.DataSource = ListClient;
            LoadGrid();


            //Properties Buttons isDeleted
            btnSeeEliminated.Text = "Eliminados";
            btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
            btnSeeEliminated.ForeColor = System.Drawing.Color.White;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LoadDate
        private async Task LoadGrid()
        {
            var clients = await ClientService.GetAllAsync();
            ListClient.DataSource = clients?.Where(i => !i.IsDeleted).ToList();
            Filterlist = (List<pfClient>)ListClient.DataSource;
        }
        #endregion

        #region BtnSeeDeleted
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (showingDeleted)
            {
                //Mostrar Clientes Activos
                var ActiveClients = await ClientService.GetAllAsync(null);
                ListClient.DataSource = ActiveClients?.Where(i => !i.IsDeleted).ToList();

                //Properties
                btnSeeEliminated.Text = "Eliminados";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                //Mostrar Destinos Eliminados
                var DeletedClients = await ClientService.GetAllDeletedAsync(null);
                ListClient.DataSource = DeletedClients?.Where(i => i.IsDeleted).ToList();

                //Properties
                btnSeeEliminated.Text = "Activos";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightGreen;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            Filterlist = (List<pfClient>)ListClient.DataSource;
            showingDeleted = !showingDeleted;
        }
        #endregion

        #region C.R.U.D
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDocument.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            DateBirth.Value = DateTime.Now;
            

            tabControl1.SelectTab(tabPageAddEdit);
        }
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            ClientCurrent = (pfClient)ListClient.Current;
            txtFirstName.Text = ClientCurrent.FirstName;
            txtLastName.Text = ClientCurrent.LastName;
            txtDocument.Text = ClientCurrent.Document;
            txtEmail.Text = ClientCurrent.Email;
            txtPhoneNumber.Text = ClientCurrent.PhoneNumber;
            DateBirth.Value = ClientCurrent.DateBirth;

            tabControl1.SelectTab(tabPageAddEdit);

        }
        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (ListClient.Current is pfClient pfClient)
            {
                var results = MessageBox.Show($"¿Está seguro que desea eliminar el cliente {pfClient.FirstName}?", "Eliminar", MessageBoxButtons.YesNo);

                if (results == DialogResult.Yes)
                {
                    pfClient.IsDeleted = true;

                    await ClientService.UpdateAsync(pfClient);
                    await LoadGrid();
                    MessageBox.Show("Cliente ocultado correctamente");
                }
            }
        }
        #endregion

        #region BtnSaveCancel

        private async void btnSave_Click(object sender, EventArgs e)
        {

            var pfClient = new pfClient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Document = txtDocument.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                DateBirth = DateBirth.Value,
            };

            if (ClientCurrent != null)
            {
                ClientCurrent.FirstName = txtFirstName.Text;
                ClientCurrent.LastName = txtLastName.Text;
                ClientCurrent.Document = txtDocument.Text;
                ClientCurrent.Email = txtEmail.Text;
                ClientCurrent.PhoneNumber = txtPhoneNumber.Text;
                DateBirth.Value = DateTime.Now;

                await ClientService.UpdateAsync(pfClient);
                MessageBox.Show("Cliente modificado correctamente");

                ClientCurrent = null;
            }
            else
            {
                await ClientService.AddAsync(pfClient);
                MessageBox.Show("Cliente agregado correctamente");

            }

            await LoadGrid();
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDocument.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            DateBirth.Value = DateTime.Now;

            tabControl1.SelectTab(tabPageList);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada");
            tabControl1.SelectTab(tabPageList);
        }
        #endregion

        #region TxtFilterTextChanged
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterClient();
        }
        private void FilterClient()
        {
            var filteredClient = Filterlist.Where(c => c.FirstName.Contains(txtFilter.Text)).ToList();
            ListClient.DataSource = new BindingSource(filteredClient, null);
        }
        #endregion
    }
}

