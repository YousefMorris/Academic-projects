namespace health_care
{
    partial class logIN_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logIN_form));
            this.login_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username_textBox1 = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox2 = new System.Windows.Forms.TextBox();
            this.qestion_label = new System.Windows.Forms.Label();
            this.create_linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.login_button = new System.Windows.Forms.Button();
            this.incorrect_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_label.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(18, 25);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(87, 44);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Log in";
            // 
            // username_label
            // 
            this.username_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(67, 120);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(161, 42);
            this.username_label.TabIndex = 1;
            this.username_label.Text = "User Name :";
            // 
            // username_textBox1
            // 
            this.username_textBox1.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.username_textBox1.Location = new System.Drawing.Point(224, 120);
            this.username_textBox1.Name = "username_textBox1";
            this.username_textBox1.Size = new System.Drawing.Size(263, 49);
            this.username_textBox1.TabIndex = 26;
            this.username_textBox1.Text = "Enter your Username";
            this.username_textBox1.Click += new System.EventHandler(this.username_textbox);
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.Location = new System.Drawing.Point(74, 208);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(150, 42);
            this.password_label.TabIndex = 27;
            this.password_label.Text = "PassWord :";
            // 
            // password_textBox2
            // 
            this.password_textBox2.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.password_textBox2.Location = new System.Drawing.Point(225, 212);
            this.password_textBox2.Name = "password_textBox2";
            this.password_textBox2.Size = new System.Drawing.Size(263, 49);
            this.password_textBox2.TabIndex = 28;
            this.password_textBox2.Text = "Enter your Password";
            this.password_textBox2.Click += new System.EventHandler(this.password_textbox);
            this.password_textBox2.TextChanged += new System.EventHandler(this.password_textBox2_TextChanged_1);
            // 
            // qestion_label
            // 
            this.qestion_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.qestion_label.AutoSize = true;
            this.qestion_label.BackColor = System.Drawing.Color.Transparent;
            this.qestion_label.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qestion_label.Location = new System.Drawing.Point(62, 359);
            this.qestion_label.Name = "qestion_label";
            this.qestion_label.Size = new System.Drawing.Size(280, 42);
            this.qestion_label.TabIndex = 29;
            this.qestion_label.Text = "Don\'t Have an Acount ?";
            // 
            // create_linkLabel1
            // 
            this.create_linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.create_linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.create_linkLabel1.AutoSize = true;
            this.create_linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.create_linkLabel1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.create_linkLabel1.Location = new System.Drawing.Point(348, 368);
            this.create_linkLabel1.Name = "create_linkLabel1";
            this.create_linkLabel1.Size = new System.Drawing.Size(76, 35);
            this.create_linkLabel1.TabIndex = 30;
            this.create_linkLabel1.TabStop = true;
            this.create_linkLabel1.Text = "Create";
            this.create_linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.create_linkLabel1_LinkClicked);
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.Navy;
            this.login_button.Location = new System.Drawing.Point(576, 400);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(106, 46);
            this.login_button.TabIndex = 31;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // incorrect_label
            // 
            this.incorrect_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.incorrect_label.AutoSize = true;
            this.incorrect_label.BackColor = System.Drawing.Color.Transparent;
            this.incorrect_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrect_label.ForeColor = System.Drawing.Color.Red;
            this.incorrect_label.Location = new System.Drawing.Point(139, 280);
            this.incorrect_label.Name = "incorrect_label";
            this.incorrect_label.Size = new System.Drawing.Size(472, 16);
            this.incorrect_label.TabIndex = 32;
            this.incorrect_label.Text = "Username or Password in notvalid .Please check them and try agin ";
            this.incorrect_label.Visible = false;
            // 
            // logIN_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::health_care.Properties.Resources.health_care_generic_11vn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.incorrect_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.create_linkLabel1);
            this.Controls.Add(this.qestion_label);
            this.Controls.Add(this.password_textBox2);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_textBox1);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_label);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logIN_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Health Care";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_textBox1;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox2;
        private System.Windows.Forms.Label qestion_label;
        private System.Windows.Forms.LinkLabel create_linkLabel1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label incorrect_label;
    }
}

