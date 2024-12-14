using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;
using System.Data;
using TourismServices.Enums;

namespace TourismDesktop.Views
{
    public partial class ClientView : Form
    {
        IClientService ClientService = new ClientService();

        IDestinationService DestinationService = new DestinationService();
        IItineraryService ItineraryService = new ItineraryService();
        IActivityService ActivityService = new ActivityService();

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
            LoadEnumValues();
            LoadCBoxs();


            //Properties Buttons isDeleted
            btnSeeEliminated.Text = "Eliminados";
            btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
            btnSeeEliminated.ForeColor = System.Drawing.Color.White;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region ComboBox y Enums Load
        private async Task LoadCBoxs()
        {
            // ComboBox Itinerarios Actividades y Destinos

            CBoxItinerary.DataSource = await ItineraryService.GetAllAsync();
            CBoxItinerary.DisplayMember = "Name";
            CBoxItinerary.ValueMember = "Id";
            CBoxItinerary.SelectedIndex = 0;

            CBoxDestination.DataSource = await DestinationService.GetAllAsync();
            CBoxDestination.DisplayMember = "Name";
            CBoxDestination.ValueMember = "Id";
            CBoxDestination.SelectedIndex = 0;

            CBoxActivity.DataSource = await ActivityService.GetAllAsync();
            CBoxActivity.DisplayMember = "ActivityName";
            CBoxActivity.ValueMember = "Id";
            CBoxActivity.SelectedIndex = 0;
        }

