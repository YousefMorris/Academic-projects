namespace health_care
{
    partial class doctor_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_control));
            this.show_requests = new System.Windows.Forms.Button();
            this.show_EC = new System.Windows.Forms.Button();
            this.reply = new System.Windows.Forms.Button();
            this.view_patients = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_requests
            // 
            this.show_requests.BackColor = System.Drawing.Color.Transparent;
            this.show_requests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_requests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_requests.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_requests.ForeColor = System.Drawing.Color.Navy;
            this.show_requests.Location = new System.Drawing.Point(37, 67);
            this.show_requests.Name = "show_requests";
            this.show_requests.Size = new System.Drawing.Size(215, 65);
            this.show_requests.TabIndex = 5;
            this.show_requests.Text = "Patients Requests";
            this.show_requests.UseVisualStyleBackColor = false;
            this.show_requests.Click += new System.EventHandler(this.show_requests_Click);
            // 
            // show_EC
            // 
            this.show_EC.BackColor = System.Drawing.Color.Transparent;
            this.show_EC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_EC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_EC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_EC.ForeColor = System.Drawing.Color.Navy;
            this.show_EC.Location = new System.Drawing.Point(37, 189);
            this.show_EC.Name = "show_EC";
            this.show_EC.Size = new System.Drawing.Size(215, 65);
            this.show_EC.TabIndex = 6;
            this.show_EC.Text = "show E.C.S";
            this.show_EC.UseVisualStyleBackColor = false;
            this.show_EC.Click += new System.EventHandler(this.show_EC_Click);
            // 
            // reply
            // 
            this.reply.BackColor = System.Drawing.Color.Transparent;
            this.reply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reply.ForeColor = System.Drawing.Color.Navy;
            this.reply.Location = new System.Drawing.Point(37, 315);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(215, 65);
            this.reply.TabIndex = 7;
            this.reply.Text = "Reply Questions";
            this.reply.UseVisualStyleBackColor = false;
            this.reply.Click += new System.EventHandler(this.reply_Click);
            // 
            // view_patients
            // 
            this.view_patients.BackColor = System.Drawing.Color.Transparent;
            this.view_patients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_patients.ForeColor = System.Drawing.Color.Navy;
            this.view_patients.Location = new System.Drawing.Point(329, 315);
            this.view_patients.Name = "view_patients";
            this.view_patients.Size = new System.Drawing.Size(215, 65);
            this.view_patients.TabIndex = 8;
            this.view_patients.Text = "view appointment";
            this.view_patients.UseVisualStyleBackColor = false;
            this.view_patients.Click += new System.EventHandler(this.view_patients_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Navy;
            this.update.Location = new System.Drawing.Point(329, 191);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(215, 65);
            this.update.TabIndex = 9;
            this.update.Text = "update Work hours";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(329, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 65);
            this.button1.TabIndex = 10;
            this.button1.Text = "view patients";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctor_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::health_care.Properties.Resources.health_care_generic_11vn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.view_patients);
            this.Controls.Add(this.reply);
            this.Controls.Add(this.show_EC);
            this.Controls.Add(this.show_requests);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "doctor_control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Care";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_requests;
        private System.Windows.Forms.Button show_EC;
        private System.Windows.Forms.Button reply;
        private System.Windows.Forms.Button view_patients;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button1;
    }
}