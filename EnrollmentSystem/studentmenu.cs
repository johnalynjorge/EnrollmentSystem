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
    public partial class studentmenu : Form
    {
        string cs = @"Data Source=DESKTOP-3K8PAME\SQLEXPRESS;Initial Catalog=EnrollmentSystemDB;Integrated Security=True";
        public studentmenu()
        {
            InitializeComponent();
        }

        private void studentmenu_Load(object sender, EventArgs e)
        {
            SYcb.Items.Add("2021-2022");
            SYcb.Items.Add("2022-2023");

            YLcb.Items.Add("First Year");
            YLcb.Items.Add("Second  Year");
            YLcb.Items.Add("Third Year");
            YLcb.Items.Add("Fourth Year");

            semcb.Items.Add("First Sem");
            semcb.Items.Add("Second Sem");

            Statuscb.Items.Add("Regular");
            Statuscb.Items.Add("Irregular");

            Gendercb.Items.Add("Male");
            Gendercb.Items.Add("Female");

            try
            {
                //Course add
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string comm = "SELECT [Course Code] FROM tbl_course";
                SqlCommand cmd = new SqlCommand(comm, con);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    Coursecb.Items.Add(DR[0]);

                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.ShowDialog();
            this.Close();
        }
    }
}
