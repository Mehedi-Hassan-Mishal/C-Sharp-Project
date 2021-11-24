namespace DigitalVotingSystem.View
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.Backbutton2 = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.submitbutton = new System.Windows.Forms.Button();
            this.addresscomboBox1 = new System.Windows.Forms.ComboBox();
            this.femaleradioButton3 = new System.Windows.Forms.RadioButton();
            this.othersradioButton2 = new System.Windows.Forms.RadioButton();
            this.maleradioButton1 = new System.Windows.Forms.RadioButton();
            this.passwordtextBox3 = new System.Windows.Forms.TextBox();
            this.voteridtextBox2 = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.emailtextBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Backbutton2
            // 
            this.Backbutton2.BackColor = System.Drawing.SystemColors.Control;
            this.Backbutton2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton2.ForeColor = System.Drawing.Color.Black;
            this.Backbutton2.Location = new System.Drawing.Point(233, 526);
            this.Backbutton2.Name = "Backbutton2";
            this.Backbutton2.Size = new System.Drawing.Size(101, 43);
            this.Backbutton2.TabIndex = 48;
            this.Backbutton2.Text = "Back";
            this.Backbutton2.UseVisualStyleBackColor = false;
            this.Backbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Exitbutton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.Black;
            this.Exitbutton.Location = new System.Drawing.Point(353, 526);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(101, 43);
            this.Exitbutton.TabIndex = 47;
            this.Exitbutton.Text = "EXIT";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitbutton.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbutton.ForeColor = System.Drawing.Color.Black;
            this.submitbutton.Location = new System.Drawing.Point(233, 477);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(221, 43);
            this.submitbutton.TabIndex = 46;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.ADDbutton_Click);
            // 
            // addresscomboBox1
            // 
            this.addresscomboBox1.FormattingEnabled = true;
            this.addresscomboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addresscomboBox1.IntegralHeight = false;
            this.addresscomboBox1.Items.AddRange(new object[] {
            " Barishal, ",
            " Brahmanbaria",
            " Gaibandha, ",
            " Gazipur, ",
            " Gopalganj, ",
            " Habiganj,",
            " Jamalpur,",
            " Lalmonirhat,",
            " Mymensingh,",
            " Narayanganj,",
            " Netrokona",
            " Nilphamari,",
            " Rajbari, ",
            " Rangamati",
            " Satkhira",
            " Sunamganj",
            "Bagerhat",
            "Bandarban",
            "Barishal\t",
            "Bhola, Barguna",
            "Chandpur",
            "Chapainawabganj",
            "Chattogram",
            "Chuadanga",
            "Coxsbazar",
            "Cumilla",
            "Dhaka,",
            "Dinajpur,",
            "Faridpur",
            "Feni",
            "Jashore",
            "Jhalakathi",
            "Jhenaidah",
            "Joypurhat",
            "Khagrachhari",
            "Khuln",
            "Khulna",
            "Kishoreganj, ",
            "Kurigram",
            "Kushtia",
            "Lakshmipur",
            "Madaripur,",
            "Magura",
            "Manikganj, ",
            "Meherpur",
            "Moulvibazar",
            "Munshiganj,",
            "Naogaon",
            "Narail",
            "Narsingdi,",
            "Natore",
            "Noakhali",
            "Pabna, Bogura",
            "Panchagarh, ",
            "Patuakhali, ",
            "Pirojpur,",
            "Rajshahi",
            "Rajshahi\tSirajganj",
            "Rangpur, ",
            "Shariatpur,",
            "Sherpur,",
            "Sylhet\t",
            "Tangail, ",
            "Thakurgaon, "});
            this.addresscomboBox1.Location = new System.Drawing.Point(263, 423);
            this.addresscomboBox1.MaximumSize = new System.Drawing.Size(160, 0);
            this.addresscomboBox1.Name = "addresscomboBox1";
            this.addresscomboBox1.Size = new System.Drawing.Size(160, 24);
            this.addresscomboBox1.Sorted = true;
            this.addresscomboBox1.TabIndex = 45;
            this.addresscomboBox1.Text = "NULL";
            // 
            // femaleradioButton3
            // 
            this.femaleradioButton3.AutoSize = true;
            this.femaleradioButton3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradioButton3.Location = new System.Drawing.Point(335, 380);
            this.femaleradioButton3.Name = "femaleradioButton3";
            this.femaleradioButton3.Size = new System.Drawing.Size(66, 21);
            this.femaleradioButton3.TabIndex = 44;
            this.femaleradioButton3.TabStop = true;
            this.femaleradioButton3.Text = "Female";
            this.femaleradioButton3.UseVisualStyleBackColor = true;
            this.femaleradioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // othersradioButton2
            // 
            this.othersradioButton2.AutoSize = true;
            this.othersradioButton2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersradioButton2.Location = new System.Drawing.Point(424, 380);
            this.othersradioButton2.Name = "othersradioButton2";
            this.othersradioButton2.Size = new System.Drawing.Size(56, 21);
            this.othersradioButton2.TabIndex = 43;
            this.othersradioButton2.TabStop = true;
            this.othersradioButton2.Text = "Other";
            this.othersradioButton2.UseVisualStyleBackColor = true;
            this.othersradioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // maleradioButton1
            // 
            this.maleradioButton1.AutoSize = true;
            this.maleradioButton1.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradioButton1.Location = new System.Drawing.Point(263, 381);
            this.maleradioButton1.Name = "maleradioButton1";
            this.maleradioButton1.Size = new System.Drawing.Size(54, 21);
            this.maleradioButton1.TabIndex = 42;
            this.maleradioButton1.TabStop = true;
            this.maleradioButton1.Text = "Male";
            this.maleradioButton1.UseVisualStyleBackColor = true;
            this.maleradioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // passwordtextBox3
            // 
            this.passwordtextBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordtextBox3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox3.Location = new System.Drawing.Point(263, 345);
            this.passwordtextBox3.Name = "passwordtextBox3";
            this.passwordtextBox3.Size = new System.Drawing.Size(221, 27);
            this.passwordtextBox3.TabIndex = 41;
            this.passwordtextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // voteridtextBox2
            // 
            this.voteridtextBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.voteridtextBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteridtextBox2.Location = new System.Drawing.Point(263, 298);
            this.voteridtextBox2.Name = "voteridtextBox2";
            this.voteridtextBox2.Size = new System.Drawing.Size(221, 27);
            this.voteridtextBox2.TabIndex = 40;
            this.voteridtextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nametextBox
            // 
            this.nametextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nametextBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(263, 215);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(221, 27);
            this.nametextBox.TabIndex = 39;
            this.nametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(175, 423);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 22);
            this.label16.TabIndex = 38;
            this.label16.Text = "Address : \r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(182, 380);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 22);
            this.label15.TabIndex = 37;
            this.label15.Text = "Gender : \r\n";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(165, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 22);
            this.label14.TabIndex = 36;
            this.label14.Text = "Password : \r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(155, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 22);
            this.label13.TabIndex = 35;
            this.label13.Text = "Voter ID No : \r\n";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(155, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "SignUp Form : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(233, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 24);
            this.label11.TabIndex = 32;
            this.label11.Text = "DIGITAL VOATING SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(313, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 70);
            this.panel1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(195, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Name : \r\n";
            // 
            // emailtextBox4
            // 
            this.emailtextBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.emailtextBox4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox4.Location = new System.Drawing.Point(263, 255);
            this.emailtextBox4.Name = "emailtextBox4";
            this.emailtextBox4.Size = new System.Drawing.Size(221, 27);
            this.emailtextBox4.TabIndex = 50;
            this.emailtextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(195, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Email : \r\n";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 611);
            this.Controls.Add(this.emailtextBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbutton2);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.addresscomboBox1);
            this.Controls.Add(this.femaleradioButton3);
            this.Controls.Add(this.othersradioButton2);
            this.Controls.Add(this.maleradioButton1);
            this.Controls.Add(this.passwordtextBox3);
            this.Controls.Add(this.voteridtextBox2);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbutton2;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.ComboBox addresscomboBox1;
        private System.Windows.Forms.RadioButton femaleradioButton3;
        private System.Windows.Forms.RadioButton othersradioButton2;
        private System.Windows.Forms.RadioButton maleradioButton1;
        private System.Windows.Forms.TextBox passwordtextBox3;
        private System.Windows.Forms.TextBox voteridtextBox2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailtextBox4;
        private System.Windows.Forms.Label label1;
    }
}