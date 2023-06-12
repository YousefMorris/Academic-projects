namespace health_care
{
    partial class view_appointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_appointments));
            this.back_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button2
            // 
            this.back_button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button2.BackColor = System.Drawing.Color.Transparent;
            this.back_button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button2.ForeColor = System.Drawing.Color.Navy;
            this.back_button2.Location = new System.Drawing.Point(573, 386);
            this.back_button2.Name = "back_button2";
            this.back_button2.Size = new System.Drawing.Size(119, 47);
            this.back_button2.TabIndex = 6;
            this.back_button2.Text = "Back";
            this.back_button2.UseVisualStyleBackColor = false;
            this.back_button2.Click += new System.EventHandler(this.back_button2_Click);
            // 
            // view_appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::health_care.Properties.Resources.health_care_generic_11vn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.back_button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "view_appointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Care";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button2;
    }
}