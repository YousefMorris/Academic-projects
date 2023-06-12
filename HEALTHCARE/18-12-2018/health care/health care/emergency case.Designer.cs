namespace health_care
{
    partial class emergency_case
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.emergency_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-6, 1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(490, 262);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // emergency_button
            // 
            this.emergency_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emergency_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emergency_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.emergency_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.emergency_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergency_button.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergency_button.ForeColor = System.Drawing.Color.Navy;
            this.emergency_button.Location = new System.Drawing.Point(395, 209);
            this.emergency_button.Name = "emergency_button";
            this.emergency_button.Size = new System.Drawing.Size(77, 40);
            this.emergency_button.TabIndex = 9;
            this.emergency_button.Text = "Send";
            this.emergency_button.UseVisualStyleBackColor = true;
            this.emergency_button.Click += new System.EventHandler(this.emergency_button_Click);
            // 
            // emergency_case
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.ControlBox = false;
            this.Controls.Add(this.emergency_button);
            this.Controls.Add(this.richTextBox1);
            this.Name = "emergency_case";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emergency_case";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button emergency_button;
    }
}