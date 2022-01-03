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
    public partial class studentarchive : Form
    {
        checkDB checker = new checkDB();
        formFuncs funcs = new formFuncs();
        public studentarchive()
        {
            InitializeComponent();
        }

        private void studentarchive_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        public void DisplayData()
        {
            try
            {
                dataGridViewstudent.DataSource = checker.DisplayStudentA().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void getTempVal(DataGridViewCellEventArgs e)
        {

            lasttxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            idtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            firsttxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            middletxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            SYcb.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            YLcb.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            semcb.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[6].Value.ToString();
            Statuscb.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[7].Value.ToString();
            Coursecb.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[8].Value.ToString();
            agetxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[9].Value.ToString();
            Gendercb.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[10].Value.ToString();
            numtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[11].Value.ToString();
            emailtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[12].Value.ToString();
            bdaytxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[13].Value.ToString();
            addresstxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[14].Value.ToString();
            deletebtn.Enabled = true;
            clearbtn.Enabled = true;
            addbtn.Enabled = true;
        }

        private void dataGridViewstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }
        public void ClearData()
        {
            funcs.ClearCombobox2(this.Controls);
            funcs.ClearTextboxes(this.Controls);
            DisplayData();
            addbtn.Enabled = false;
            deletebtn.Enabled = false;
            clearbtn.Enabled = false;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                checker.RestoreStudent(idtxt.Text);
                checker.DeleteStudentArchive(idtxt.Text);
                MessageBox.Show("Student restored successfully.", "Student Restored");
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
            DisplayData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the student '" + idtxt.Text + "' permanently?", "Delete Student?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.DeleteStudentArchive(idtxt.Text);
                    MessageBox.Show("Student deleted permanently.", "Student Deleted");
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void searchsecttxt_TextChanged(object sender, EventArgs e)
         {
                try
                {
                    string sc = searchsecttxt.Text.Trim();
                    dataGridViewstudent.DataSource = checker.SearchStudentArchive(sc).DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

