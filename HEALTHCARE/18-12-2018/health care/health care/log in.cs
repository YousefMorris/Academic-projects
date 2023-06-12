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
    public partial class logIN_form : Form
    {
        public logIN_form()
        {
            InitializeComponent();
        }

        private void username_textbox(object sender, EventArgs e)
        {
            TextBox d = (TextBox)sender;
            d.Text = string.Empty;
            d.ForeColor = System.Drawing.SystemColors.WindowText;
            
        }

        private void password_textbox(object sender, EventArgs e)
        {
            password_textBox2.Text= string.Empty;
            this.password_textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.password_textBox2.PasswordChar = '♫';
        }
        public create_patient c = new create_patient();
        private void create_linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                c.WindowState = FormWindowState.Maximized;
            }
            
            c.Show();
          
            this.Hide();
            
            
            
        }


        public void check_user()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("select doc_name, doc_password  from Doctors ;", con);
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            DataTable Doc = new DataTable();
            Doc.Columns.Add("doc_Password");
            Doc.Columns.Add("doc_name");
            DataRow row;
            bool isDoctor = false;
            bool isPatient = false;
            bool isAdmin = false;
            while (reader.Read())
            {
                row = Doc.NewRow();
                row["doc_Password"] = reader["doc_password"];
                row["doc_name"] = reader["doc_name"];
                Doc.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            int count2 = 0;
            foreach (DataRow r in Doc.Rows)
            {
                if (Doc.Rows[count2][0].ToString() == password_textBox2.Text && Doc.Rows[count2][1].ToString() == username_textBox1.Text)
                {
                   
                    isDoctor = true;
                   
                }
                count2++;
            }
            
            if (isDoctor==false)
            {
                con.Open();
                SqlCommand command2 = new SqlCommand("select pat_name ,pat_password  from patients ;", con);
                command2.CommandType = CommandType.Text;
                SqlDataReader reader2 = command2.ExecuteReader();
                DataTable pat = new DataTable();
                pat.Columns.Add("pat_name");
                pat.Columns.Add("pat_Password");
                DataRow Patrow;
                while (reader2.Read())
                {
                    Patrow = pat.NewRow();
                    Patrow["pat_Password"] = reader2["pat_password"];
                    Patrow["pat_name"] = reader2["pat_name"];
                    pat.Rows.Add(Patrow);
                }
                reader.Close();
                con.Close();
                int count = 0;
                foreach (DataRow r in pat.Rows )
                {

                    if (pat.Rows[count][1].ToString() == password_textBox2.Text && pat.Rows[count][0].ToString() == username_textBox1.Text)
                    {

                        isPatient = true;

                    }
                    count++;
                }
            }
             if (isPatient ==false && isDoctor==false)
            {
                con.Open();
                SqlCommand command2 = new SqlCommand("select adm_password , adm_name from admin ;", con);
                command2.CommandType = CommandType.Text;
                SqlDataReader reader2 = command2.ExecuteReader();
                DataTable ADM = new DataTable();
                ADM.Columns.Add("Password");
                ADM.Columns.Add("adm_name");
                DataRow ADMrow;
               
                while (reader2.Read())
                {
                    ADMrow = ADM.NewRow();
                    ADMrow["password"] = reader2["adm_password"];
                    ADMrow["adm_name"] = reader2["adm_name"];
                    ADM.Rows.Add(ADMrow);
                  
                }
                reader.Close();
                con.Close();
                int count3 = 0;
                foreach (DataRow r in ADM.Rows )
                {
                  
                    if (ADM.Rows[count3][0].ToString() == password_textBox2.Text && ADM.Rows[count3][1].ToString() == username_textBox1.Text)
                    {
                        isAdmin = true;
                    }
                    count3++;
                }
            }
          
            //else
            //{
             //   incorrect_lable.Visible = true;
            //}
            if (isDoctor)
            {
                doctor_control d = new doctor_control(username_textBox1.Text);
                if (this.WindowState == FormWindowState.Maximized)
                {
                    d.WindowState = FormWindowState.Maximized;
                }
                d.Show();
                this.Hide();
            }
            else if (isPatient)
            {
                view_patient p = new view_patient(username_textBox1.Text);
                if (this.WindowState == FormWindowState.Maximized)
                {
                    p.WindowState = FormWindowState.Maximized;
                }
                p.Show();
                this.Hide();
            }
            else if(isAdmin)
            {
                Admin a = new Admin();
                if (this.WindowState == FormWindowState.Maximized)
                {
                    a.WindowState = FormWindowState.Maximized;
                }
                a.Show();
                this.Hide();
            }
            else
            {
                incorrect_label.Visible = true;
            }
        }
        private void login_button1_Click(object sender, EventArgs e)
        {
            check_user();
          
        }

        private void password_textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
