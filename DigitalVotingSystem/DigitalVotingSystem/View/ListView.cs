using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalVotingSystem.Model;

namespace DigitalVotingSystem.View
{
    public partial class ListView : Form
    {
        DBAccess objDbAccess = new DBAccess();
        DataTable dtvoters = new DataTable();
        Voters obj = new Voters();
        public static int value = 1; 
        public ListView()
        {
            InitializeComponent();
        }

        private void ListView_Load(object sender, EventArgs e)
        {
           
            if (value == 1)
            {
                PerformOperation.Hide();
                dataGridView1.ReadOnly =true;
            }
            else
                PerformOperation.Show();
            dataGridView1.ReadOnly = false;
            obj.list();
           dataGridView1.DataSource = obj.dtvoters;
            obj.close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
          this.Hide();

            
        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            obj.Perform_Operation();
            MessageBox.Show("Count: " + obj.change);

        }
    }
}
