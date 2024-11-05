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

        public DestinationView()
        {
            InitializeComponent();
            dataGridDestinationView.DataSource = ListDestination;
            LoadGrid();
            LoadComboBox();
        }

        private async Task LoadComboBox()
        {
            CBoxItinerary.DataSource = await ItineraryService.GetAllAsync();
            CBoxItinerary.DisplayMember = "Name";
            CBoxItinerary.ValueMember = "Id";
            CBoxItinerary.SelectedIndex = 0;
        }

        private async Task LoadGrid()
        {
            ListDestination.DataSource = await DestinationService.GetAllAsync();
            FilterList = (List<pfDestination>)ListDestination.DataSource;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtURL_image.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtCountry.Text = string.Empty;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private void btnModify_Click(object sender, EventArgs e)
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            var pfDesination = new pfDestination
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

                await DestinationService.UpdateAsync(pfDesination);
                MessageBox.Show("Destino modificado correctamente");

                DestinationCurrent = null;
            }
            else
            {
                await DestinationService.AddAsync(pfDesination);
            }
            MessageBox.Show("Destino agregado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await LoadGrid();
            txtFirstName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtURL_image.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
            txtCountry.Text = string.Empty;

            tabControl1.SelectTab(tabPageList);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada");
            tabControl1.SelectTab(tabPageList);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListDestination.Current is pfDestination pfDestination)
            {
                var results = MessageBox.Show("¿Está seguro que desea eliminar el destino?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (results == DialogResult.Yes)
                {
                    await DestinationService.DeleteAsync(pfDestination.Id);
                    await LoadGrid();
                    MessageBox.Show("Destino eliminado correctamente");
                }
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            FilterDestination();
        }

        private void FilterDestination()
        {
            var filteredDestination = FilterList.Where(d => d.Name.Contains(txtFilter.Text)).ToList();
            ListDestination.DataSource = new BindingSource(filteredDestination, null);
        }
    }
}
