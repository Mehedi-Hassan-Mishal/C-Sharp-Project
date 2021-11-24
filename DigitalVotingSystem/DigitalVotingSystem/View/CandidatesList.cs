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
    public partial class CandidatesList : Form
    {
        Candidate cndt = new Candidate();
        public CandidatesList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void CandidatesList_Load(object sender, EventArgs e)
        {
            cndt.Show();
            dataGridView2.DataSource = cndt.dtcandidate;
            cndt.Close();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            cndt.performOperation();
            MessageBox.Show("count : "+cndt.chng);
        }

    }
}
