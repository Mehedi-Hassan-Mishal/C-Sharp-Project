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
    public partial class administrationHome : Form
    {
        string username, email, password, address, gender, voterid;
        public static string ADName, ADID, ADGender;

        public administrationHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void administrationHome_Load(object sender, EventArgs e)
        {
            ADnameTB.Text = ADName;
            ADgenderTB.Text = ADGender;
            ADidTB.Text = ADID;
            
        }

        private void voterliatBox_Click(object sender, EventArgs e)
        {
            
            ListView ob = new ListView();
           
            ListView.value = 1;
            ob.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ListView ob = new ListView();
            ListView.value = 2;
            ob.Show();
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CandidatesList obj = new CandidatesList();
            obj.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
            else if (femaleradioButton3.Checked == true)
            {
                gender = "Female";
            }
            else if (othersradioButton2.Checked == true)
            {
                gender = "others";
            }


            if (username.Equals(""))
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
                obj.INSERT(username, email, voterid, password, gender, address);

                if (obj.row == 1)
                {

                    MessageBox.Show("Registration Successfull.");
                    
                    nametextBox.Text="";
                    emailtextBox4.Text="";
                    addresscomboBox1.Text="";
                    voteridtextBox2.Text="";
                    passwordtextBox3.Text="";
                    maleradioButton1.Checked = false;
                    femaleradioButton3.Checked = false;
                    othersradioButton2.Checked = false;
                }


            }
        }
    }
}
