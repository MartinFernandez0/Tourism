using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ActivityView()
        {
            InitializeComponent();
            dataGridActivityView.DataSource = ListActivity;
            LoadGrid();
        }

        private async void LoadGrid()
        {
            ListActivity.DataSource = await ActivityService.GetAllAsync();
            FilterList = (List<pfActivity>)ListActivity.DataSource;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
