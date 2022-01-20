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
    public partial class editcurriculum : Form
    {
        checkDB checker = new checkDB();
        formFuncs f = new formFuncs();
        ArrayList arraylist = new ArrayList();
        string currcode;
        double units;
        
        public editcurriculum(string currcodes)
        {
            InitializeComponent();
            this.currcode = currcodes;
        }

        private void editcurriculum_Load(object sender, EventArgs e)
        {
            curriculumcodetxt.Text = currcode;
            DisplaySubs();
            
            try
            {
                foreach (DataRow dset in checker.FillCourse().Rows)
                {
                    arraylist.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                coursecb.Items.AddRange(arraylist.ToArray());
                arraylist.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.disableHide(addbtn);
        }
        public void ComputeUnits()
        {
            totalunits.Text = checker.returnCurrSum(currcode,coursecb.SelectedItem.ToString()).ToString();
        }
        public void DisplaySubs()
        {
            try
            {
                dataGridViewsubs.DataSource = checker.DisplaySubjects().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayCurSub()
        {
            try
            {
                dataGridViewAddedSub.DataSource = checker.DisplayCurrSub(currcode, coursecb.SelectedItem.ToString()).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getTempValSubs(DataGridViewCellEventArgs e)
        {
            sctxt.Text = dataGridViewsubs.Rows[e.RowIndex].Cells[0].Value.ToString();
            sntxt.Text = dataGridViewsubs.Rows[e.RowIndex].Cells[1].Value.ToString();
            units = Convert.ToDouble(dataGridViewsubs.Rows[e.RowIndex].Cells[2].Value.ToString());
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.enableShow(addbtn);
            semcb.SelectedItem = null;
            ylcb.SelectedItem = null;
            EnableCombos();
        }

        private void dataGridViewsubs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempValSubs(e);
            }
        }
        public void ClearData()
        {
            sntxt.Clear();
            sctxt.Clear();
            semcb.SelectedItem = null;
            ylcb.SelectedItem = null;
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.disableHide(addbtn);
            DisplaySubs();
            EnableCombos();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
            coursecb.SelectedItem = null;
            totalunits.Text = null;
            required.Text = null;
            required.BackColor = Color.White;
            totalunits.BackColor = Color.White;
            dataGridViewAddedSub.DataSource = null; 
        }

        private void dataGridViewAddedSub_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempValAddedSubs(e);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checker.IfSubCurrExist(currcode, sctxt.Text, coursecb.SelectedItem.ToString()))
                {
                    MessageBox.Show("Subject is already added to the curriculum.", "Subject already added",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (coursecb.SelectedItem == null || ylcb.SelectedItem == null || semcb.SelectedItem == null)
                {
                    MessageBox.Show("Some fields are missing information. ", "Missing Information", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                else
                {
                    string courses = coursecb.SelectedItem.ToString();
                    checker.AddCurrSub(currcode,coursecb.SelectedItem.ToString(), sctxt.Text, ylcb.SelectedItem.ToString(), semcb.SelectedItem.ToString());
                    MessageBox.Show("Subject added successfully.", "Subject Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    coursecb.SelectedItem = courses;
                    ComputeUnits();
                    checkUnits();
                    DisplayCurSub();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove the subject '" + sctxt.Text + "' ?", "Remove Subject?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                   if (checker.IfScheduleForSubject(sctxt.Text))
                    {
                        MessageBox.Show("Cannot remove the subject beacause there is a schedule set for this subject.", "Cannot Remove Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string courses = coursecb.SelectedItem.ToString();
                        checker.RemoveSubCurr(currcode, sctxt.Text, coursecb.SelectedItem.ToString());
                        MessageBox.Show("Subject removed successfully.", "Subject Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        coursecb.SelectedItem = courses;
                        ComputeUnits();
                        checkUnits();
                        DisplayCurSub();
                        EnableCombos();
                    }
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
                dataGridViewAddedSub.DataSource = checker.SearchCurrSub(sc, currcode, coursecb.SelectedItem.ToString()).DefaultView;

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
                dataGridViewsubs.DataSource = checker.SearchSubject(sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courcecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ylcb.Items.Clear();
            semcb.Items.Clear();
            ylcb.DropDownHeight = 106;
            semcb.DropDownHeight = 106;
            if (coursecb.SelectedItem != null)
            {
                required.Text = checker.returnCourseUnits(coursecb.SelectedItem.ToString());
                ComputeUnits();
                    try
                    {
                        ylcb.Items.AddRange(f.ReturnYearLevel(checker.ReturnCourseYears(coursecb.SelectedItem.ToString())).ToArray());
                        semcb.Items.AddRange(f.ReturnSems(checker.ReturnCourseSems(coursecb.SelectedItem.ToString())).ToArray());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                checkUnits();
                DisplayCurSub();
                
            }
        }

        private void sctxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sntxt.Text = checker.returnSubjectName(sctxt.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getTempValAddedSubs(DataGridViewCellEventArgs e)
        {
            coursecb.SelectedItem = dataGridViewAddedSub.Rows[e.RowIndex].Cells[1].Value.ToString();
            sctxt.Text = dataGridViewAddedSub.Rows[e.RowIndex].Cells[2].Value.ToString();
            ylcb.SelectedItem = dataGridViewAddedSub.Rows[e.RowIndex].Cells[3].Value.ToString();
            semcb.SelectedItem = dataGridViewAddedSub.Rows[e.RowIndex].Cells[4].Value.ToString();
            f.enableShow(clearbtn);
            f.enableShow(deletebtn);
            f.disableHide(addbtn);
            coursecb.Enabled = false;
            ylcb.Enabled = false;
            semcb.Enabled = false;
        }

        public void checkUnits()
        {
            if (required.Text == totalunits.Text)
            {
                required.BackColor = Color.FromArgb(68, 203, 191);
                totalunits.BackColor = Color.FromArgb(68, 203, 191); 
            }
            else
            {
                required.BackColor = Color.FromArgb(255, 140, 130);
                totalunits.BackColor = Color.FromArgb(255, 140, 130);
            }
        }
        private void EnableCombos()
        {
            coursecb.Enabled = true;
            ylcb.Enabled = true;
            semcb.Enabled = true;
        }
    }
}
