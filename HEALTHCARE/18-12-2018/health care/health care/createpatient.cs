using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace health_care
{
    public partial class create_patient : Form
    {
        
        
            
        public create_patient()
        {
            InitializeComponent();
        }

        private void Textbox_Isactive(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = string.Empty;
            t.ForeColor = System.Drawing.SystemColors.WindowText;

        }

        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
        private void submitP_button_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert_pPatient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@pat_name", usernameP_textBox.Text));
            cmd.Parameters.Add(new SqlParameter("@pat_password", passwordP_textBox.Text));
            cmd.Parameters.Add(new SqlParameter("@pat_gender", genderP_comboBox.Text));
            cmd.Parameters.Add(new SqlParameter("@pat_phone", phoneP_textBox.Text));
            cmd.Parameters.Add(new SqlParameter("@pat_email", emailP_textBox.Text));
            cmd.Parameters.Add(new SqlParameter("@pat_address", addressP_textBox.Text));
           
            //cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            con.Close();
            MessageBox.Show("saved");
            reader.Close();
        }

        private void password(object sender, EventArgs e)
        {
            passwordP_textBox.Text = string.Empty;
            this.passwordP_textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordP_textBox.PasswordChar = '♫';
        }

      

     

    }
}
