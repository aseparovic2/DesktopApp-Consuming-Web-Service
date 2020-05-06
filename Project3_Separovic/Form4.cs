using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Windows.Forms;

namespace Project3_Separovic
{
    public partial class Form4 : Form
    {
        //global data used to create map components
        string latitude;
        string longitude;

        public Form4(string latitude, string longitude)
        {
            InitializeComponent();
            this.latitude = latitude;
            this.longitude = longitude;


        }
        /*
         *After from is loading  map will be presented using GMap 
         */
        private void Form4_Load(object sender, EventArgs e)
        {
            GMapControl.MapProvider = GMapProviders.GoogleMap;

            if (this.latitude != "" && this.longitude != "" && this.latitude != "null" && this.longitude != "null")
            {
                double latitude = Convert.ToDouble(this.latitude);
                double longitude = Convert.ToDouble(this.longitude);
                GMapControl.Position = new PointLatLng(latitude, longitude);
            }else
            {
                MessageBox.Show("There is no enough location data to display a map");
            }
        }
    }
}
