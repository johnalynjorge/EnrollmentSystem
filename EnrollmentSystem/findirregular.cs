using System;
using System.Collections;
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
    public partial class findirregular : Form
    {
        checkDB checker = new checkDB();
        formFuncs funcs = new formFuncs();
        ArrayList arrayList = new ArrayList();
        string[] studentvalues, instructorvalues, schedvalues;
        string section, id;

        public findirregular()
        {
            InitializeComponent();
        }

        private void findirregular_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dset in checker.FillIrregular().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                studentcb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
                foreach (DataRow dset in checker.FillInstructor().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                inscb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
                arrayList.Clear();
                foreach (DataRow dset in checker.FillAllSubjects().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                subjectcb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            daycb.Items.AddRange((object[])funcs.DaysValues());
            typecb.Items.AddRange((object[])funcs.TypeValues());
            funcs.disableHide(createbtn);
            funcs.disableHide(deletebtn);
            DisplayData();
            
        }
        public void DisplayData()
        {
            try
            {
                dataGridViewsched.DataSource = checker.DisplaySched().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayData2()
        {
            try
            {
                dataGridViewirregsched.DataSource = checker.DisplayIrregSched(studentcb.SelectedItem.ToString()).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentcb.SelectedItem != null)
            {
                try
                {
                    studentvalues = (string[])checker.returnStudentName(studentcb.SelectedItem.ToString());
                    studentnametxt.Text = studentvalues[0] + " " + studentvalues[1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DisplayData2();
            }
        }

        
        public void getTempVal(DataGridViewCellEventArgs e)
        {
            section = dataGridViewsched.Rows[e.RowIndex].Cells[0].Value.ToString();
            subjectcb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[1].Value.ToString();
            inscb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[2].Value.ToString();
            daycb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[3].Value.ToString();
            starttime.Text = dataGridViewsched.Rows[e.RowIndex].Cells[4].Value.ToString();
            endtime.Text = dataGridViewsched.Rows[e.RowIndex].Cells[5].Value.ToString();
            roomtxt.Text = dataGridViewsched.Rows[e.RowIndex].Cells[6].Value.ToString();
            typecb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[7].Value.ToString();
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.enableShow(createbtn);
        }


       

        private void subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectcb.SelectedItem != null)
            {
                try
                {
                    subjectn.Text = checker.returnSubjectName(subjectcb.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            Cleardata();
            dataGridViewirregsched.DataSource = null;
        }

        private void dataGridViewsched_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }

        private void dataGridViewirregsched_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal2(e);
            }
        }

        private void getTempVal2(DataGridViewCellEventArgs e)
        {
            studentcb.SelectedItem = dataGridViewirregsched.Rows[e.RowIndex].Cells[0].Value.ToString();
            section = dataGridViewirregsched.Rows[e.RowIndex].Cells[1].Value.ToString();
            subjectcb.SelectedItem= dataGridViewirregsched.Rows[e.RowIndex].Cells[2].Value.ToString();
            typecb.SelectedItem = dataGridViewirregsched.Rows[e.RowIndex].Cells[3].Value.ToString();

            try
            {
                schedvalues = (string[])checker.returnSchedule(section, subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString());
                inscb.SelectedItem = schedvalues[2];
                daycb.SelectedItem = schedvalues[3];
                starttime.Text= schedvalues[4];
                endtime.Text = schedvalues[5];
                roomtxt.Text = schedvalues[6];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            funcs.enableShow(deletebtn);
            funcs.disableHide(createbtn);
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            id = studentcb.SelectedItem.ToString();
            if (studentcb.SelectedItem == null)
            {
                MessageBox.Show("Pick an irregualr student for this schedule", "Pick a student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checker.IfIrregSchedExist(studentcb.SelectedItem.ToString(), subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString()))
            {
                MessageBox.Show("The schedule for that student already exist.", "Schedule Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    checker.AddIrregSched(studentcb.SelectedItem.ToString(), section, subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString());
                    MessageBox.Show("Student added to the schedule successfully", "Student Added To SChedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cleardata();
                    studentcb.SelectedItem = id;
                    DisplayData2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            id = studentcb.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Do you want to delete the schedule for '" + studentcb.SelectedItem.ToString() + " / " +
               subjectcb.SelectedItem.ToString() + " / " + typecb.SelectedItem.ToString() + "'?\nThis action cannot be undone.", "Delete Schedule?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.DeleteIrregSched(studentcb.SelectedItem.ToString(), subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString());
                    MessageBox.Show("Schedule deleted successfully.", "Schedule Deleted", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    Cleardata();
                    studentcb.SelectedItem = id;
                    DisplayData2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void inscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inscb.SelectedItem != null)
            {
                try
                {
                    instructorvalues = (string[])checker.returnInstructor(inscb.SelectedItem.ToString());
                    instxt.Text = instructorvalues[1] + " " + instructorvalues[2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Cleardata()
        {
            funcs.ClearCombobox(this.Controls);
            funcs.ClearTextboxes(this.Controls);
            funcs.disableHide(createbtn);
            funcs.disableHide(deletebtn);
            DisplayData();
        }
    }
}
