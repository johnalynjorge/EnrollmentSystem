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
    public partial class editcurriculum : Form
    {
        checkDB checker = new checkDB();
        formFuncs f = new formFuncs();
        string currcode;
        string[] values;
        double units, TotalU;
        
        public editcurriculum(string currcodes)
        {
            InitializeComponent();
            this.currcode = currcodes;
        }

        private void editcurriculum_Load(object sender, EventArgs e)
        {
            DisplaySubs();
            DisplayCurSub();
            try
            {
                values = (string[])checker.returnCurr(currcode);
                curriculumcodetxt.Text = values[0];
                coursetxt.Text = values[1];
                yeartxt.Text = values[2];
                semstxt.Text = values[3];
                TotalU = Convert.ToDouble(values[4]);
                unitstxt.Text = TotalU.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            addbtn.Enabled = true;
            clearbtn.Enabled = true;
            deletebtn.Enabled = false;
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
            addbtn.Enabled = false;
            deletebtn.Enabled = false;
            clearbtn.Enabled = false;
            DisplaySubs();
            DisplayCurSub();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
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
                else
                {
                    checker.AddCurrSub(currcode, sctxt.Text);
                    MessageBox.Show("Subject added successfully.", "Subject Added");
                    ClearData();
                    TotalU += units;
                    checker.EditCurrUnits(currcode, TotalU);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            unitstxt.Text = TotalU.ToString();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove the subject '" + sctxt.Text + "' ?", "Remove Subject?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.RemoveSubCurr(currcode, sctxt.Text);
                    MessageBox.Show("Subject removed successfully.", "Subject Removed");
                    ClearData();
                    TotalU -= units;
                    checker.EditCurrUnits(currcode, TotalU);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                unitstxt.Text = TotalU.ToString();
            }
        }

        private void searchalready_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchalready.Text.Trim();
                dataGridViewAddedSub.DataSource = checker.SearchCurrSub(sc).DefaultView;

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

        public void getTempValAddedSubs(DataGridViewCellEventArgs e)
        {
            sctxt.Text = dataGridViewAddedSub.Rows[e.RowIndex].Cells[0].Value.ToString();
            sntxt.Text = dataGridViewAddedSub.Rows[e.RowIndex].Cells[1].Value.ToString();
            units = Convert.ToDouble(dataGridViewAddedSub.Rows[e.RowIndex].Cells[2].Value.ToString());
            deletebtn.Enabled = true;
            clearbtn.Enabled = true;
            addbtn.Enabled = false;
        }
    }
}
