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
    public partial class RegistrationForm : Form
    {
        string username, email, password, address, gender, voterid;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn frm = new SignIn();
            frm.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Dispose();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            username = nametextBox.Text;
            email = emailtextBox4.Text;
            voterid = voteridtextBox2.Text;
            password = passwordtextBox3.Text;
            address = addresscomboBox1.Text;
            if (maleradioButton1.Checked == true)
            {
                gender = "Male";
            }
            else if ( femaleradioButton3.Checked== true)
            {
                gender = "Female";
            }
            else if( othersradioButton2.Checked== true)
            {
                gender = "others";
            }
            
            
            if(username.Equals(""))
            {
                MessageBox.Show("please enter username");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("please enter username");
            }
            else if (voterid.Equals(""))
            {
                MessageBox.Show("please enter username");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("please enter username");
            }
            else if (address.Equals(""))
            {
                MessageBox.Show("please enter username");
            }
            else if (maleradioButton1.Checked == false && femaleradioButton3.Checked == false && othersradioButton2.Checked == false)
            {
                MessageBox.Show("please select your gender");
            }
            else
            {

            
                Voters obj = new Voters();
                obj.INSERT(username, email, voterid, password, gender, address) ;

                if (obj.row == 1)
                {

                    MessageBox.Show("Registration Successfull.");
                    SignIn frm = new SignIn();
                    this.Hide();
                    frm.Show();
                }


            }
        }
    }
}
