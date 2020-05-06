using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_Separovic
{
    public partial class Form2 : Form
    {
        //global variable organization type used to recognize when user choose Physician as a org type
        string orgType;
        public Form2(string orgType)
        {
            InitializeComponent();
            this.orgType = orgType;
        }

        /**
         * This metod is opening another form with tabs on every cell click.
         * It also checks if user choose Physician as org type
         * */
        private void orgDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if(this.orgType != "Physician") { 
            int row = e.RowIndex;
            int orgId = Convert.ToInt32(orgDataGridView[0, row].Value);

                Form3 f3 = new Form3(orgId);
            f3.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
