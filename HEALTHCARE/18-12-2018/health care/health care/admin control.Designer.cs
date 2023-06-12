namespace health_care
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.new_doc_account = new System.Windows.Forms.Label();
            this.view_ECS = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.view_ecs_comboBox = new System.Windows.Forms.ComboBox();
            this.top_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_doc_account
            // 
            this.new_doc_account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.new_doc_account.AutoSize = true;
            this.new_doc_account.BackColor = System.Drawing.Color.Transparent;
            this.new_doc_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_doc_account.Location = new System.Drawing.Point(25, 37);
            this.new_doc_account.Name = "new_doc_account";
            this.new_doc_account.Size = new System.Drawing.Size(400, 42);
            this.new_doc_account.TabIndex = 0;
            this.new_doc_account.Text = " New doctor account :";
            // 
            // view_ECS
            // 
            this.view_ECS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_ECS.AutoSize = true;
            this.view_ECS.BackColor = System.Drawing.Color.Transparent;
            this.view_ECS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_ECS.Location = new System.Drawing.Point(49, 176);
            this.view_ECS.Name = "view_ECS";
            this.view_ECS.Size = new System.Drawing.Size(144, 39);
            this.view_ECS.TabIndex = 1;
            this.view_ECS.Text = " E.C.S :";
            // 
            // create_button
            // 
            this.create_button.BackColor = System.Drawing.Color.Transparent;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.Navy;
            this.create_button.Location = new System.Drawing.Point(431, 38);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(106, 46);
            this.create_button.TabIndex = 2;
            this.create_button.Text = "Create";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_Click_1);
            // 
            // view_ecs_comboBox
            // 
            this.view_ecs_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.view_ecs_comboBox.FormattingEnabled = true;
            this.view_ecs_comboBox.Location = new System.Drawing.Point(199, 185);
            this.view_ecs_comboBox.Name = "view_ecs_comboBox";
            this.view_ecs_comboBox.Size = new System.Drawing.Size(307, 21);
            this.view_ecs_comboBox.TabIndex = 3;
            // 
            // top_button
            // 
            this.top_button.BackColor = System.Drawing.Color.Transparent;
            this.top_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.top_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_button.ForeColor = System.Drawing.Color.Navy;
            this.top_button.Location = new System.Drawing.Point(409, 360);
            this.top_button.Name = "top_button";
            this.top_button.Size = new System.Drawing.Size(106, 46);
            this.top_button.TabIndex = 4;
            this.top_button.Text = "TOP";
            this.top_button.UseVisualStyleBackColor = false;
            this.top_button.Click += new System.EventHandler(this.top_button_Click);
            // 
            // down_button
            // 
            this.down_button.BackColor = System.Drawing.Color.Transparent;
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down_button.ForeColor = System.Drawing.Color.Navy;
            this.down_button.Location = new System.Drawing.Point(571, 360);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(106, 46);
            this.down_button.TabIndex = 5;
            this.down_button.Text = "Down";
            this.down_button.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::health_care.Properties.Resources.health_care_generic_11vn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.top_button);
            this.Controls.Add(this.view_ecs_comboBox);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.view_ECS);
            this.Controls.Add(this.new_doc_account);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Care";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label new_doc_account;
        private System.Windows.Forms.Label view_ECS;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.ComboBox view_ecs_comboBox;
        private System.Windows.Forms.Button top_button;
        private System.Windows.Forms.Button down_button;
    }
}