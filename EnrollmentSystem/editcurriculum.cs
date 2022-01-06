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
        string[] values;
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
            DisplayCurSub();
            string[] yls = { "First Year", "Second  Year", "Third Year", "Fourth Year" };
            ylcb.Items.AddRange(yls);

            string[] sems = { "First Sem", "Second Sem" };
            semcb.Items.AddRange(sems);
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
            f.disableHide(clearbtn);
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
                dataGridViewAddedSub.DataSource = checker.DisplayCurrSub(currcode).DefaultView;
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
            f.disableHide(clearbtn);
            f.disableHide(deletebtn);
            f.disableHide(addbtn);
            DisplaySubs();
            DisplayCurSub();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
            coursecb.SelectedItem = null;
            totalunits.Text = null;
            required.Text = null;
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
                if (checker.IfSubCurrExist(currcode, sctxt.Text))
                {
                    MessageBox.Show("Subject is already added to the curriculum.", "Subject already added");
                }
                else if (coursecb.SelectedItem == null || ylcb.SelectedItem == null || semcb.SelectedItem == null)
                {
                    MessageBox.Show("Empty fields.", "Missing Information");
                }
                else
                {
                    checker.AddCurrSub(currcode,coursecb.SelectedItem.ToString(), sctxt.Text, ylcb.SelectedItem.ToString(), semcb.SelectedItem.ToString());
                    MessageBox.Show("Subject added successfully.", "Subject Added");
                    ClearData();
                    ComputeUnits();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove the subject '" + sctxt.Text + "' ?", "Remove Subject?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.RemoveSubCurr(currcode, sctxt.Text, coursecb.SelectedItem.ToString());
                    MessageBox.Show("Subject removed successfully.", "Subject Removed");
                    ClearData();
                    ComputeUnits();
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
                dataGridViewAddedSub.DataSource = checker.SearchCurrSub(sc, currcode).DefaultView;

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
            if (coursecb.SelectedItem != null)
            {
                required.Text = checker.returnCourseUnits(coursecb.SelectedItem.ToString());
                ComputeUnits();
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
        }

        
    }
}
