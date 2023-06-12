
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

    public partial class view_patients : Form
    {
        string docname = "";
        public view_patients(string name)
        {
            InitializeComponent();
            fillComboBox();
            docname = name;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
        void fillComboBox()
        {
            string quary = "select pat_name from patients";
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                patientNameComboBox.Items.Add(reader["pat_name"]);
            }
            reader.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //the_subTextBox
            string quary = "update  patients set pat_sub = '" + the_subTextBox.Text + "' where pat_name like '" + patientNameComboBox.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void view_patients_Load(object sender, EventArgs e)
        {

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
    }
}
