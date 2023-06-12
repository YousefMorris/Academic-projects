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
    public partial class view_ECS : Form
    {
        string docname = "";
        public view_ECS(string doc_name)
        {
            InitializeComponent();
            docname = doc_name;
            show_EC_Click(doc_name);
        }
        public DataTable ecs = new DataTable();
        public void show_EC_Click(string doctorn)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand f = new SqlCommand("select * from emergencycase", con);
            f.CommandType = CommandType.Text;
            SqlDataReader reader = f.ExecuteReader();
            ecs.Columns.Add("ec_num");
            ecs.Columns.Add("pat_name");
            ecs.Columns.Add("em_description");
            DataRow row;
            while (reader.Read())
            {
                row = ecs.NewRow();
                row["ec_num"] = reader["ec_num"];
                row["pat_name"] = reader["pat_name"];
                row["em_description"] = reader["em_description"];
                comboBox1.Items.Add(reader["pat_name"]);


                ecs.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            conn.Open();
            SqlCommand com = new SqlCommand("update emergencycase set doc_name='" + docname + "'", conn);
            com.CommandType = CommandType.Text;
            SqlDataReader re = com.ExecuteReader();
            re.Read();
            re.Close();
            conn.Close();
            MessageBox.Show("YOU Accepted This Emergency Case");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataRow r in ecs.Rows)
            {
                if (comboBox1.Text == ecs.Rows[count][1].ToString())
                {
                    label1.Text = string.Empty;
                    label1.Text = ecs.Rows[count][0].ToString() + "    " + ecs.Rows[count][1].ToString()+"   "+ecs.Rows[count][2].ToString();
                }
                count++;
            }
        }

        private void back_button2_Click(object sender, EventArgs e)
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
