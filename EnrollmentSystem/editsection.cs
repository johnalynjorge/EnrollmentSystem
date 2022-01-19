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
    public partial class editsection : Form
    {
        string section;
        string[] values;
        checkDB checker = new checkDB();
        formFuncs func = new formFuncs();
        int num;
        public editsection(string section)
        {
            InitializeComponent();
            this.section = section;
        }

        private void editsection_Load(object sender, EventArgs e)
        {
            try
            {
                values = (string[])checker.returnSection(section);
                sectiontxt.Text = values[0];
                Currrcb.Text = values[1];
                coursecb.Text = values[2];
                ylcb.Text = values[3];
                semcb.Text = values[4];
                numtxt.Text = values[5];
                num = Convert.ToInt32(values[5]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisplayStudents();
            DisplayAlreadyAdded();
            func.enableShow(clearbtn);
            func.disableHide(deletebtn);
            func.disableHide(addbtn);
        }
        public void DisplayStudents()
        {
            try
            {
                dataGridViewstudents.DataSource = checker.DisplayStudentS(values[1], values[2], values[3], values[4]).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayAlreadyAdded()
        {
            try
            {
                dataGridViewAddedSt.DataSource = checker.DisplayAddedStudents(values[0]).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchtxt.Text.Trim();
                dataGridViewstudents.DataSource = checker.SearchStudentSec(sc, values[1], values[2], values[3], values[4]).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewstudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempStudent(e);
            }
        }
        public void getTempStudent(DataGridViewCellEventArgs e)
        {

            idtxt.Text = dataGridViewstudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxt.Text = dataGridViewstudents.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridViewstudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            func.enableShow(clearbtn);
            func.disableHide(deletebtn);
            func.enableShow(addbtn);
        }
        public void ClearData()
        {
            idtxt.Text = "";
            nametxt.Text = "";
            func.enableShow(clearbtn);
            func.disableHide(deletebtn);
            func.disableHide(addbtn);
            DisplayStudents();
            DisplayAlreadyAdded();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridViewAddedSt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempStudentAlready(e);
            }
        }
        public void getTempStudentAlready(DataGridViewCellEventArgs e)
        {

            idtxt.Text = dataGridViewAddedSt.Rows[e.RowIndex].Cells[0].Value.ToString();
            nametxt.Text = dataGridViewAddedSt.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridViewAddedSt.Rows[e.RowIndex].Cells[2].Value.ToString();
            func.enableShow(clearbtn);
            func.enableShow(deletebtn);
            func.disableHide(addbtn);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checker.IfStudentAlreadyInSection(idtxt.Text))
                {
                    MessageBox.Show("Student already added in a section.", "Student Already added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearData();
                }
                else
                {
                    checker.AddStudentSection(sectiontxt.Text,idtxt.Text);
                    num++;
                    checker.EditNumStudents(sectiontxt.Text, num);
                    numtxt.Text = num.ToString();
                    MessageBox.Show("Student added successfully.", "Student added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove the student '"+ idtxt.Text+ " from " + sectiontxt.Text + "' ?", "Remove Student?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.RemoveFromSection(sectiontxt.Text,idtxt.Text);
                    num--;
                    checker.EditNumStudents(sectiontxt.Text, num);
                    numtxt.Text = num.ToString();
                    MessageBox.Show("Student removed successfully.", "Student removed",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void searchalready_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchalready.Text.Trim();
                dataGridViewAddedSt.DataSource = checker.SearchAddedStudents(sectiontxt.Text,sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
