namespace health_care
{
    partial class patient_requests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient_requests));
            this.request_comboBox = new System.Windows.Forms.ComboBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.Reject_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // request_comboBox
            // 
            this.request_comboBox.FormattingEnabled = true;
            this.request_comboBox.Location = new System.Drawing.Point(51, 81);
            this.request_comboBox.Name = "request_comboBox";
            this.request_comboBox.Size = new System.Drawing.Size(202, 21);
            this.request_comboBox.TabIndex = 0;
            this.request_comboBox.SelectedIndexChanged += new System.EventHandler(this.request_comboBox_SelectedIndexChanged);
            // 
            // confirm_button
            // 
            this.confirm_button.BackColor = System.Drawing.Color.Transparent;
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_button.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.ForeColor = System.Drawing.Color.Navy;
            this.confirm_button.Location = new System.Drawing.Point(413, 62);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(125, 46);
            this.confirm_button.TabIndex = 5;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = false;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // Reject_button
            // 
            this.Reject_button.BackColor = System.Drawing.Color.Transparent;
            this.Reject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reject_button.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reject_button.ForeColor = System.Drawing.Color.Navy;
            this.Reject_button.Location = new System.Drawing.Point(564, 62);
            this.Reject_button.Name = "Reject_button";
            this.Reject_button.Size = new System.Drawing.Size(106, 46);
            this.Reject_button.TabIndex = 6;
            this.Reject_button.Text = "Reject";
            this.Reject_button.UseVisualStyleBackColor = false;
            this.Reject_button.Click += new System.EventHandler(this.Reject_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Appointment :";
            // 
            // back_button1
            // 
            this.back_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button1.BackColor = System.Drawing.Color.Transparent;
            this.back_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button1.ForeColor = System.Drawing.Color.Navy;
            this.back_button1.Location = new System.Drawing.Point(564, 412);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(125, 46);
            this.back_button1.TabIndex = 9;
            this.back_button1.Text = "Back";
            this.back_button1.UseVisualStyleBackColor = false;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            // 
            // patient_requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::health_care.Properties.Resources.health_care_generic_11vn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.back_button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reject_button);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.request_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "patient_requests";
            this.Text = "Health Care";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox request_comboBox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button Reject_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button1;


    }
}