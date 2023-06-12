namespace health_care
{
    partial class create_doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_doctor));
            this.nameD_label = new System.Windows.Forms.Label();
            this.genderD_label2 = new System.Windows.Forms.Label();
            this.adressd_label = new System.Windows.Forms.Label();
            this.Named_textBox1 = new System.Windows.Forms.TextBox();
            this.genderd_comboBox1 = new System.Windows.Forms.ComboBox();
            this.adressD_textbox = new System.Windows.Forms.TextBox();
            this.emailD_label = new System.Windows.Forms.Label();
            this.emaild_textBox1 = new System.Windows.Forms.TextBox();
            this.master_label = new System.Windows.Forms.Label();
            this.noP_label = new System.Windows.Forms.Label();
            this.nod_label = new System.Windows.Forms.Label();
            this.master_textbox = new System.Windows.Forms.TextBox();
            this.regulerd = new System.Windows.Forms.TextBox();
            this.Emergencyd = new System.Windows.Forms.TextBox();
            this.timeD_label = new System.Windows.Forms.Label();
            this.morningd = new System.Windows.Forms.RadioButton();
            this.Eveningd = new System.Windows.Forms.RadioButton();
            this.afternoond = new System.Windows.Forms.RadioButton();
            this.sumbitd = new System.Windows.Forms.Button();
            this.passwordD_label = new System.Windows.Forms.Label();
            this.passwordD_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameD_label
            // 
            this.nameD_label.AutoSize = true;
            this.nameD_label.BackColor = System.Drawing.Color.Transparent;
            this.nameD_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameD_label.Location = new System.Drawing.Point(7, 37);
            this.nameD_label.Name = "nameD_label";
            this.nameD_label.Size = new System.Drawing.Size(114, 34);
            this.nameD_label.TabIndex = 0;
            this.nameD_label.Text = "User Name:";
            // 
            // genderD_label2
            // 
            this.genderD_label2.AutoSize = true;
            this.genderD_label2.BackColor = System.Drawing.Color.Transparent;
            this.genderD_label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderD_label2.Location = new System.Drawing.Point(7, 175);
            this.genderD_label2.Name = "genderD_label2";
            this.genderD_label2.Size = new System.Drawing.Size(81, 34);
            this.genderD_label2.TabIndex = 1;
            this.genderD_label2.Text = "Gender:";
            // 
            // adressd_label
            // 
            this.adressd_label.AutoSize = true;
            this.adressd_label.BackColor = System.Drawing.Color.Transparent;
            this.adressd_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressd_label.Location = new System.Drawing.Point(8, 256);
            this.adressd_label.Name = "adressd_label";
            this.adressd_label.Size = new System.Drawing.Size(80, 34);
            this.adressd_label.TabIndex = 4;
            this.adressd_label.Text = "Adress:";
            // 
            // Named_textBox1
            // 
            this.Named_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Named_textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Named_textBox1.Location = new System.Drawing.Point(118, 45);
            this.Named_textBox1.Name = "Named_textBox1";
            this.Named_textBox1.Size = new System.Drawing.Size(200, 26);
            this.Named_textBox1.TabIndex = 5;
            this.Named_textBox1.Text = "Enter your name";
            this.Named_textBox1.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // genderd_comboBox1
            // 
            this.genderd_comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderd_comboBox1.FormattingEnabled = true;
            this.genderd_comboBox1.Items.AddRange(new object[] {
            "male",
            "female"});
            this.genderd_comboBox1.Location = new System.Drawing.Point(94, 180);
            this.genderd_comboBox1.Name = "genderd_comboBox1";
            this.genderd_comboBox1.Size = new System.Drawing.Size(150, 28);
            this.genderd_comboBox1.TabIndex = 7;
            // 
            // adressD_textbox
            // 
            this.adressD_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressD_textbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.adressD_textbox.Location = new System.Drawing.Point(91, 254);
            this.adressD_textbox.Name = "adressD_textbox";
            this.adressD_textbox.Size = new System.Drawing.Size(200, 26);
            this.adressD_textbox.TabIndex = 9;
            this.adressD_textbox.Text = "Enter your Adress";
            this.adressD_textbox.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // emailD_label
            // 
            this.emailD_label.AutoSize = true;
            this.emailD_label.BackColor = System.Drawing.Color.Transparent;
            this.emailD_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailD_label.Location = new System.Drawing.Point(8, 314);
            this.emailD_label.Name = "emailD_label";
            this.emailD_label.Size = new System.Drawing.Size(64, 34);
            this.emailD_label.TabIndex = 10;
            this.emailD_label.Text = "Email:";
            // 
            // emaild_textBox1
            // 
            this.emaild_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaild_textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.emaild_textBox1.Location = new System.Drawing.Point(78, 322);
            this.emaild_textBox1.Name = "emaild_textBox1";
            this.emaild_textBox1.Size = new System.Drawing.Size(200, 26);
            this.emaild_textBox1.TabIndex = 11;
            this.emaild_textBox1.Text = "Enter your email";
            this.emaild_textBox1.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // master_label
            // 
            this.master_label.AutoSize = true;
            this.master_label.BackColor = System.Drawing.Color.Transparent;
            this.master_label.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_label.Location = new System.Drawing.Point(335, 19);
            this.master_label.Name = "master_label";
            this.master_label.Size = new System.Drawing.Size(90, 35);
            this.master_label.TabIndex = 13;
            this.master_label.Text = "Master :";
            // 
            // noP_label
            // 
            this.noP_label.AutoSize = true;
            this.noP_label.BackColor = System.Drawing.Color.Transparent;
            this.noP_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noP_label.Location = new System.Drawing.Point(323, 97);
            this.noP_label.Name = "noP_label";
            this.noP_label.Size = new System.Drawing.Size(142, 68);
            this.noP_label.TabIndex = 14;
            this.noP_label.Text = "Contact No(For\r\nPatient)\r\n";
            // 
            // nod_label
            // 
            this.nod_label.AutoSize = true;
            this.nod_label.BackColor = System.Drawing.Color.Transparent;
            this.nod_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nod_label.Location = new System.Drawing.Point(323, 189);
            this.nod_label.Name = "nod_label";
            this.nod_label.Size = new System.Drawing.Size(142, 68);
            this.nod_label.TabIndex = 15;
            this.nod_label.Text = "Contect No(For\r\nAdmin)\r\n";
            this.nod_label.Click += new System.EventHandler(this.nod_label_Click);
            // 
            // master_textbox
            // 
            this.master_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_textbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.master_textbox.Location = new System.Drawing.Point(438, 27);
            this.master_textbox.Name = "master_textbox";
            this.master_textbox.Size = new System.Drawing.Size(200, 26);
            this.master_textbox.TabIndex = 17;
            this.master_textbox.Text = "Enter your master";
            this.master_textbox.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // regulerd
            // 
            this.regulerd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regulerd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.regulerd.Location = new System.Drawing.Point(464, 139);
            this.regulerd.Name = "regulerd";
            this.regulerd.Size = new System.Drawing.Size(200, 26);
            this.regulerd.TabIndex = 18;
            this.regulerd.Text = "Reguler";
            this.regulerd.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // Emergencyd
            // 
            this.Emergencyd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emergencyd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Emergencyd.Location = new System.Drawing.Point(462, 226);
            this.Emergencyd.Name = "Emergencyd";
            this.Emergencyd.Size = new System.Drawing.Size(200, 26);
            this.Emergencyd.TabIndex = 19;
            this.Emergencyd.Text = "Emergency";
            this.Emergencyd.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // timeD_label
            // 
            this.timeD_label.AutoSize = true;
            this.timeD_label.BackColor = System.Drawing.Color.Transparent;
            this.timeD_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeD_label.Location = new System.Drawing.Point(339, 286);
            this.timeD_label.Name = "timeD_label";
            this.timeD_label.Size = new System.Drawing.Size(198, 34);
            this.timeD_label.TabIndex = 20;
            this.timeD_label.Text = "Best Time To Call You";
            // 
            // morningd
            // 
            this.morningd.AutoSize = true;
            this.morningd.BackColor = System.Drawing.Color.Transparent;
            this.morningd.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morningd.Location = new System.Drawing.Point(337, 323);
            this.morningd.Name = "morningd";
            this.morningd.Size = new System.Drawing.Size(102, 38);
            this.morningd.TabIndex = 21;
            this.morningd.TabStop = true;
            this.morningd.Text = "Morning";
            this.morningd.UseVisualStyleBackColor = false;
            // 
            // Eveningd
            // 
            this.Eveningd.AutoSize = true;
            this.Eveningd.BackColor = System.Drawing.Color.Transparent;
            this.Eveningd.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eveningd.Location = new System.Drawing.Point(566, 323);
            this.Eveningd.Name = "Eveningd";
            this.Eveningd.Size = new System.Drawing.Size(98, 38);
            this.Eveningd.TabIndex = 22;
            this.Eveningd.TabStop = true;
            this.Eveningd.Text = "Evening";
            this.Eveningd.UseVisualStyleBackColor = false;
            // 
            // afternoond
            // 
            this.afternoond.AutoSize = true;
            this.afternoond.BackColor = System.Drawing.Color.Transparent;
            this.afternoond.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afternoond.Location = new System.Drawing.Point(445, 323);
            this.afternoond.Name = "afternoond";
            this.afternoond.Size = new System.Drawing.Size(115, 38);
            this.afternoond.TabIndex = 23;
            this.afternoond.TabStop = true;
            this.afternoond.Text = "Afternoon\r\n";
            this.afternoond.UseVisualStyleBackColor = false;
            // 
            // sumbitd
            // 
            this.sumbitd.BackColor = System.Drawing.Color.Transparent;
            this.sumbitd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumbitd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumbitd.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumbitd.ForeColor = System.Drawing.Color.Navy;
            this.sumbitd.Location = new System.Drawing.Point(567, 426);
            this.sumbitd.Name = "sumbitd";
            this.sumbitd.Size = new System.Drawing.Size(109, 43);
            this.sumbitd.TabIndex = 24;
            this.sumbitd.Text = "Sumbit";
            this.sumbitd.UseVisualStyleBackColor = false;
            this.sumbitd.Click += new System.EventHandler(this.sumbitd_Click);
            // 
            // passwordD_label
            // 
            this.passwordD_label.AutoSize = true;
            this.passwordD_label.BackColor = System.Drawing.Color.Transparent;
            this.passwordD_label.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordD_label.Location = new System.Drawing.Point(5, 111);
            this.passwordD_label.Name = "passwordD_label";
            this.passwordD_label.Size = new System.Drawing.Size(112, 34);
            this.passwordD_label.TabIndex = 25;
            this.passwordD_label.Text = "Password :";
            // 
            // passwordD_textbox
            // 
            this.passwordD_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordD_textbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.passwordD_textbox.Location = new System.Drawing.Point(117, 119);
            this.passwordD_textbox.Name = "passwordD_textbox";
            this.passwordD_textbox.Size = new System.Drawing.Size(200, 26);
            this.passwordD_textbox.TabIndex = 26;
            this.passwordD_textbox.Text = "Enter your password";
            this.passwordD_textbox.TextChanged += new System.EventHandler(this.passwordD_textbox_TextChanged);
            this.passwordD_textbox.Enter += new System.EventHandler(this.doctor_textboxs);
            // 
            // create_doctor
            // 
            this.BackgroundImage = global::health_care.Properties.Resources.mano_medico_estetoscopio_sobre_fondo_blanco_estetoscopio_35024_16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 481);
            this.Controls.Add(this.passwordD_textbox);
            this.Controls.Add(this.passwordD_label);
            this.Controls.Add(this.sumbitd);
            this.Controls.Add(this.afternoond);
            this.Controls.Add(this.Eveningd);
            this.Controls.Add(this.morningd);
            this.Controls.Add(this.timeD_label);
            this.Controls.Add(this.Emergencyd);
            this.Controls.Add(this.regulerd);
            this.Controls.Add(this.master_textbox);
            this.Controls.Add(this.nod_label);
            this.Controls.Add(this.noP_label);
            this.Controls.Add(this.master_label);
            this.Controls.Add(this.emaild_textBox1);
            this.Controls.Add(this.emailD_label);
            this.Controls.Add(this.adressD_textbox);
            this.Controls.Add(this.genderd_comboBox1);
            this.Controls.Add(this.Named_textBox1);
            this.Controls.Add(this.adressd_label);
            this.Controls.Add(this.genderD_label2);
            this.Controls.Add(this.nameD_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "create_doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Account";
            this.Enter += new System.EventHandler(this.doctor_textboxs);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameD_labellabel1;
        private System.Windows.Forms.TextBox nameD_textbox;
        private System.Windows.Forms.Label GenderD_label;
        private System.Windows.Forms.TextBox PhoneD_textBox;
        private System.Windows.Forms.TextBox Speciality_doctor_textBox;
        private System.Windows.Forms.TextBox EmailD_textBox;
        private System.Windows.Forms.TextBox AddressD_textBoxtextBox4;
        private System.Windows.Forms.TextBox Education_doctor_textBox;
        private System.Windows.Forms.Label DobD_label;
        private System.Windows.Forms.Label PhoneD_labellabel2;
        private System.Windows.Forms.Label AddressD_label;
        private System.Windows.Forms.Label EmailD_doctor;
        private System.Windows.Forms.Label EducationD_label;
        private System.Windows.Forms.ComboBox genderD_comboBoxcomboBox1;
        private System.Windows.Forms.DateTimePicker birthD_timepiker;
        private System.Windows.Forms.Label SpecialityD_label;
        private System.Windows.Forms.Label noPD_label;
        private System.Windows.Forms.Label noAD_label;
        private System.Windows.Forms.Label Besttime_doctor_label;
        private System.Windows.Forms.TextBox ContactP_doctor_textBox;
        private System.Windows.Forms.TextBox conectA_doctor_textbox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button submitD_button;
        private System.Windows.Forms.Label nameD_label;
        private System.Windows.Forms.Label genderD_label2;
        private System.Windows.Forms.Label adressd_label;
        private System.Windows.Forms.TextBox Named_textBox1;
        private System.Windows.Forms.ComboBox genderd_comboBox1;
        private System.Windows.Forms.TextBox adressD_textbox;
        private System.Windows.Forms.Label emailD_label;
        private System.Windows.Forms.TextBox emaild_textBox1;
        private System.Windows.Forms.Label master_label;
        private System.Windows.Forms.Label noP_label;
        private System.Windows.Forms.Label nod_label;
        private System.Windows.Forms.TextBox master_textbox;
        private System.Windows.Forms.TextBox regulerd;
        private System.Windows.Forms.TextBox Emergencyd;
        private System.Windows.Forms.Label timeD_label;
        private System.Windows.Forms.RadioButton morningd;
        private System.Windows.Forms.RadioButton Eveningd;
        private System.Windows.Forms.RadioButton afternoond;
        private System.Windows.Forms.Button sumbitd;
        private System.Windows.Forms.Label passwordD_label;
        private System.Windows.Forms.TextBox passwordD_textbox;


        public System.Drawing.Color Null { get; set; }
    }
}