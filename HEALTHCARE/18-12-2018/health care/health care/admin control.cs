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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            emergency_cases();
        }

      

       

        private void create_Click_1(object sender, EventArgs e)
        {
            create_doctor d = new create_doctor();
            if (this.WindowState == FormWindowState.Maximized)
            {
                d.WindowState = FormWindowState.Maximized;
            }
            d.Show();
            
        }
        public DataTable emergency_case = new DataTable();
        public void emergency_cases()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(" select * from emergencycase", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader1 = cmd.ExecuteReader();
            
            emergency_case.Columns.Add("ec_num");
            emergency_case.Columns.Add("em_description");
            emergency_case.Columns.Add("pat_name");
            emergency_case.Columns.Add("doc_name");
            DataRow row;
            while (reader1.Read())
            {
                row = emergency_case.NewRow();

                row["ec_num"] = reader1["ec_num"];
                row["em_description"] = reader1["em_description"];
                row["pat_name"] = reader1["pat_name"];
                row["doc_name"] = reader1["doc_name"];
                emergency_case.Rows.Add(row);
            }
            reader1.Close();
            con.Close();
            int count=0;
            foreach(DataRow r in emergency_case.Rows){
                view_ecs_comboBox.Items.Add(emergency_case.Rows[count][1].ToString());
                count++;
            }
            
           
        }
        public void swap(DataTable ec){
            int count=0;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            //DataTable temp = new DataTable();

            //temp.Columns.Add("ec_num");
            //temp.Columns.Add("em_description");
            //temp.Columns.Add("pat_name");
            //temp.Columns.Add("doc_name");
            //int count5=0;
            //DataRow row;
            //foreach (DataRow m in ec.Rows)
            //{
            //    row = temp.NewRow();

            //    row["ec_num"] = ec.Rows[count5]["ec_num"];
            //    row["em_description"] = ec.Rows[count5]["em_description"];
            //    row["pat_name"] = ec.Rows[count5]["pat_name"];
            //    row["doc_name"] = ec.Rows[count5]["doc_name"];
            //    temp.Rows.Add(row);
            //    //temp.Rows[count5]["ec_num"] = ec.Rows[count5]["ec_num"];
                //temp.Rows[count5]["em_description"] = ec.Rows[count5]["em_description"];
                //temp.Rows[count5]["pat_name"] = ec.Rows[count5]["pat_name"];
                //temp.Rows[count5]["doc_name"] = ec.Rows[count5]["doc_name"];
            //    count5++;
            //}
            
            foreach (DataRow r in ec.Rows)
            {
                if (view_ecs_comboBox.Text == ec.Rows[count][1].ToString())
                {
                    SqlCommand cmd = new SqlCommand(" insert into emergencycase(em_description,pat_name,doc_name) values(' " + ec.Rows[0][1] + "','" + ec.Rows[0][2] + "','" + ec.Rows[0][3] + "')" , con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader2 = cmd.ExecuteReader();
                    reader2.Read();
                    reader2.Close();
                    SqlCommand cmd2 = new SqlCommand("update emergencycase set em_description=' " + ec.Rows[count][1] + "',pat_name='" + ec.Rows[count][2] + "',doc_name='" + ec.Rows[count][3] + "' where ec_num=" + ec.Rows[0][0], con);
                    cmd2.CommandType = CommandType.Text;
                   SqlDataReader reader4 = cmd.ExecuteReader();
                   reader4.Read();
                   reader4.Close();
                   SqlCommand cmd3 = new SqlCommand("delete from emergencycase where  ec_num=" + ec.Rows[count][0], con);
                   cmd3.CommandType = CommandType.Text;
                   SqlDataReader reader3 = cmd.ExecuteReader();
                   reader3.Read();
                   reader3.Close();
                    con.Close();
                    //DataTable temp=new DataTable();
                    //DataRow row2 = ec.Rows[count];

                    //temp.Columns.Add("em__description");
                    //temp.Columns.Add("pat__name");
                    //temp.Columns.Add("doc__name");
                    //row2 = temp.NewRow();
                    //temp.Rows.Add(row2);

                    //ec.Rows[count][1] = ec.Rows[0][1];
                    //ec.Rows[count][2] = ec.Rows[0][2]; 
                    //ec.Rows[count][3] = ec.Rows[0][3];
                    //ec.Rows[0][1] = temp.Rows[0][0];
                    //ec.Rows[0][2] = temp.Rows[0][1];
                    //ec.Rows[0][3] = temp.Rows[0][2];
                    break;

                }
                count++;
            }
           
        
        }
            

        private void top_button_Click(object sender, EventArgs e)
        {
            swap(emergency_case);
            MessageBox.Show("Swaped");
           

        }
    }
}
