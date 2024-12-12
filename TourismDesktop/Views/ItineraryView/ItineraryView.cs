using System.Data;
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

        //Manejo boton Eliminados IsDeleted Funcionando
        private bool showingDeleted = false;

        public ItineraryView()
        {
            InitializeComponent();
            dataGridItineraryView.DataSource = ListItinerary;
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

        #region LoadDate

        private async Task LoadComboBox()
        {
            CBoxActivity.DataSource = await ActivityService.GetAllAsync();
            CBoxActivity.DisplayMember = "ActivityName";
            CBoxActivity.ValueMember = "Id";
            CBoxActivity.SelectedIndex = 0;
        }
        private async Task LoadGrid()
        {
            var itineraries = await ItineraryService.GetAllAsync();
            ListItinerary.DataSource = itineraries?.Where(i => !i.IsDeleted).ToList(); // Filtra los itinerarios no eliminados
            FilterList = (List<pfItinerary>)ListItinerary.DataSource;
        }
        #endregion

        #region BtnSeeDelete
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (showingDeleted)
            {
                // Mostrar itinerarios activos
                var activeItineraries = await ItineraryService.GetAllAsync(null);
                ListItinerary.DataSource = activeItineraries?.Where(i => !i.IsDeleted).ToList();

                //Properties
                btnSeeEliminated.Text = "Eliminados";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                // Mostrar itinerarios eliminados
                var deletedItineraries = await ItineraryService.GetAllDeletedAsync(null);
                ListItinerary.DataSource = deletedItineraries?.Where(i => i.IsDeleted).ToList();

                //Properties
                btnSeeEliminated.Text = "Activos";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightSkyBlue;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }

            FilterList = (List<pfItinerary>)ListItinerary.DataSource;
            showingDeleted = !showingDeleted;

        }

        #endregion

        #region C.R.U.D

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
            txtName.Text = ItineraryCurrent.Name;
            txtDescription.Text = ItineraryCurrent.Description;
            DepartureDate.Value = ItineraryCurrent.DepartureDate;
            ReturnDate.Value = ItineraryCurrent.ReturnDate;

            //CBoxActivity.SelectedValue = ItineraryCurrent.ActivityId;

            tabControl1.SelectTab(tabPageAddEdit);
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListItinerary.Current is pfItinerary pfItinerary)
            {
                var results = MessageBox.Show($"¿Está seguro que desea eliminar el itinerario {pfItinerary.Name}?", "Eliminar", MessageBoxButtons.YesNo);

                if (results == DialogResult.Yes)
                {
                    pfItinerary.IsDeleted = true;

                    await ItineraryService.UpdateAsync(pfItinerary);
                    await LoadGrid();
                    MessageBox.Show("Itinerario ocultado correctamente");
                }
            }
        }

        #endregion

        #region BtnSaveCancel
        private async void btnSave_Click(object sender, EventArgs e)
        {
            var pfItinerary = new pfItinerary
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                DepartureDate = DepartureDate.Value,
                ReturnDate = ReturnDate.Value,

                //ActivityId = (int)CBoxActivity.SelectedValue

            };

            if (ItineraryCurrent != null)
            {

                ItineraryCurrent.Name = txtName.Text;
                ItineraryCurrent.Description = txtDescription.Text;
                ItineraryCurrent.DepartureDate = DepartureDate.Value;
                ItineraryCurrent.ReturnDate = ReturnDate.Value;

                //ItineraryCurrent.ActivityId = (int)CBoxActivity.SelectedValue;

                await ItineraryService.UpdateAsync(ItineraryCurrent);
                MessageBox.Show("Itinerario modificado correctamente");

                ItineraryCurrent = null;
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
            FilterItinerary();
        }

        private void FilterItinerary()
        {
            var filteredItinerary = FilterList.Where(i => i.Name.Contains(txtFilter.Text)).ToList();
            ListItinerary.DataSource = new BindingSource(filteredItinerary, null);
        }
        #endregion
    }
}