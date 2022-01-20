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

        string tempcc;
        checkDB checker = new checkDB();
        formFuncs funcs = new formFuncs();

        public coursemenu()
        {
            InitializeComponent();
        }
        

        private void coursemenu_Load(object sender, EventArgs e)
        {
            ClearData();

        }

        public void DisplayData()
        {
            try
            {
                dataGridViewcourse.DataSource = checker.DisplayCourse().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ClearData()
        {
            funcs.ClearTextboxes(this.Controls);
            DisplayData();
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.disableHide(editbtn);
            funcs.enableShow(addbtn);
            cctxt.ReadOnly = false;
            yearstxt.ReadOnly = false;
            semstxt.ReadOnly = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string coursec = cctxt.Text.Trim();
            string coursen = cntxt.Text.Trim();
            double  rus;
            int years, sems;

            if ((int.TryParse(yearstxt.Text, out years)) && (int.TryParse(semstxt.Text, out sems)) && (double.TryParse(rutxt.Text, out rus))){
                if (coursec == "" || coursen == "")
                {
                    MessageBox.Show("Please check all the information you entered.", "Missing Information",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checker.IfCourseExist(coursec))
                {
                    MessageBox.Show("Course code already exist", "Add Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        checker.AddCourse(coursec, coursen, years,sems,rus);
                        MessageBox.Show("Course added successfully.", "Course Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please check all the information you entered.", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string coursec = cctxt.Text.Trim();
            string coursen = cntxt.Text.Trim();

            double  rus;
            int years, sems;

            if ((int.TryParse(yearstxt.Text, out years)) && (int.TryParse(semstxt.Text, out sems)) && (double.TryParse(rutxt.Text, out rus)))
            {

                DialogResult result = MessageBox.Show("Do you want to save changes to the course '" + coursec + "' ?", "Save Changes?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (coursec == "" || coursen == "")
                    {
                        MessageBox.Show("Please provide course code and course name.", "Edit Course Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            checker.EditCourse(coursec, coursen, years, sems, rus, tempcc);
                            MessageBox.Show("Course updated successfully.", "Course Updated",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please check all the information you entered.", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            string coursec = cctxt.Text.Trim();
            DialogResult result = MessageBox.Show("Do you want to delete the course '" + coursec + "'? \n" +
                "This would also delete the records of this course at the curriculum management.\nThis action cannot be undone. ", "Delete Course?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (coursec == "")
                {
                    MessageBox.Show("Please provide course code to delete", "Delete Course Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checker.IfStudentEnrolledInCourse(coursec)|| checker.IfSectionEnrolledInCourse(coursec))
                {
                    MessageBox.Show("Cannot delete course because either a student was enrolled in this course or a section is created under this course.", "Cannot Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        checker.DeleteCourse(coursec);
                        checker.DeleteCourse_Curr(coursec);
                        MessageBox.Show("Course deleted successfully.", "Course Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dataGridViewcourse.DataSource = checker.SearchCourse(sc).DefaultView;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewcourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void getTempVal(DataGridViewCellEventArgs e)
        {
            tempcc = dataGridViewcourse.Rows[e.RowIndex].Cells[0].Value.ToString();
            cntxt.Text = dataGridViewcourse.Rows[e.RowIndex].Cells[1].Value.ToString();
            yearstxt.Text = dataGridViewcourse.Rows[e.RowIndex].Cells[2].Value.ToString();
            semstxt.Text = dataGridViewcourse.Rows[e.RowIndex].Cells[3].Value.ToString();
            rutxt.Text = dataGridViewcourse.Rows[e.RowIndex].Cells[4].Value.ToString();
            cctxt.Text = tempcc;
            funcs.enableShow(clearbtn);
            funcs.enableShow(deletebtn);
            funcs.enableShow(editbtn);
            funcs.disableHide(addbtn);
            cctxt.ReadOnly = true;
            yearstxt.ReadOnly = true;
            semstxt.ReadOnly = true;
        }
        
    }
}
