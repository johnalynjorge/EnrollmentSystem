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
    public partial class sectionmenu : Form
    {
        checkDB checker = new checkDB();
        formFuncs f = new formFuncs();
        char letter = 'A';
        static string curr, section;
        public sectionmenu()
        {
            InitializeComponent();
        }

        private void sectionmenu_Load(object sender, EventArgs e)
        {
            DisplayCurr();
            DisplaySections();
        }
        public void DisplayCurr()
        {
            try
            {
                dataGridViewcurr.DataSource = checker.DisplayCurr().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewcurr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempValCurr(e);
            }
        }
        public void getTempValCurr(DataGridViewCellEventArgs e)
        {
            curr = dataGridViewcurr.Rows[e.RowIndex].Cells[0].Value.ToString();
            addbtn.Enabled = true;
            clearbtn.Enabled = true;
            curriculumtxt.Text = curr;

            while (checker.IfSectionExist(curr+letter))
            {
                letter++;
            }
            section = curr + letter;
            sectiontxt.Text = section;
        }
        public void clearData()
        {
            f.ClearTextboxes(this.Controls);
            addbtn.Enabled = false;
            clearbtn.Enabled = false;
            editbtn.Enabled = false;
            deletebtn.Enabled = false;
            DisplayCurr();
            DisplaySections();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                checker.AddSection(section, curr);
                MessageBox.Show("Section created successfully.", "Section Created");
                clearData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the section '" + sectiontxt.Text + "' ?", "Delete Section?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.DeleteSection(sectiontxt.Text);
                    MessageBox.Show("Section deleted successfully.", "Section Deleted");
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridViewsetion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempValSection(e);
            }
        }
        public void getTempValSection(DataGridViewCellEventArgs e)
        {
            sectiontxt.Text = dataGridViewsetion.Rows[e.RowIndex].Cells[0].Value.ToString();
            curriculumtxt.Text = dataGridViewsetion.Rows[e.RowIndex].Cells[1].Value.ToString();
            deletebtn.Enabled = true;
            clearbtn.Enabled = true;

        }

        private void searchcurrtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchcurrtxt.Text.Trim();
                dataGridViewcurr.DataSource = checker.SearchCurr(sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchsecttxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchsecttxt.Text.Trim();
                dataGridViewsetion.DataSource = checker.SearchSection(sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplaySections()
        {
            try
            {
                dataGridViewsetion.DataSource = checker.DisplaySections().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
