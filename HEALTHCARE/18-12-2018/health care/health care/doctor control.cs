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
    public partial class doctor_control : Form
    {
        public string name = "";
        public doctor_control(string docname)
        {
            InitializeComponent();
            name = docname;
        }



        private void show_EC_Click(object sender, EventArgs e)
        {
           
            var m = new view_ECS(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                m.WindowState = FormWindowState.Maximized;
            }
            m.Show();
            this.Hide();
           
        }
        

        
      
        private void reply_Click(object sender, EventArgs e)
        {
            var n = new reply(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                n.WindowState = FormWindowState.Maximized;
            }
            n.Show();
            this.Hide();
        }

        private void view_patients_Click(object sender, EventArgs e)
        {
            var k = new view_appointments(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                k.WindowState = FormWindowState.Maximized;
            }
            k.Show();
            this.Hide();
        }

        private void update_Click(object sender, EventArgs e)
        {
            var m = new update_work_hours(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                m.WindowState = FormWindowState.Maximized;
            }
            m.Show();
            this.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new view_patients(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                m.WindowState = FormWindowState.Maximized;
            }
            m.Show();
            this.Hide();
            
        }

        private void show_requests_Click(object sender, EventArgs e)
        {
            patient_requests p = new patient_requests(name);
            if (this.WindowState == FormWindowState.Maximized)
            {
                p.WindowState = FormWindowState.Maximized;
            }
            p.Show();
            this.Hide();
        }
    }
}
