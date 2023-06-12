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
    public partial class reply : Form
    {
        public string name = "";
        public reply(string docname)
        {
            InitializeComponent();
            fillComboBox();
            name = docname;
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ME05R0P;Initial Catalog=health care;Integrated Security=True");
        void fillComboBox()
        {
            string quary = "select pat_name from Questions";
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["pat_name"]);
            }
            reader.Close();
            con.Close();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sendButton.Visible = true;
            answer.Visible = true;
            label1.Visible = true;
        }

        private void viewQuestionButton_Click(object sender, EventArgs e)
        {
                
            string quary = "select que_question from Questions where pat_name like '" + comboBox1.Text + "'" ;
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                apperance.Text = reader["que_question"].ToString() ;
            }
                reader.Close();
                con.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string quary = "update  Questions set que_response = '"+ answer.Text + "' where pat_name like '" + comboBox1.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Answer Send");
        }

        private void back_button1_Click(object sender, EventArgs e)
        {
            doctor_control n = new doctor_control(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                n.WindowState = FormWindowState.Maximized;
            }
            n.Show();
            this.Hide();
        }   
    }
}
