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
    public partial class coursemenu : Form
    {
        static string cs = @"Data Source=DESKTOP-3K8PAME\SQLEXPRESS;Initial Catalog=EnrollmentSystemDB;Integrated Security=True";
        SqlConnection con = new SqlConnection(cs);
        string tempcc, tempcn;

        public coursemenu()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.ShowDialog();
            this.Close();
        }
        

        private void coursemenu_Load(object sender, EventArgs e)
        {
            DisplayData();
            editbtn.Enabled = false;
            deletebtn.Enabled = false;

        }

        public void DisplayData()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_course", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Courses");
                dataGridViewcourse.DataSource = ds.Tables["Courses"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearData()
        {
            cctxt.Text = "";
            cntxt.Text = "";
            DisplayData();
            editbtn.Enabled = false;
            deletebtn.Enabled = false;
            addbtn.Enabled = true;
            cctxt.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string coursec = cctxt.Text.Trim();
            string coursen = cntxt.Text.Trim();

            if (coursec == "" || coursen == "")
            {
                MessageBox.Show("Please porvide course code and course name.", "Add Course Error");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbl_course ([Course Code], [Course Name]) VALUES (@ccode,@cname)", con);
                    cmd.Parameters.AddWithValue("@ccode", coursec);
                    cmd.Parameters.AddWithValue("@cname", coursen);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Course added successfully.", "Course Added");
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string coursec = cctxt.Text.Trim();
            string coursen = cntxt.Text.Trim();

            DialogResult result = MessageBox.Show("Do you want to save changes to the course '" + coursec + "' ?", "Save Changes?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (coursec == "" || coursen == "")
                {
                    MessageBox.Show("Please provide course code and course name.", "Edit Course Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE tbl_course SET [Course Code] = @ccode, [Course Name] = @cname WHERE [Course Code] = @tcode", con);
                        cmd.Parameters.AddWithValue("@ccode", coursec);
                        cmd.Parameters.AddWithValue("@cname", coursen);
                        cmd.Parameters.AddWithValue("@tcode", tempcc);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Course updated successfully.", "Course Updated");
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string coursec = cctxt.Text.Trim();
            DialogResult result = MessageBox.Show("Do you want to delete to the course '" + coursec + "' ?", "Delete Course?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (coursec == "")
                {
                    MessageBox.Show("Please provide course code to delete", "Delete Course Error");
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE tbl_course WHERE [Course Code] = @ccode", con);
                        cmd.Parameters.AddWithValue("@ccode", coursec);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Course deleted successfully.", "Course Deleted");
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchtxt.Text.Trim();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_course WHERE [Course Code] LIKE '%" + sc + "%' OR [Course Name] LIKE '%" + sc + "%'", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Courses");
            dataGridViewcourse.DataSource = ds.Tables["Courses"].DefaultView;
            con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewcourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getTempVal(e);
        }

        public void getTempVal(DataGridViewCellEventArgs e)
        {
            tempcc = dataGridViewcourse.Rows[e.RowIndex].Cells[0].Value.ToString();
            tempcn = dataGridViewcourse.Rows[e.RowIndex].Cells[1].Value.ToString();
            cctxt.Text = tempcc;
            cntxt.Text = tempcn;
            addbtn.Enabled = false;
            editbtn.Enabled = true;
            deletebtn.Enabled = true;
            cctxt.Enabled = false;
        }
    }
}