        private void LoadEnumValues()
        {
            CBoxGender.DataSource = Enum.GetValues(typeof(CustomerGenderEnum));
            CBoxAccommodationPreference.DataSource = Enum.GetValues(typeof(AccommodationPreferenceEnum));
            CBoxFoodPreference.DataSource = Enum.GetValues(typeof(FoodPreferenceEnum));
            CBoxReservationStatus.DataSource = Enum.GetValues(typeof(ReservationStatusEnum));
            CBoxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethodEnum));
            CBoxPaymentConfirmation.DataSource = Enum.GetValues(typeof(PaymentConfirmationEnum));
            CBoxPreferenceTransport.DataSource = Enum.GetValues(typeof(PreferenceTransportEnum));
        }
        #endregion

        #region LoadDate
        private async Task LoadGrid()
        {
            var clients = await ClientService.GetAllAsync();
            ListClient.DataSource = clients?.Where(i => !i.IsDeleted).ToList();
            Filterlist = (List<pfClient>)ListClient.DataSource;

            // Ocultar la primera columna (por índice)
            dataGridClientView.Columns[0].Visible = false;
            dataGridClientView.Columns[15].Visible = false;
            dataGridClientView.Columns[17].Visible = false;
            dataGridClientView.Columns[22].Visible = false;
            dataGridClientView.Columns[28].Visible = false;

            dataGridClientView.Columns[27].DefaultCellStyle.Format = "N2";
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
            //Information Basic
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDocument.Text = string.Empty;
            Birthdate.Value = DateTime.Now;
            CustomerGenderEnum customerGender;


            //Information Contact
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPostalCode.Text = string.Empty;

            //Information Tourist
            AccommodationPreferenceEnum accommodationPreference;
            FoodPreferenceEnum foodPreference;
            PreferenceTransportEnum preferenceTransportEnum;

            //Information Reservation
            NumberOfPeople.Value = 0;
            dateTimeReservation.Value = DateTime.Now;
            ReservationStatusEnum reservationStatus;

            //Information Payment
            PaymentMethodEnum paymentMethod;
            PaymentConfirmationEnum paymentConfirmation;
            dateTimeTransactionDate.Value = DateTime.Now;
            decimal totalAmount = 0;

            tabControl1.SelectTab(tabPageAddEdit);
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            ClientCurrent = (pfClient)ListClient.Current;

            txtFirstName.Text = ClientCurrent.FirstName;
            txtLastName.Text = ClientCurrent.LastName;
            txtDocument.Text = ClientCurrent.Document;
            Birthdate.Value = ClientCurrent.Birthdate;
            CBoxGender.SelectedItem = ClientCurrent.CustomerGender;

            txtEmail.Text = ClientCurrent.Email;
            txtPhoneNumber.Text = ClientCurrent.PhoneNumber;
            txtAddress.Text = ClientCurrent.Address;
            txtCity.Text = ClientCurrent.City;
            txtCountry.Text = ClientCurrent.Country;
            txtPostalCode.Text = ClientCurrent.PostalCode;

            CBoxAccommodationPreference.SelectedItem = ClientCurrent.AccommodationPreference;
            CBoxFoodPreference.SelectedItem = ClientCurrent.FoodPreference;
            CBoxPreferenceTransport.SelectedItem = ClientCurrent.PreferenceTransport;
            NumberOfPeople.Value = ClientCurrent.NumberOfPeople;
            dateTimeReservation.Value = ClientCurrent.ReservationDate;
            CBoxReservationStatus.SelectedItem = ClientCurrent.ReservationStatus;

            CBoxPaymentMethod.SelectedItem = ClientCurrent.PaymentMethod;
            CBoxPaymentConfirmation.SelectedItem = ClientCurrent.PaymentConfirmation;
            dateTimeTransactionDate.Value = ClientCurrent.TransactionDate;
            NumberTotalAmount.Value = ClientCurrent.TotalAmount;

            tabControl1.SelectTab(tabPageAddEdit);
        }
        private async void btnDelete_Click(object sender, EventArgs e)
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

        #region Save Cancel
        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles
            CustomerGenderEnum customerGender = (CustomerGenderEnum)CBoxGender.SelectedItem;
            AccommodationPreferenceEnum accommodationPreference = (AccommodationPreferenceEnum)CBoxAccommodationPreference.SelectedItem;
            FoodPreferenceEnum foodPreference = (FoodPreferenceEnum)CBoxFoodPreference.SelectedItem;
            ReservationStatusEnum reservationStatus = (ReservationStatusEnum)CBoxReservationStatus.SelectedItem;
            PaymentMethodEnum paymentMethod = (PaymentMethodEnum)CBoxPaymentMethod.SelectedItem;
            PaymentConfirmationEnum paymentConfirmation = (PaymentConfirmationEnum)CBoxPaymentConfirmation.SelectedItem;
            PreferenceTransportEnum preferenceTransport = (PreferenceTransportEnum)CBoxPreferenceTransport.SelectedItem;

            int numberOfPeople = (int)NumberOfPeople.Value;
            decimal totalAmount = (decimal)NumberTotalAmount.Value;

            int? destinationId = (int?)CBoxDestination.SelectedValue;
            int? activityId = (int?)CBoxActivity.SelectedValue;
            int? itineraryId = (int?)CBoxItinerary.SelectedValue;

            var pfClient = new pfClient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Document = txtDocument.Text,
                Birthdate = Birthdate.Value,
                CustomerGender = customerGender, // Asigna el valor del enum

                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                Country = txtCountry.Text,
                PostalCode = txtPostalCode.Text,

                AccommodationPreference = accommodationPreference, // Asigna el valor del enum
                FoodPreference = foodPreference, // Asigna el valor del enum
                PreferenceTransport = preferenceTransport, // Asigna el valor del enum
                NumberOfPeople = numberOfPeople, // Valor Numerico
                ReservationDate = dateTimeReservation.Value,

                ReservationStatus = reservationStatus, // Asigna el valor del enum
                PaymentMethod = paymentMethod, // Asigna el valor del enum
                PaymentConfirmation = paymentConfirmation, // Asigna el valor del enum
                TransactionDate = dateTimeTransactionDate.Value,
                TotalAmount = totalAmount, // Valor Numerico

                DestinationId = destinationId,
                ActivityId = activityId,
                ItineraryId = itineraryId
            };

            if (ClientCurrent != null)
            {
                ClientCurrent.FirstName = txtFirstName.Text;
                ClientCurrent.LastName = txtLastName.Text;
                ClientCurrent.Document = txtDocument.Text;
                ClientCurrent.Birthdate = Birthdate.Value;
                ClientCurrent.CustomerGender = customerGender;

                ClientCurrent.Email = txtEmail.Text;
                ClientCurrent.PhoneNumber = txtPhoneNumber.Text;
                ClientCurrent.Address = txtAddress.Text;
                ClientCurrent.City = txtCity.Text;
                ClientCurrent.Country = txtCountry.Text;
                ClientCurrent.PostalCode = txtPostalCode.Text;

                ClientCurrent.AccommodationPreference = accommodationPreference;
                ClientCurrent.FoodPreference = foodPreference;
                ClientCurrent.PreferenceTransport = preferenceTransport;
                ClientCurrent.NumberOfPeople = numberOfPeople;
                ClientCurrent.ReservationDate = dateTimeReservation.Value;

                ClientCurrent.ReservationStatus = reservationStatus;
                ClientCurrent.PaymentMethod = paymentMethod;
                ClientCurrent.PaymentConfirmation = paymentConfirmation;
                ClientCurrent.TransactionDate = dateTimeTransactionDate.Value;
                ClientCurrent.TotalAmount = totalAmount;

                ClientCurrent.DestinationId = destinationId;
                ClientCurrent.ActivityId = activityId;
                ClientCurrent.ItineraryId = itineraryId;

                await ClientService.UpdateAsync(ClientCurrent);
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
            Birthdate.Value = DateTime.Now;
            CBoxGender.SelectedIndex = -1;

            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPostalCode.Text = string.Empty;

            CBoxAccommodationPreference.SelectedIndex = -1;
            CBoxFoodPreference.SelectedIndex = -1;
            CBoxPreferenceTransport.SelectedIndex = -1;
            numberOfPeople = 0;
            dateTimeReservation.Value = DateTime.Now;

            CBoxReservationStatus.SelectedIndex = -1;
            CBoxPaymentMethod.SelectedIndex = -1;
            CBoxPaymentConfirmation.SelectedIndex = -1;
            dateTimeTransactionDate.Value = DateTime.Now;
            totalAmount = 0;

            CBoxDestination.SelectedIndex = -1;
            CBoxActivity.SelectedIndex = -1;
            CBoxItinerary.SelectedIndex = -1;

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