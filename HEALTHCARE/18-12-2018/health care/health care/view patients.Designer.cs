namespace health_care
{
    partial class view_patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_patients));
            this.the_subTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.patientNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // the_subTextBox
            // 
            this.the_subTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.the_subTextBox.Location = new System.Drawing.Point(70, 244);
            this.the_subTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.the_subTextBox.Multiline = true;
            this.the_subTextBox.Name = "the_subTextBox";
            this.the_subTextBox.Size = new System.Drawing.Size(296, 70);
            this.the_subTextBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.Transparent;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.Navy;
            this.sendButton.Location = new System.Drawing.Point(438, 257);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(120, 53);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientNameComboBox
            // 
            this.patientNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameComboBox.FormattingEnabled = true;
            this.patientNameComboBox.Location = new System.Drawing.Point(70, 93);
            this.patientNameComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientNameComboBox.Name = "patientNameComboBox";
            this.patientNameComboBox.Size = new System.Drawing.Size(206, 24);
            this.patientNameComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Patient Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Send Subscribtion :";
            // 
            // back_button1
            // 
            this.back_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button1.BackColor = System.Drawing.Color.Transparent;
            this.back_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button1.ForeColor = System.Drawing.Color.Navy;
            this.back_button1.Location = new System.Drawing.Point(557, 408);
            this.back_button1.Margin = new System.Windows.Forms.Padding(2);
            this.back_button1.Name = "back_button1";
            this.back_button1.Size = new System.Drawing.Size(120, 53);
            this.back_button1.TabIndex = 5;
            this.back_button1.Text = "Back";
            this.back_button1.UseVisualStyleBackColor = false;
            this.back_button1.Click += new System.EventHandler(this.back_button1_Click);
            // 
            // view_patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::health_care.Properties.Resources.health_care_generic_11vn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.back_button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patientNameComboBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.the_subTextBox);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "view_patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Care";
            this.Load += new System.EventHandler(this.view_patients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox the_subTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox patientNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button1;
    }
}