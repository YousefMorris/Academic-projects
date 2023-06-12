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
    public partial class view_appointments : Form
    {
        public string doc_name = "";
        public view_appointments(string docname)
        {
            InitializeComponent();
            doc_name = docname;
            all_appointment();
        }
         public void all_appointment()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from appoinment where doc_name= '" + doc_name + "' and appointment='confirm' ;", conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable app = new DataTable();
            app.Columns.Add("app_num");
            app.Columns.Add("app_date");
            app.Columns.Add("app_fromh");
            app.Columns.Add("app_fromm");
            app.Columns.Add("app_toh");
            app.Columns.Add("app_tom");
            app.Columns.Add("pat_name");
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
                row["pat_name"] = reader["pat_name"];
                app.Rows.Add(row);
            }
            reader.Close();
            conn.Close();
            int count = 0, x_num = 70, y = 40;
            foreach (DataRow r in app.Rows)
            {
                Label app_num = new Label();
                app_num.Text = app.Rows[count][0].ToString() + "    " + app.Rows[count][1].ToString()
                    + "    " + app.Rows[count][2].ToString() + " : " + app.Rows[count][3].ToString()
                    + "    " + app.Rows[count][4].ToString() + " : " + app.Rows[count][5].ToString()+"   "+app.Rows[count][6].ToString();
                app_num.Location = new System.Drawing.Point(x_num, y);
                app_num.AutoSize = true;
                app_num.BackColor = System.Drawing.Color.Transparent;
                app_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                app_num.Size = new System.Drawing.Size(57, 20);
                app_num.TabIndex = 0;
                this.Controls.Add(app_num);
                count++;
                y+=40;
            }
        }

         private void back_button2_Click(object sender, EventArgs e)
         {
             doctor_control d = new doctor_control(doc_name);
             if (this.WindowState == FormWindowState.Maximized)
             {
                 d.WindowState = FormWindowState.Maximized;
             }
             d.Show();
             this.Hide();
         }
    
    }
}
