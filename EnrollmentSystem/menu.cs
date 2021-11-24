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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

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

        private void StudentMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentmenu sm = new studentmenu();
            sm.ShowDialog();
            this.Close();
        }

        private void CourseMngt_Click(object sender, EventArgs e)
        {
            this.Hide();
            coursemenu cm = new coursemenu();
            cm.ShowDialog();
            this.Close();
        }
    }
}
