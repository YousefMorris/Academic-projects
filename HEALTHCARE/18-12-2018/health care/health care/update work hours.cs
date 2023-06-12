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
    public partial class update_work_hours : Form
    {
        public string docname = "";
        public update_work_hours(string name)
        {
            InitializeComponent();
            docname = name;
        }
        public void update_WH()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update_Workh", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@doc_name", docname));
            cmd.Parameters.Add(new SqlParameter("@from_h", numericUpDown1.Value));
            cmd.Parameters.Add(new SqlParameter("@from_m ", numericUpDown2.Value));
            cmd.Parameters.Add(new SqlParameter("@to_h", numericUpDown3.Value));
            cmd.Parameters.Add(new SqlParameter("@to_m", numericUpDown4.Value));
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            con.Close();
            MessageBox.Show("saved");
            reader.Close();
            
        }
        private void back_button1_Click(object sender, EventArgs e)
        {
            doctor_control d = new doctor_control(docname);
            if (this.WindowState == FormWindowState.Maximized)
            {
                d.WindowState = FormWindowState.Maximized;
            }
            d.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            update_WH();
        }
    }
}
