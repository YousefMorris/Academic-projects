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
    public partial class view_patient : Form
    {
        public string pat_name = "";
        public view_patient(string patname)
        {
            InitializeComponent();
            pat_name = patname;
            pat_name.ToCharArray();
        }
        
        private void search_button_Click(object sender, EventArgs e)
        {
            
            choose c = new choose(search_textBox.Text,pat_name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                 c.WindowState = FormWindowState.Maximized;
            }
            c.Show();
            this.Hide();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            emergency_case em = new emergency_case(pat_name);
            em.Show();
        }
        
        public void search_doctor()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
             con.Open();
             SqlCommand cmd = new SqlCommand("select * from search__doctor('" + search_textBox.Text + "')", con);

            cmd.CommandType=CommandType.Text;
            SqlDataReader re = cmd.ExecuteReader();
            DataTable table=new DataTable();
            DataRow row;
            table.Columns.Add("doc_name");
            table.Columns.Add("doc_master");
            table.Columns.Add("doc_email");
            table.Columns.Add("doc_phonePatient");
            
            while (re.Read())
            {
                row = table.NewRow();
                row["doc_name"] = re["doc_name"];
                row["doc_master"] = re["doc_master"];
                row["doc_email"] = re["doc_email"];
                row["doc_phonePatient"] = re["doc_phonePatient"];
                table.Rows.Add(row);
            }
            re.Close();
            con.Close();
            int cnt = 0;
            
            foreach (DataRow r in table.Rows)
            {
                //search_comboBox.Items.Add(table.Rows[cnt][0]);

                search_textBox.AutoCompleteCustomSource.Add(table.Rows[cnt][0].ToString());
                
                cnt++;
            }
        }

        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            search_doctor();
        }
        
        
    }
}
