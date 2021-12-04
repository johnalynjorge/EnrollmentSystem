using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class MainMenu : Form
    {
        static int formnum = 1;
        studentmenu st;
        coursemenu cm;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            closeForm();
            st = new studentmenu();
            st.TopLevel = false;
            st.AutoScroll = true;
            st.FormBorderStyle = FormBorderStyle.None;
            st.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(st);
            st.Show();
            setFormNum(1);
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                login log = new login();
                log.ShowDialog();
                this.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            st = new studentmenu();
            st.TopLevel = false;
            st.AutoScroll = true;
            st.FormBorderStyle = FormBorderStyle.None;
            st.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(st);
            st.Show();
        }

        private void CourseMngt_Click(object sender, EventArgs e)
        {
            mainpanel.Controls.Clear();
            closeForm();
            cm = new coursemenu();
            cm.TopLevel = false;
            cm.AutoScroll = true;
            cm.FormBorderStyle = FormBorderStyle.None;
            cm.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(cm);
            cm.Show();
            setFormNum(2);
        }
        public void closeForm()
        {
            if (formnum == 1)
            {
                st.Close();
            }
            else if (formnum == 2)
            {
                cm.Close();
            }
        }

        public void setFormNum(int value)
        {
            formnum = value;
        }
        

    }
    
}
