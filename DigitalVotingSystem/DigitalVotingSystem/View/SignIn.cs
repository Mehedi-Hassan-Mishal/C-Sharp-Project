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
    public partial class SignIn : Form
    {
        string username, password;
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
             username = usernametextBox.Text;
             password = passwordtextBox.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("please enter username");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("please enter your password");
            }


            if (administrationradiobtn.Checked == true)
            {
                if (username.Equals("hk")&& password.Equals("12"))
                {
                    administrationHome.ADName = username;
                    administrationHome.ADID = "HK10125";
                    administrationHome.ADGender = "Male";
                    MessageBox.Show("loggid in successfully..");
                    this.Hide();
                    administrationHome AH = new administrationHome();
                    AH.Show();
                }
                else
                {
                    MessageBox.Show("error occurred.try again..");
                }

            }
            else if(voterradioBtn.Checked==true)
            {
                Voters obj = new Voters();
                obj.Authentication(username, password);

                if (obj.x == 1)
                {
                    
                    MessageBox.Show("loggid in successfully..");
                    this.Hide();
                    VoterHome VH = new VoterHome();
                     VH.Show();
                }
                else
                {
                    MessageBox.Show("error occurred.try again..");
                }
            }

        }
    }
}
