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
    public partial class patient_requests : Form
    {
        public string name;
        public patient_requests(string docname)
        {
            InitializeComponent();
           
            requests(docname);
            name = docname;
        }
               public DataTable app = new DataTable();

        public void requests(string doc__name)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand f = new SqlCommand("select * from appoinment where doc_name='" + doc__name + "'", con);
            f.CommandType = CommandType.Text;
            SqlDataReader reader = f.ExecuteReader();
            app.Columns.Add("app_num");
            app.Columns.Add("app_date");
            app.Columns.Add("app_fromh");
            app.Columns.Add("app_fromm");
            app.Columns.Add("app_toh");
            app.Columns.Add("app_tom");
            app.Columns.Add("app_patname");
            DataRow row;
            while (reader.Read())
            {
                row = app.NewRow();
                row["app_num"] = reader["app_num"];
                row["app_date"] = reader["app_date"];
                row["app_fromh"] = reader["app_fromH"];
                row["app_fromm"] = reader["app_fromM"];
                row["app_toh"] = reader["app_toH"];
                row["app_tom"] = reader["app_toM"];
                row["app_patname"] = reader["pat_name"];
                app.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            int count = 0;
            foreach (DataRow r in app.Rows)
            {
                request_comboBox.Items.Add(app.Rows[count][6]);
                count++;
            }
        }
        public void confirm(int d)
        {
            SqlConnection scon = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            scon.Open();
            SqlCommand com = new SqlCommand("update appoinment set appointment='confirm' where pat_name='" + request_comboBox.Text + "';", scon);
            com.CommandType = CommandType.Text;
            SqlDataReader reader2 = com.ExecuteReader();
            reader2.Read();
            reader2.Close();
            MessageBox.Show("appointment is confirm");
            scon.Close();
        }
        public void reject(int c)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            conn.Open();
            SqlCommand com = new SqlCommand("update appoinment set appointment='reject'  where  pat_name='" + request_comboBox.Text + "';", conn);
            com.CommandType = CommandType.Text;
            SqlDataReader reader2 = com.ExecuteReader();
            reader2.Read();
            reader2.Close();
            MessageBox.Show("appointment is reject");
            conn.Close();
        }
        private void confirm_button_Click(object sender, EventArgs e)
        {
            confirm(temp);
           
        }
        public int temp;
        private void request_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataRow r in app.Rows)
            {
                if (request_comboBox.Text == app.Rows[count][6].ToString())
                {
                    temp = count;
                    label1.Text = string.Empty;
                    label1.Text = app.Rows[count][0].ToString() + "    " + app.Rows[count][1].ToString()
                    + "    " + app.Rows[count][2].ToString() + " : " + app.Rows[count][3].ToString()
                    + "    " + app.Rows[count][4].ToString() + " : " + app.Rows[count][5].ToString();
                }
            }
            count++;
        }

        private void Reject_button_Click(object sender, EventArgs e)
        {
            reject(temp);
        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            doctor_control p = new doctor_control(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                p.WindowState = FormWindowState.Maximized;
            }
            p.Show();
            this.Hide();
        }

       
    }
}