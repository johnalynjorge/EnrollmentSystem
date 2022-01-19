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
using System.Collections;

namespace EnrollmentSystem
{
    public partial class studentmenu : Form
    {
        checkDB checker = new checkDB();
        ArrayList arrayList = new ArrayList();
        static string STstart = "S-", finalid;
        static int STend = 1;
        bool beingEdit = false, flag = false;
        formFuncs funcs = new formFuncs();
        studentarchive sa;
        static string sy, course, sem, yl, stat;
        public studentmenu()
        {
            InitializeComponent();
        }

        private void studentmenu_Load(object sender, EventArgs e)
        {
            DisplayData();

            string[] stats = {"Regular","Irregular"};
            Statuscb.Items.AddRange(stats);

            string[] genders = {"Male","Female"}; 
            Gendercb.Items.AddRange(genders);

            try
            {
                foreach (DataRow dset in checker.FillSchoolYear().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                SYcb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.disableHide(editbtn);
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.ShowDialog();
            this.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int age;
            long contactnum;
            if (checkParts())
            {
                MessageBox.Show("Please check all information", "Missing information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                flag = false;
            }
            else if (checkAge(Convert.ToInt32(agetxt.Text)))
            {
                MessageBox.Show("Please check your birthdate.", "Invalid birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(agetxt.Text, out age)&& long.TryParse(numtxt.Text, out contactnum))
            {
                try
                {
                    checker.AddStudentMain(idtxt.Text, lasttxt.Text, firsttxt.Text, middletxt.Text, SYcb.SelectedItem.ToString(), YLcb.SelectedItem.ToString(),
                        semcb.SelectedItem.ToString(), Statuscb.SelectedItem.ToString(),Coursecb.SelectedItem.ToString(),age,Gendercb.SelectedItem.ToString(),
                        numtxt.Text, emailtxt.Text, bdaytxt.Text.ToString(),addresstxt.Text);
                    MessageBox.Show("Student added successfully.", "Student Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid age or mobile number.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void clearData()
        {
            STend = 1;
            finalid = "";
            funcs.ClearTextboxes(this.Controls);
            funcs.ClearCombobox(this.Controls);
            DisplayData();
            SYcb.Enabled = true;
            YLcb.Enabled = true;
            semcb.Enabled = true;
            Statuscb.Enabled = true;
            Coursecb.Enabled = true;
            beingEdit = false;
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.disableHide(editbtn);
            funcs.enableShow(addbtn);
        }
        public void DisplayData()
        {
            try
            {
                dataGridViewstudent.DataSource = checker.DisplayStudents().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }
        public void getTempVal(DataGridViewCellEventArgs e)
        {

            
            lasttxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            idtxt.Text= dataGridViewstudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            firsttxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            middletxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            SYcb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            Statuscb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[7].Value.ToString();
            Coursecb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[8].Value.ToString();
            YLcb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            semcb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[6].Value.ToString();
            agetxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[9].Value.ToString();
            Gendercb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[10].Value.ToString();
            numtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[11].Value.ToString();
            emailtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[12].Value.ToString();
            bdaytxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[13].Value.ToString();
            addresstxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[14].Value.ToString();
            funcs.enableShow(deletebtn);
            funcs.enableShow(editbtn);
            funcs.disableHide(addbtn);
            beingEdit = true;
            getData();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearData(); 
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the student '" + idtxt.Text + "' ?", "Delete Student?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SectionSched();
                    checker.AddStudentArchive(idtxt.Text);
                    checker.DeleteStudentMain(idtxt.Text);
                    MessageBox.Show("Student deleted successfully.\nAdded to the archive", "Student Deleted",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void SectionSched()
        {
            if (checker.IfStudentAlreadyInSection(idtxt.Text))
            {
                string section = checker.returnSectionofStudent(idtxt.Text);
                int num = checker.returnSectionNumberofStudents(section);
                checker.RemoveFromSection(section, idtxt.Text);
                num--;
                checker.EditNumStudents(section, num);
            }
            else if (checker.IfIrregStudentSched(idtxt.Text))
            {
                checker.DeleteStudentIrregular_Sched(idtxt.Text);
            }
        }

        private void archivebtn_Click(object sender, EventArgs e)
        {
            sa = new studentarchive();
            sa.ShowDialog();
            DisplayData();
        }

        private void searchsecttxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchsecttxt.Text.Trim();
                dataGridViewstudent.DataSource = checker.SearchStudent(sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SYcb_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void Coursecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            YLcb.Items.Clear();
            semcb.Items.Clear();
            YLcb.DropDownHeight = 106;
            semcb.DropDownHeight = 106;
            if (Coursecb.SelectedItem != null)
            {
                try
                {
                    YLcb.Items.AddRange(funcs.ReturnYearLevel(checker.ReturnCourseYears(Coursecb.SelectedItem.ToString())).ToArray());
                    semcb.Items.AddRange(funcs.ReturnSems(checker.ReturnCourseSems(Coursecb.SelectedItem.ToString())).ToArray());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int age;
            long contactnum;
            DialogResult result = MessageBox.Show("Do you want to save changes to the student '" + idtxt.Text + "' ?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkParts())
                {
                    MessageBox.Show("Please check all information", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                else if (checkAge(Convert.ToInt32(agetxt.Text)))
                {
                    MessageBox.Show("Please check your birthdate.", "Invalid birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (int.TryParse(agetxt.Text, out age) && long.TryParse(numtxt.Text, out contactnum))
                {
                    try
                    {
                        if ((!sy.Equals(SYcb.SelectedItem.ToString())|| !course.Equals(Coursecb.SelectedItem.ToString())||!yl.Equals(YLcb.SelectedItem.ToString())||!sem.Equals(semcb.SelectedItem.ToString())||!stat.Equals(Statuscb.SelectedItem.ToString())))
                        {
                            MessageBox.Show("There are some changes on the academic fields of the student. \n" +
                                "The student will be removed fromn the sections or schedules they belong in.", "Remove Student From Section or Schedules", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SectionSched();
                        }
                        checker.EditStudent(idtxt.Text, lasttxt.Text, firsttxt.Text, middletxt.Text, SYcb.SelectedItem.ToString(), YLcb.SelectedItem.ToString(),
                            semcb.SelectedItem.ToString(), Statuscb.SelectedItem.ToString(), Coursecb.SelectedItem.ToString(), age, Gendercb.SelectedItem.ToString(),
                            numtxt.Text, emailtxt.Text, bdaytxt.Text.ToString(), addresstxt.Text);
                        MessageBox.Show("Student edited successfully.", "Student Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid age or mobile number.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SYcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coursecb.Items.Clear();
            Coursecb.DropDownHeight = 106;
            if (SYcb.SelectedItem != null)
            {
                    foreach (DataRow dset in checker.FillSelectedCourse(SYcb.SelectedItem.ToString()).Rows)
                    {
                        arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                    }
                    Coursecb.Items.AddRange(arrayList.ToArray());
                    arrayList.Clear();
            }
        }

        private void bdaytxt_ValueChanged(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - bdaytxt.Value.Year;

            if (bdaytxt.Value.AddYears(years) > DateTime.Now) years--;
            agetxt.Text = years.ToString();
        }

        public Boolean checkParts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Name != middletxt.Name && c.Name != searchsecttxt.Name)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text.Trim() == string.Empty)
                    {
                        flag = true;
                        break;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedItem == null)
                    {
                        flag = true;
                        break;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }

        private void lasttxt_TextChanged(object sender, EventArgs e)
        {
            if (beingEdit == false)
            {
                if (lasttxt.Text.Trim() != "")
                {
                    STend = 1;
                    while (checker.IfStudentMain(STstart + STend) || checker.IfStudentArchive(STstart + STend))
                    {
                        STend++;
                    }
                    finalid = STstart + STend;
                    idtxt.Text = finalid;
                }
                else
                {
                    idtxt.Text = "";
                }
            }
        }
        private bool checkAge(int age)
        {
            if (age<=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void getData()
        {
            sy = SYcb.SelectedItem.ToString();
            course = Coursecb.SelectedItem.ToString();
            sem = semcb.SelectedItem.ToString();
            yl = YLcb.SelectedItem.ToString();
            stat = Statuscb.SelectedItem.ToString();
        }
    }
}
