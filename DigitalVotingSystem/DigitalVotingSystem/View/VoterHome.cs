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
    public partial class VoterHome : Form
    {
        public VoterHome()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void VoterHome_Load(object sender, EventArgs e)
        {
            NametextBox1.Text = Voters.name;
            VIDtextBox2.Text = Voters.vid;
            GentextBox4.Text = Voters.gender;
            AddresstextBox.Text= Voters.address;
            welcome.Text = welcome.Text +" "+Voters.name;
            PASStextBox3.Text = Voters.paaword;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vote obj = new Vote();
            obj.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn obj = new SignIn();
            obj.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
