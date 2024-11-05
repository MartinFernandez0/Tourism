using NuGet.Packaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TourismServices.Interfaces;
using TourismServices.Models;
using TourismServices.Services;

namespace TourismDesktop.Views
{
    public partial class ItineraryView : Form
    {
        IItineraryService ItineraryService = new ItineraryService();
        IActivityService ActivityService = new ActivityService();

        BindingSource ListItinerary = new BindingSource();
        List<pfItinerary> FilterList = new List<pfItinerary>();

        pfItinerary? ItineraryCurrent;

        public ItineraryView()
        {
            InitializeComponent();
            dataGridItineraryView.DataSource = ListItinerary;
            LoadGrid();
            LoadComboBox();
        }

        private async Task LoadComboBox()
        {
            CBoxActivity.DataSource = await ActivityService.GetAllAsync();
            CBoxActivity.DisplayMember = "ActivityName";
            CBoxActivity.ValueMember = "Id";
            CBoxActivity.SelectedIndex = 1;
        }

        private async Task LoadGrid()
        {
            ListItinerary.DataSource = await ItineraryService.GetAllAsync();
            FilterList = (List<pfItinerary>)ListItinerary.DataSource;
        }
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageDelete);
            LoadDeleteItems();
        }

        private async Task LoadDeleteItems()
        {
            var deletedItems = await ItineraryService.GetAllDeletedAsync();
            dataGridItineraryDelete.DataSource = deletedItems;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            DepartureDate.Value = DateTime.Now;
            ReturnDate.Value = DateTime.Now;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ItineraryCurrent = (pfItinerary)ListItinerary.Current;

            if (ItineraryCurrent == null)
            {
                MessageBox.Show("Debe seleccionar un itinerario");
                return;
            }
            txtName.Text = ItineraryCurrent.Name;
            txtDescription.Text = ItineraryCurrent.Description;
            DepartureDate.Value = ItineraryCurrent.DepartureDate;
            ReturnDate.Value = ItineraryCurrent.ReturnDate;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListItinerary.Current is pfItinerary pfItinerary)
            {
                var results = MessageBox.Show("¿Está seguro que desea ocultar el itinerario?", "Ocultar", MessageBoxButtons.YesNo);

                if (results == DialogResult.Yes)
                {
                    // Marca el itinerario como eliminado
                    pfItinerary.IsDeleted = true; // Asegúrate de que esta propiedad esté presente en tu modelo

                    await ItineraryService.UpdateAsync(pfItinerary); // Actualiza el itinerario en lugar de eliminarlo
                    await LoadGrid();
                    MessageBox.Show("Itinerario ocultado correctamente");
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var selectedActivity = (pfActivity)CBoxActivity.SelectedItem;
            var activities = new HashSet<pfActivity> { selectedActivity };

            var pfItinerary = new pfItinerary
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                DepartureDate = DepartureDate.Value,
                ReturnDate = ReturnDate.Value,

            };

            if (ItineraryCurrent != null)
            {
                pfItinerary.Id = ItineraryCurrent.Id;

                ItineraryCurrent.Name = txtName.Text;
                ItineraryCurrent.Description = txtDescription.Text;
                ItineraryCurrent.DepartureDate = DepartureDate.Value;
                ItineraryCurrent.ReturnDate = ReturnDate.Value;


                await ItineraryService.UpdateAsync(pfItinerary);
                MessageBox.Show("Itinerario modificado correctamente");
            }
            else
            {
                await ItineraryService.AddAsync(pfItinerary);
                MessageBox.Show("Itinerario agregado correctamente");
            }

            await LoadGrid();
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            DepartureDate.Value = DateTime.Now;
            ReturnDate.Value = DateTime.Now;
            CBoxActivity.SelectedIndex = -1;

            tabControl1.SelectTab(tabPageList);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada");
            tabControl1.SelectTab(tabPageList);
        }

    }
}
