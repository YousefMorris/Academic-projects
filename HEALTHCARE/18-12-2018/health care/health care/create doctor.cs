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
    public partial class create_doctor : Form
    {
        public create_doctor()
        {
            InitializeComponent();
        }

        private void doctor_textboxs(object sender, EventArgs e)
        {
            TextBox d = (TextBox)sender;
            d.Text = string.Empty;
            d.ForeColor = System.Drawing.SystemColors.WindowText;
        }
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");

        private void sumbitd_Click(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand cmd = new SqlCommand("insert__doctor", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@doc_name", Named_textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_password", passwordD_textbox.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_gender", genderd_comboBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_phonePatient", regulerd.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_phoneAdmin", Emergencyd.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_email", emaild_textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_address", adressD_textbox.Text));
            cmd.Parameters.Add(new SqlParameter("@doc_master ", master_textbox.Text));
            cmd.Parameters.Add(new SqlParameter("@adm_id",'0'));
            if (morningd.Checked == true)
            {
                cmd.Parameters.Add(new SqlParameter("@doc_freeTime", morningd.Text));
            }
            else if (afternoond.Checked == true)
            {
              
               cmd.Parameters.Add(new SqlParameter("@doc_freeTime", afternoond.Text));
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter("@doc_freeTime", Eveningd.Text));

            }
            
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            con.Close();
            MessageBox.Show("saved");
            reader.Close();
        }

       

      
       

    }
}
