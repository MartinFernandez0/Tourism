﻿using System;
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

namespace TourismDesktop.Views.ActivityView
{
    public partial class ActivityView : Form
    {
        IActivityService ActivityService = new ActivityService();
        IDestinationService DestinationService = new DestinationService();

        BindingSource ListActivity = new BindingSource();
        List<pfActivity> FilterList = new List<pfActivity>();

        pfActivity? ActivityCurrent;

        //Manejo boton Eliminados IsDeleted Funcionando
        private bool showingDeleted = false;
        public ActivityView()
        {
            InitializeComponent();
            dataGridActivityView.DataSource = ListActivity;
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
            CBoxDestination.DataSource = await DestinationService.GetAllAsync();
            CBoxDestination.DisplayMember = "Name";
            CBoxDestination.ValueMember = "Id";
            CBoxDestination.SelectedIndex = 0;
        }

        private async void LoadGrid()
        {
            var activities = await ActivityService.GetAllAsync();
            ListActivity.DataSource = activities?.Where(i => !i.IsDeleted).ToList();
            FilterList = (List<pfActivity>)ListActivity.DataSource;

            // Ocultar columnas por índice
            if (dataGridActivityView.Columns.Count > 0)
            {
                //Ocultar la primera columna(por índice)
                dataGridActivityView.Columns[0].Visible = false;
                dataGridActivityView.Columns[6].Visible = false;
                dataGridActivityView.Columns[8].Visible = false;

                dataGridActivityView.Columns[4].DefaultCellStyle.Format = "N2";
            }
        }

        #endregion

        #region btnSeeDeleted
        private async void btnSeeEliminated_Click(object sender, EventArgs e)
        {
            if (showingDeleted)
            {
                // Mostrar Actividades activas
                var activeActivities = await ActivityService.GetAllAsync(null);
                ListActivity.DataSource = activeActivities?.Where(i => !i.IsDeleted).ToList();

                // Properties
                btnSeeEliminated.Text = "Eliminados";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightCoral;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                // Mostrar Actividades eliminadas
                var deletedActivities = await ActivityService.GetAllDeletedAsync(null);
                ListActivity.DataSource = deletedActivities?.Where(i => i.IsDeleted).ToList();

                // Properties
                btnSeeEliminated.Text = "Activos";
                btnSeeEliminated.BackColor = System.Drawing.Color.LightSkyBlue;
                btnSeeEliminated.ForeColor = System.Drawing.Color.White;
            }
            FilterList = (List<pfActivity>)ListActivity.DataSource;
            showingDeleted = !showingDeleted;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtActivityName.Text = string.Empty;
            txtURL_image.Text = string.Empty;
            txtDescription.Text = string.Empty;
            NumDuration.Value = 0;
            NumCost.Value = 0;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ActivityCurrent = (pfActivity)ListActivity.Current;

            txtActivityName.Text = ActivityCurrent.ActivityName;
            txtDescription.Text = ActivityCurrent.Description;
            txtURL_image.Text = ActivityCurrent.URLimage;
            NumDuration.Value = ActivityCurrent.Duration;
            NumCost.Value = ActivityCurrent.Cost;

            tabControl1.SelectTab(tabPageAddEdit);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListActivity.Current is pfActivity pfActivity)
            {
                var results = MessageBox.Show($"¿Está seguro que desea eliminar la actividad {pfActivity.ActivityName}?", "Eliminar", MessageBoxButtons.YesNo);

                if (results == DialogResult.Yes)
                {
                    pfActivity.IsDeleted = true;

                    await ActivityService.UpdateAsync(pfActivity);
                    LoadGrid();
                    MessageBox.Show("Actividad eliminada correctamente");
                }
            }
        }
        #endregion

        #region Save/Cancel
        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            int? destinationId = (int?)CBoxDestination.SelectedValue;

            var pfActivity = new pfActivity
            {
                ActivityName = txtActivityName.Text,
                Description = txtDescription.Text,
                URLimage = txtURL_image.Text,
                Duration = (int)TimeDuration.Value,
                Cost = NumCost.Value,
                DestinationId = destinationId

            };

            if (ActivityCurrent != null)
            {
                ActivityCurrent.ActivityName = txtActivityName.Text;
                ActivityCurrent.Description = txtDescription.Text;
                ActivityCurrent.URLimage = txtURL_image.Text;
                ActivityCurrent.Duration = (int)TimeDuration.Value;
                ActivityCurrent.Cost = NumCost.Value;

                ActivityCurrent.DestinationId = destinationId;

                await ActivityService.UpdateAsync(ActivityCurrent);
                MessageBox.Show("Actividad modificada correctamente");

                ActivityCurrent = null;
            }
            else
            {
                await ActivityService.AddAsync(pfActivity);
                MessageBox.Show("Actividad agregada correctamente");
            }

            LoadGrid();

            txtActivityName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtURL_image.Text = string.Empty;
            TimeDuration.Value = 0;
            NumCost.Value = 0;

            CBoxDestination.SelectedIndex = -1;

            tabControl1.SelectTab(tabPageList);

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Operación cancelada");
            tabControl1.SelectTab(tabPageList);
        }
        #endregion

        #region TxtFilterTextChanged
        private void txtFilter_TextChanged_1(object sender, EventArgs e)
        {
            FilterActivity();
        }
        private void FilterActivity()
        {
            var filteredActivity = FilterList.Where(d => d.ActivityName.Contains(txtFilter.Text)).ToList();
            ListActivity.DataSource = new BindingSource(filteredActivity, null);
        }

        #endregion

    }
}

