using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Project3_Separovic
{
    public partial class Form3 : Form
    {
        //id of the org type
        int id;
        public Form3(int id)
        {
            InitializeComponent();
            this.id = id;
            //getting tabs for specific ID
            getTabs(this.id);
            getGeneral(this.id);

        }
        //method that is getting tabs for specific ID
        private void getTabs(int id) {

            //creating request for getting tabs
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Resources.fixedURI + "/Application/Tabs?orgId="+id);
            request.Method = WebRequestMethods.Http.Get;


            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                XmlDocument doc = new XmlDocument();
                doc.Load(response.GetResponseStream());
                XmlNodeList tabs = doc.GetElementsByTagName("Tab");
                
                List<string> tabsToKeep = new List<string>();

                foreach (XmlNode town in tabs)
                {
                    // townComboBox.Items.Add(town.InnerText);
                    tabsToKeep.Add(town.InnerText);
                }

                foreach (TabPage tab in tabControl1.TabPages)
                {

                    if (!tabsToKeep.Contains(tab.Text))
                    {
                        tabControl1.TabPages.Remove(tab);
                    }
                }

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }

        }



        private void Locations_Click(object sender, EventArgs e)
        {

        }
        /*
         * In this method I am calling different ,ethods based on selected tab.
         *
         * */
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(tabControl1.SelectedTab.Text == "General")
            {
                getGeneral(this.id);
               
            }
            else if (tabControl1.SelectedTab.Text == "Locations")
            {
                getLocations(this.id);
            }
            else if (tabControl1.SelectedTab.Text == "Training")
            {
                getTraining(this.id);
            }
            else if (tabControl1.SelectedTab.Text == "Treatment")
            {
                getTreatments(this.id);
            }
            else if (tabControl1.SelectedTab.Text == "Facilities")
            {
                getFacilities(this.id);
            }
            else if (tabControl1.SelectedTab.Text == "People")
            {
                getPeople(this.id);
            }
            else if (tabControl1.SelectedTab.Text == "Physicians")
            {
                getPhysicians(this.id);
            }
            else if (tabControl1.SelectedTab.Text == "Equipment")
            {
                getEquipment(this.id);
            }

        }
        /**
         * Method that is getting general data about specific organization
         */
        private void getGeneral(int id) {

            //creating request for getting general info
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Resources.fixedURI + "/"+id+"/General");
            request.Method = WebRequestMethods.Http.Get;
            generalPanel.Visible = true;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                DataSet dataSet = new DataSet();
                XmlDocument doc = new XmlDocument();
                

                dataSet.ReadXml(response.GetResponseStream());
                dataGridViewGeneral.DataSource = dataSet.Tables["data"];
                
            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting location data about specific organization
        */
        private void getLocations(int id) {
           
            locationsPanel.Visible = true;

            try
            {
                string locationURI = Properties.Resources.fixedURI + "/" + id + "/Locations";
                DataSet ds = new DataSet();
                ds.ReadXml(locationURI);
                dataGridViewLocation.DataSource = ds.Tables["location"];
                
            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting training data about specific organization
        */

        private void getTraining(int id)
        {

            panelTraining.Visible = true;

            try
            {
                string trainingURI = Properties.Resources.fixedURI + "/" + id + "/Training";
                DataSet ds = new DataSet();
                ds.ReadXml(trainingURI);
                dataGridViewTraining.DataSource = ds.Tables["training"];

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting treatment data about specific organization
        */

        private void getTreatments(int id)
        {

            panelTreatment.Visible = true;

            try
            {
                string treatmentsURI = Properties.Resources.fixedURI + "/" + id + "/Treatments";
                DataSet ds = new DataSet();
                ds.ReadXml(treatmentsURI);
                dataGridViewTreatment.DataSource = ds.Tables["treatment"];

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting facilities data about specific organization
        */

        private void getFacilities(int id)
        {

            panelFacilities.Visible = true;

            try
            {
                string facilitiesURI = Properties.Resources.fixedURI + "/" + id + "/Facilities";
                DataSet ds = new DataSet();
                ds.ReadXml(facilitiesURI);
                dataGridViewFacilities.DataSource = ds.Tables["facility"];

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting physicians data about specific organization
        */

        private void getPhysicians(int id)
        {

            panelPhysicians.Visible = true;

            try
            {
                string physiciansURI = Properties.Resources.fixedURI + "/" + id + "/Physicians";
                DataSet ds = new DataSet();
                ds.ReadXml(physiciansURI);
                dataGridViewPhysician.DataSource = ds.Tables["physician"];

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting people data about specific organization
        */
        private void getPeople(int id)
        {

            panelPeople.Visible = true;

            try
            {
                string peopleURI = Properties.Resources.fixedURI + "/" + id + "/People";
                DataSet ds = new DataSet();
                ds.ReadXml(peopleURI);
                dataGridViewPeople.DataSource = ds.Tables["person"];

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        /**
        * Method that is getting equipment data about specific organization
        */
        private void getEquipment(int id)
        {

            panelEquipment.Visible = true;

            try
            {
                string equipmentURI = Properties.Resources.fixedURI + "/" + id + "/Equipment";
                DataSet ds = new DataSet();
                ds.ReadXml(equipmentURI);
                
                if (ds.Tables.Count <= 1 )
                {
                    panelEquipment.Visible = false;
                    MessageBox.Show("No data found for Equipment");
                    
                }
                else {
                    dataGridViewEquipment.DataSource = ds.Tables["equipment"];
                }
                

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void generalPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void locationsPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dataGridViewLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Training_Click(object sender, EventArgs e)
        {

        }

        private void trainingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label123_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        /**
         * This method is opening another form with google map after user click some cell location
         * */
        private void dataGridViewLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //creating map object and passing longitude and latitude via constructor
            int row = e.RowIndex;
            string  latitude = dataGridViewLocation[9, row].Value.ToString();
            string longitude = dataGridViewLocation[10, row].Value.ToString();
            Form4 f4 = new Form4(latitude, longitude);
            f4.Show();

        }

        private void dataGridViewLocation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
