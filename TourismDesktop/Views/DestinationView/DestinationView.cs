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

namespace TourismDesktop.Views
{
    public partial class DestinationView : Form
    {
        IDestinationService DestinationService = new DestinationService();

        BindingSource ListDestination = new BindingSource();

        pfDestination? DestinationCurrent;

        public DestinationView()
        {
            InitializeComponent();
            dataGridDestinationView.DataSource = ListDestination;
            LoadGrid();
        }
        private async Task LoadGrid()
        {
            var destination = await DestinationService.GetAllAsync(null);
            ListDestination.DataSource = destination;
            dataGridDestinationView.AutoGenerateColumns = true;
        }
    }
}
