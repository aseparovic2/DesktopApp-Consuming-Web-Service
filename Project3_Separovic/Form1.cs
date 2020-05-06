using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.Diagnostics;

namespace Project3_Separovic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            getOrgTypes();
            getAllStates();
            
           
        

        }
        private void getOrgTypes() {
            //creating request for getting organitzation types
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Resources.fixedURI + "/OrgTypes");
            request.Method = WebRequestMethods.Http.Get;


            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                XmlDocument doc = new XmlDocument();
                doc.Load(response.GetResponseStream());
                XmlNodeList types = doc.GetElementsByTagName("type");
                orgTypeComboBox.Items.Clear();

                foreach (XmlNode type in types)
                {
                    orgTypeComboBox.Items.Add(type.InnerText);
                }

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }
        }

        private void getAllStates() {

            //creating request for getting organitzation types
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Resources.fixedURI + "/States");
            request.Method = WebRequestMethods.Http.Get;


            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                XmlDocument doc = new XmlDocument();
                doc.Load(response.GetResponseStream());
                XmlNodeList states = doc.GetElementsByTagName("State");
                stateComboBox.Items.Clear();

                foreach (XmlNode state in states)
                {
                    stateComboBox.Items.Add(state.InnerText);
                }

            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }


        }

        private void getCities(string state)
        {
           //creating request for getting organitzation types
           HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Properties.Resources.fixedURI + "/Cities?state="+state );
           request.Method = WebRequestMethods.Http.Get;


            try
            {

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                XmlDocument doc = new XmlDocument();
                doc.Load(response.GetResponseStream());
                XmlNodeList cities = doc.GetElementsByTagName("city");
                townComboBox.Items.Clear();

                foreach (XmlNode city in cities)
                {
                    townComboBox.Items.Add(city.InnerText);
                }
               
            }
            catch (Exception exception)
            {
                Debug.Write("Something went wrong");
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        /**
         * This method trigers after user press search button and it is loading a data from provided searchURI
         */

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            if (!orgTypeComboBox.Text.Equals("") || !stateComboBox.Text.Equals(""))
            {
                //URI to data
                string searchURI = Properties.Resources.fixedURI + "/Organizations?type=" + orgTypeComboBox.Text + "&name=" + nameTextBox.Text + "&state=" + stateComboBox.Text + "&city=" + townComboBox.Text + "&CountyName=" + countyTextBox.Text;
                //reading XML
                dataSet.ReadXml(searchURI);
                //checking if there is any data returned
                if (dataSet.Tables.Count == 0)
                {
                    MessageBox.Show("Unfortunately there is no data for organization of: " + "Type: " + orgTypeComboBox.Text + " ,Name: " + nameTextBox.Text + " ,State: " + stateComboBox.Text + " ,City: " + townComboBox.Text + ",and CountyName: " + countyTextBox.Text);
                }
                else
                {
                    //creating another form that will display results of a search
                    Form2 f2 = new Form2(orgTypeComboBox.Text);
                    f2.Show();
                    f2.orgDataGridView.DataSource = dataSet.Tables["row"];
                }


            }
            else
            {
                MessageBox.Show("Please pick some data in order to search for organizations");
            }

        }
        /*
         * This method is calling getCities methid and it will call it based on selected value from state combo box
         * */
        private void stateComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Calling getCities method based pn selected item from state combo box
            getCities(stateComboBox.SelectedItem.ToString());

        }
    }
}
