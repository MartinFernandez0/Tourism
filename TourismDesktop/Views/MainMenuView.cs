
using TourismDesktop.Views;
using TourismDesktop.Views.ActivityView;
using TourismDesktop.Views.TravelView;

namespace TourismDesktop
{
    public partial class MainMenuView : Form
    {
        bool sidebarExpand;

        public MainMenuView()
        {
            InitializeComponent();
        }

        #region MenuSlider Main
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            // 

            if (sidebarExpand)
            {
                //if sidebar is expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        #endregion 

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir del sistema??", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClientMain_Click(object sender, EventArgs e)
        {
            ClientView clientView = new ClientView();
            clientView.ShowDialog();
        }

        private void btnDestinationMain_Click(object sender, EventArgs e)
        {
            DestinationView destinationView = new DestinationView();
            destinationView.ShowDialog();
        }

        private void btnItineraryMain_Click(object sender, EventArgs e)
        {
            ItineraryView itineraryView = new ItineraryView();
            itineraryView.ShowDialog();
        }

        private void btnActivityMain_Click(object sender, EventArgs e)
        {
            ActivityView activityView = new ActivityView();
            activityView.ShowDialog();
        }

        private void btnNewTravel_Click(object sender, EventArgs e)
        {
            TravelView travelView = new TravelView();
            travelView.ShowDialog();
        }

        private void btnTravelList_Click(object sender, EventArgs e)
        {

        }
    }
}
