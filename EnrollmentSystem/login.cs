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

namespace EnrollmentSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = '*';
            this.AcceptButton = LoginButon;
        }

        public void loggedon()
        {
            this.Hide();
            menu menuform = new menu();
            menuform.ShowDialog();
            this.Close();
        }

        private void LoginButon_Click(object sender, EventArgs e)
        {
            string username = Usernametxt.Text.Trim();
            string password = Passwordtxt.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please provide username and password.", "Login Error");
            }
            else
            {
                try
                {
                    string cs = @"Data Source=DESKTOP-3K8PAME\SQLEXPRESS;Initial Catalog=EnrollmentSystemDB;Integrated Security=True";
                    SqlConnection con = new SqlConnection(cs);
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tbl_user WHERE usernames = '" + username + "' and passwords = '" + password + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        con.Close();
                        loggedon();
                    }
                    else
                    {
                        MessageBox.Show("Please check your username and password.", "Login Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit application?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                this.Close();
            }
        }

        private void show_CheckedChanged(object sender, EventArgs e)
        {
            Passwordtxt.PasswordChar = show.Checked ? '\0' : '*';
        }
    }
}
