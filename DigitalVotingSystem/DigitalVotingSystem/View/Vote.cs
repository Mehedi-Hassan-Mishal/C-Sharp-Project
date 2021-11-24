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
    public partial class Vote : Form
    {
        Candidate cndt = new Candidate();
        Voters Object2 = new Voters();
        public Vote()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Vote_Load(object sender, EventArgs e)
        {
            cndt.ShowInVoteClass();
            dataGridView1.DataSource = cndt.dtcandidate;
            cndt.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string Name = row.Cells["Name"].Value.ToString();
            bannerradioButton1.Text = row.Cells["Banner"].Value.ToString();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Voters.VoatingStatus.Equals("1"))
            {
                MessageBox.Show("you can not voat twice");
            }
            else
            {
                if (bannerradioButton1.Checked == false)
                {
                    MessageBox.Show("Please Select the radio button");
                }
                else if (bannerradioButton1.Checked == true && bannerradioButton1.Text.Equals("banner"))
                {
                    MessageBox.Show("you did not Select your candidate");
                }

                else
                {
                    string VOTE = bannerradioButton1.Text;
                    
                    Object2.changeVotingStatus();
                    Candidate Object = new Candidate();
                    Object.bnr = VOTE;
                    Object.Authentication();
          
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VoterHome obj = new VoterHome();
            obj.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
