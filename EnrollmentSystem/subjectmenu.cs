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
    public partial class subjectmenu : Form
    {
        static string substart;
        static int subend = 1;
        static string finalsubcode;
        checkDB checker = new checkDB();
        formFuncs funcs = new formFuncs();
        string tempsc;
        public subjectmenu()
        {
            InitializeComponent();
        }

        private void subjectmenu_Load(object sender, EventArgs e)
        {
            string[] categs = { "GE", "IT", "BM" };
            categorycb.Items.AddRange(categs);
            clearData();
        }

        private void categorycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categorycb.SelectedItem != null)
            {
                subend = 1;
                substart = categorycb.SelectedItem.ToString();
                while (checker.IfSubCodeExist(substart + "-" + subend))
                {
                    subend++;
                }
                finalsubcode = substart + "-" + subend;
                sctxt.Text = finalsubcode;
            }
        }
        public void clearData()
        {
            substart = "";
            subend = 1;
            finalsubcode = "";
            funcs.ClearTextboxes(this.Controls);
            funcs.ClearCombobox(this.Controls);
            DisplayData();
            categorycb.SelectedItem = null;
            categorycb.Enabled = true;
            sctxt.Enabled = false;
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.disableHide(editbtn);
            funcs.enableShow(addbtn);
        }

        private void categorycb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            string sn = sntxt.Text.Trim();
            string un = utxt.Text.Trim();
            if ((categorycb.SelectedItem == null) || (sn == "") || (un == ""))
            {
                MessageBox.Show("Please check all the information you entered.", "Missing Information");
            }
            else
            {
                string cat = categorycb.SelectedItem.ToString();
                double uni; 
                if (double.TryParse(un, out uni))
                {
                    try
                    {
                        checker.AddSubject(finalsubcode, sn, uni, cat);
                        MessageBox.Show("Subject added successfully.", "Subject Added");
                        clearData();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please input numbers only for Units.", "Units Error");
                }

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the subject '" + tempsc + "' ?", "Delete Subject?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.DeleteSubject(tempsc);
                    MessageBox.Show("Subject deleted successfully.", "Subject Deleted");
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string sn = sntxt.Text.Trim();
            string un = utxt.Text.Trim();
            DialogResult result = MessageBox.Show("Do you want to save changes to the subject '" + tempsc + "' ?", "Save Changes?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if ((sn == "") || (un == ""))
                {
                    MessageBox.Show("Please check all the information you entered.", "Missing Information");
                }
                else
                {
                    double uni;
                    if (double.TryParse(un, out uni))
                    {
                        try
                        {
                            checker.EditSubject(tempsc, sn, uni);
                            MessageBox.Show("Subject updated successfully.", "Subject Updated");
                            clearData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please input numbers only for Units.", "Units Error");
                    }

                }
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

        public void DisplayData()
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

        private void dataGridViewsubs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }
        public void getTempVal(DataGridViewCellEventArgs e)
        {
            tempsc = dataGridViewsubs.Rows[e.RowIndex].Cells[0].Value.ToString();
            sntxt.Text = dataGridViewsubs.Rows[e.RowIndex].Cells[1].Value.ToString();
            utxt.Text = dataGridViewsubs.Rows[e.RowIndex].Cells[2].Value.ToString();
            categorycb.SelectedItem = dataGridViewsubs.Rows[e.RowIndex].Cells[3].Value.ToString();
            sctxt.Text = tempsc;
            funcs.enableShow(clearbtn);
            funcs.enableShow(deletebtn);
            funcs.enableShow(editbtn);
            funcs.disableHide(addbtn);
            categorycb.Enabled = false;
        }
    }
}
