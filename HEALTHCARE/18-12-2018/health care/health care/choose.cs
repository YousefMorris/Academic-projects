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
    public partial class choose : Form
    {
        string named="",namep="";
        public choose(string docname,string patname)
        {
            InitializeComponent();
            named = docname;
            namep = patname;
            named.ToCharArray();
            
        }
        public void set_appoinment()
        {

            decimal fromh, fromm, toh=0, tom;
            fromh = hour_numericUpDown.Value;
            fromm = min_numericUpDown.Value;
            tom = min_numericUpDown.Value + 15;
            if (tom > 45)
            {
                toh += 1;
                tom = 00;
            }
            else
            {
                toh = fromh;
            }
            string date="";
            date += day_numericUpDown.Value.ToString()+"/";
            date += month_numericUpDown.Value.ToString()+"/";
            date += year_numericUpDown.Value.ToString();
            
            //get all appoinments
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from view_0appoinments('"+named+"')", con);
            cmd1.CommandType = CommandType.Text;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            DataTable appoinment = new DataTable();
            appoinment.Columns.Add("app_date",typeof(string));
            appoinment.Columns.Add("app_fromh",typeof(decimal));
            appoinment.Columns.Add("app_fromm",typeof(decimal));
            appoinment.Columns.Add("app_toh",typeof(decimal));
            appoinment.Columns.Add("app_tom",typeof(decimal));
          
            DataRow row;
            while (reader1.Read())
            {
                row = appoinment.NewRow();
                row["app_date"] = reader1["app_date"];
                row["app_fromm"] = reader1["app_fromM"];
                row["app_fromh"] = reader1["app_fromH"];
                row["app_toh"] = reader1["app_toH"];
                row["app_tom"] = reader1["app_toM"];
                appoinment.Rows.Add(row);
            }
            reader1.Close();
            //check new date &time 
            SqlCommand cmd2 = new SqlCommand("select * from doctor__workh('"+named+"')", con);
            cmd2.CommandType = CommandType.Text;
            SqlDataReader reader2 = cmd2.ExecuteReader();
            DataTable workH = new DataTable();
            workH.Columns.Add("from_h",typeof (decimal));
            workH.Columns.Add("from_m", typeof(decimal));
            workH.Columns.Add("to_h", typeof(decimal));
            workH.Columns.Add("to_m", typeof(decimal));
           
            DataRow row2;
            while (reader2.Read())
            {
                row2 = workH.NewRow();
                row2["from_h"] = reader2["from_h"];
                row2["from_m"] = reader2["from_m"];
                row2["to_h"] = reader2["to_h"];
                row2["to_m"] = reader2["to_m"];
               
                workH.Rows.Add(row2);

            }
            reader2.Close();
            int count = 0;
            bool vailed_inwh = false;
            //compare between entered time & doctor work hours
            foreach(DataRow r1 in workH.Rows)
            {
                if (fromh >= (decimal)workH.Rows[count][0] 
                    && fromh <=(decimal)workH.Rows[count][2]
                    && tom<=(decimal)workH.Rows[count][3])
                {
                    vailed_inwh = true;
                }
                count++;
            }
            //compare between doctor appoinment
            int count3=0;
            bool isvalid_inapp = false;
            foreach (DataRow r2 in appoinment.Rows)
            {
                if(date==appoinment.Rows[count3][0].ToString())
                {
                    if (fromh == (decimal)appoinment.Rows[count3][3] 
                        &&fromm==(decimal)appoinment.Rows[count3][2])
                    {
                        isvalid_inapp = true;
                    }
                }
                count3++;
               
            }
            if (vailed_inwh && !isvalid_inapp)
            {
                //add new appoinment
                SqlCommand cmd = new SqlCommand("add_appointment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@app_date", date));
                cmd.Parameters.Add(new SqlParameter("@app_fromH",fromh));
                cmd.Parameters.Add(new SqlParameter("@app_fromM",fromm));
                cmd.Parameters.Add(new SqlParameter("@app_toH", toh));
                cmd.Parameters.Add(new SqlParameter("@app_toM", tom));
                cmd.Parameters.Add(new SqlParameter("@doc_name", named));
                cmd.Parameters.Add(new SqlParameter("@pat_name", namep));
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                 MessageBox.Show("Wait Doctor confirm ");
                reader.Close();
               
                
                con.Close();
            }
            else if (!vailed_inwh)
            {
                MessageBox.Show("Out of Doctor work hours.Please enter anthor appoinment");

            }
            else if (isvalid_inapp)
            {
                MessageBox.Show("This appoinment is full");
            }


          
            
        }

        private void appointment_sumbit_Click(object sender, EventArgs e)
        {
            set_appoinment();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            view_patient p = new view_patient(namep);
            if (this.WindowState == FormWindowState.Maximized)
            {
                p.WindowState = FormWindowState.Maximized;
            }
            p.Show();
            this.Hide();
        }

        private void submitP_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("insert into Questions(que_question,doc_name,pat_name) values('" + que_richTextBox.Text + "','" + named +"','"+namep+ "')", con);
            command.CommandType = CommandType.Text;
            SqlDataReader read = command.ExecuteReader();
            read.Read();
            read.Close();
            con.Close();
            MessageBox.Show("Messege send to doctor");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
       

       

    }
}
