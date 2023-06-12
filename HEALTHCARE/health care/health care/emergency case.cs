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
    public partial class emergency_case : Form
    {
        string Patname;
        public emergency_case(string name)
        {
            InitializeComponent();
            InitializeComponent();
            Patname = name;
            Patname.ToCharArray();
        }
        private void emergency_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand("insert into emergencycase(em_description,pat_name) values('" + richTextBox1.Text + "','" + Patname + "')", con);
            com.CommandType = CommandType.Text;
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            reader.Close();
            MessageBox.Show("Messege send");
            this.Hide();
        }
    }
}
