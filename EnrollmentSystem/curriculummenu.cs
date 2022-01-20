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
        static string finalcurrcode;
        checkDB checker = new checkDB();
        formFuncs funcs = new formFuncs();
        editcurriculum editor;
        static string tempcur;
        public curriculummenu()
        {
            InitializeComponent();
        }

        private void curriculummenu_Load(object sender, EventArgs e)
        {
            start.Items.AddRange(funcs.Schoolyear().ToArray());
            end.Items.AddRange(funcs.Schoolyear().ToArray());
            clearData();
        }

        private void Coursecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (end.SelectedItem!= null)
            {
                start.SelectedItem = Convert.ToInt32(end.SelectedItem.ToString()) - 1;
            }
        }
        private void start_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start.SelectedItem != null)
            {
                end.SelectedItem = Convert.ToInt32(start.SelectedItem.ToString()) + 1;
            }

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if ((end.SelectedItem ==  null) || (start.SelectedItem == null))
            {
                MessageBox.Show("Please check all the information you entered.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (end.SelectedIndex == 0)
            {
                MessageBox.Show("Please choose another end year", "Invalid Year",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (checker.IfCurrCodeExist(start.SelectedItem.ToString() + "-" + end.SelectedItem.ToString()))
            {
                MessageBox.Show("The curriculum already exist.", "Already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    finalcurrcode = start.SelectedItem.ToString() + "-" + end.SelectedItem.ToString();
                    checker.CreateCurr(finalcurrcode);
                    MessageBox.Show("Curriculum created successfully.", "Curriculum Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult result = MessageBox.Show("Do you want to delete the curriculum '" + tempcur + "'?\nThis action cannot be undone. ", "Delete Curriculum?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
               try
                   {
                    if (checker.IfStudentSchoolYear(tempcur)|| checker.IfSectionSchoolYear(tempcur))
                    {
                        MessageBox.Show("Cannot delete the curriculum, either there is a student enrolled in this curriculum or there is a section under this curriculum.",
                            "Cannot Delete Curriculum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        checker.DeleteCurr(tempcur);
                        checker.DeleteSchoolYearonEdit(tempcur);
                        MessageBox.Show("Curriculum deleted successfully.", "Curriculum Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearData();
                    }
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
            editor = new editcurriculum(start.SelectedItem.ToString() + "-" + end.SelectedItem.ToString());
            editor.ShowDialog();
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
            tempcur = "";
            finalcurrcode = "";
            funcs.ClearCombobox(this.Controls);
            start.Enabled = true;
            end.Enabled = true;
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.disableHide(editbtn);
            funcs.enableShow(createbtn);
            DisplayData();
        }

        private void dataGridViewcurr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }

        }   

        public void getTempVal(DataGridViewCellEventArgs e)
        {
            tempcur = dataGridViewcurr.Rows[e.RowIndex].Cells[0].Value.ToString();
            funcs.enableShow(clearbtn);
            funcs.enableShow(deletebtn);
            funcs.enableShow(editbtn);
            funcs.disableHide(createbtn);
            start.Text = tempcur.Substring(0, 4);
            end.Text = tempcur.Substring(5, 4);
            end.Enabled = false;
            start.Enabled = false;

        }
    }
}
