using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace EnrollmentSystem
{
    public partial class curriculummenu : Form
    {
        static string currcodestart;
        static int curyear = 0, cursem= 0;
        static string finalcurrcode;
        checkDB checker = new checkDB();
        ArrayList arraylist = new ArrayList();
        formFuncs funcs = new formFuncs();
        editcurriculum editor;
        static string tempcur;
        public curriculummenu()
        {
            InitializeComponent();
        }

        private void curriculummenu_Load(object sender, EventArgs e)
        {
            string[] yls = { "First Year", "Second  Year", "Third Year", "Fourth Year" };
            YLcb.Items.AddRange(yls);

            string[] sems = { "First Sem", "Second Sem" };
            semcb.Items.AddRange(sems);
            try
            {
                foreach (DataRow dset in checker.FillCourse().Rows)
                {
                    arraylist.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                Coursecb.Items.AddRange(arraylist.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clearData();
        }

        private void Coursecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Coursecb.SelectedItem != null)
            {
                currcodestart = Coursecb.SelectedItem.ToString();
                finalcurrcode = currcodestart + "-Y" + curyear + "-S" + cursem;
                curriculumcodetxt.Text = finalcurrcode;
            }
           
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if ((Coursecb.SelectedItem ==  null) || (YLcb.SelectedItem == null) || (semcb.SelectedItem == null))
            {
                MessageBox.Show("Please check all the information you entered.", "Missing Information");
            }
            else if (checker.IfCurrCodeExist(finalcurrcode))
            {
                MessageBox.Show("The curriculum already exist.", "Already exist");
            }
            else
            {
                string currc = curriculumcodetxt.Text;
                string coursec = Coursecb.SelectedItem.ToString();
                string yearC = YLcb.SelectedItem.ToString();
                string semc = semcb.SelectedItem.ToString();
                try
                {
                    checker.CreateCurr(currc, coursec, yearC, semc);
                    MessageBox.Show("Curriculum created successfully.", "Curriculum Created");
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the curriculum '" + tempcur + "' ?", "Delete Curriculum?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               try
                   {
                    checker.DeleteCurr(tempcur);
                    MessageBox.Show("Curriculum deleted successfully.", "Curriculum Deleted");
                    clearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sc = searchtxt.Text.Trim();
                dataGridViewcurr.DataSource = checker.SearchCurr(sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            editor = new editcurriculum(finalcurrcode);
            editor.Show();
        }

        private void Coursecb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        public void DisplayData()
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
        public  void clearData()
        {
            currcodestart = "";
            curyear = 0;
            cursem = 0;
            finalcurrcode = "";
            funcs.ClearTextboxes(this.Controls);
            funcs.ClearCombobox(this.Controls);
            editbtn.Enabled = false;
            deletebtn.Enabled = false;
            curriculumcodetxt.Enabled = false;
            unitstxt.Enabled = false;
            createbtn.Enabled = true;
            Coursecb.Enabled = true;
            YLcb.Enabled = true;
            semcb.Enabled = true;
            clearbtn.Enabled = false;
            DisplayData();
        }

        private void dataGridViewcurr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
           
        }

        private void semcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semcb.SelectedItem != null)
            {
                cursem = semcb.SelectedIndex + 1;
                finalcurrcode = currcodestart + "-Y" + curyear + "-S" + cursem;
                curriculumcodetxt.Text = finalcurrcode;
            }
        }

        public void getTempVal(DataGridViewCellEventArgs e)
        {
            tempcur = dataGridViewcurr.Rows[e.RowIndex].Cells[0].Value.ToString();
            Coursecb.SelectedItem = dataGridViewcurr.Rows[e.RowIndex].Cells[1].Value.ToString();
            YLcb.SelectedItem = dataGridViewcurr.Rows[e.RowIndex].Cells[2].Value.ToString();
            semcb.SelectedItem = dataGridViewcurr.Rows[e.RowIndex].Cells[3].Value.ToString();
            unitstxt.Text = dataGridViewcurr.Rows[e.RowIndex].Cells[4].Value.ToString();
            Coursecb.Enabled = false;
            YLcb.Enabled = false; 
            semcb.Enabled = false;
            createbtn.Enabled = false;
            editbtn.Enabled = true;
            deletebtn.Enabled = true;
            clearbtn.Enabled = true;
            curriculumcodetxt.Text = tempcur;
            
        }

        private void YLcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YLcb.SelectedItem != null)
            {
                curyear = YLcb.SelectedIndex + 1;
                finalcurrcode = currcodestart + "-Y" + curyear + "-S" + cursem;
                curriculumcodetxt.Text= finalcurrcode;
            }
        }
    }
}
