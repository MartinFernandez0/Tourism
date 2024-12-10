using System.Data;
using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismDesktop.Views
{
    public partial class DestinationView : Form
    {
        IDestinationService DestinationService = new DestinationService();
        IItineraryService ItineraryService = new ItineraryService();

        BindingSource ListDestination = new BindingSource();
        List<pfDestination> FilterList = new List<pfDestination>();

        pfDestination? DestinationCurrent;

        //Manejo boton Eliminados IsDeleted Funcionando
        private bool showingDeleted = false;

        public DestinationView()
        {
            InitializeComponent();
            dataGridDestinationView.DataSource = ListDestination;
            LoadGrid();
            LoadComboBox();

            //Properties Buttons isDeleted
            btnSeeEliminated.Text = "Eliminados";
            btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
            btnSeeEliminated.ForeColor = System.Drawing.Color.White;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region LoadDate ComboBox
        private async Task LoadComboBox()
        {
            CBoxItinerary.DataSource = await ItineraryService.GetAllAsync();
            CBoxItinerary.DisplayMember = "Name";
            CBoxItinerary.ValueMember = "Id";
            CBoxItinerary.SelectedIndex = 0;
        }

        private async Task LoadGrid()
        {
            var destinations = await DestinationService.GetAllAsync();
            ListDestination.DataSource = destinations?.Where(i => !i.IsDeleted).ToList();
            FilterList = (List<pfDestination>)ListDestination.DataSource;
        }

        #endregion

        #region btnSeeDeleted
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {

            if (showingDeleted)
            {
                //Mostrar Destinos activos
                var ActiveDestinations = await DestinationService.GetAllAsync(null);
                ListDestination.DataSource = ActiveDestinations?.Where(i => !i.IsDeleted).ToList();

                //Properties
                btnSeeEliminated.Text = "Eliminados";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                //Mostraar Destinos eliminados
                var deletedDestinations = await DestinationService.GetAllDeletedAsync(null);
                ListDestination.DataSource = deletedDestinations?.Where(i => i.IsDeleted).ToList();

                //Properties
                btnSeeEliminated.Text = "Activos";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightSkyBlue;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            FilterList = (List<pfDestination>)ListDestination.DataSource;
            showingDeleted = !showingDeleted;
        }
        #endregion

        #region C.R.U.D
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtURL_image.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtCountry.Text = string.Empty;

            tabControl1.SelectTab(tabPageAddEdit);
        }
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            DestinationCurrent = (pfDestination)ListDestination.Current;
            txtFirstName.Text = DestinationCurrent.Name;
            txtDescription.Text = DestinationCurrent.Description;
            txtURL_image.Text = DestinationCurrent.URL_image;
            txtCategoryName.Text = DestinationCurrent.CategoryName;
            txtCountry.Text = DestinationCurrent.Country;

            CBoxItinerary.SelectedValue = DestinationCurrent.ItineraryId;


            //Image List addEditt
            // Carga la imagen en el PictureBox desde la URL de DestinationCurrent
            if (!string.IsNullOrEmpty(DestinationCurrent.URL_image))
            {
                try
                {
                    pictureBoxDestinationList.Load(DestinationCurrent.URL_image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
            else
            {
                pictureBoxDestinationList.Image = null; // Limpia el PictureBox si no hay URL
            }


            tabControl1.SelectTab(tabPageAddEdit);
        }
        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (ListDestination.Current is pfDestination pfDestination)
            {
                var results = MessageBox.Show($"¿Está seguro que desea eliminar el destino {pfDestination.Name}?", "Eliminar", MessageBoxButtons.YesNo);

                if (results == DialogResult.Yes)
                {
                    pfDestination.IsDeleted = true;

                    await DestinationService.UpdateAsync(pfDestination);
                    await LoadGrid();
                    MessageBox.Show("Destino eliminado correctamente");
                }
            }
        }
        #endregion

        #region BtnSaveCandel
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var pfDestination = new pfDestination
            {
                Name = txtFirstName.Text,
                Description = txtDescription.Text,
                URL_image = txtURL_image.Text,
                CategoryName = txtCategoryName.Text,
                Country = txtCountry.Text,

                ItineraryId = (int)CBoxItinerary.SelectedValue
            };

            if (DestinationCurrent != null)
            {

                DestinationCurrent.Name = txtFirstName.Text;
                DestinationCurrent.Description = txtDescription.Text;
                DestinationCurrent.URL_image = txtURL_image.Text;
                DestinationCurrent.CategoryName = txtCategoryName.Text;
                DestinationCurrent.Country = txtCountry.Text;

                DestinationCurrent.ItineraryId = (int)CBoxItinerary.SelectedValue;

                await DestinationService.UpdateAsync(DestinationCurrent);
                MessageBox.Show("Destino modificado correctamente");

                DestinationCurrent = null;
            }
            else
            {
                await DestinationService.AddAsync(pfDestination);
                MessageBox.Show("Destino agregado correctamente");
            }

            await LoadGrid();
            txtFirstName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtURL_image.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtCountry.Text = string.Empty;

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
            FilterDestination();
        }
        private void FilterDestination()
        {
            var filteredDestination = FilterList.Where(d => d.Name.Contains(txtFilter.Text)).ToList();
            ListDestination.DataSource = new BindingSource(filteredDestination, null);
        }
        #endregion
    }
}
