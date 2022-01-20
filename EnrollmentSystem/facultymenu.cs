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
    public partial class facultymenu : Form
    {
        static string fstart = "F-";
        static int fend = 1;
        bool beingEdit = false;
        static string finalfcode;
        checkDB checker = new checkDB();
        string temid;
        formFuncs funcs = new formFuncs();
        public facultymenu()
        {
            InitializeComponent();
        }

        private void facultymenu_Load(object sender, EventArgs e)
        {
            Depcombo.Items.AddRange((object[])funcs.DeptValues());
            ClearData();
        }

        private void fLasttxt_TextChanged(object sender, EventArgs e)
        {
            if (beingEdit == false)
            {
                if (fLasttxt.Text.Trim() != "")
                {
                    fend = 1;
                    while (checker.IfInsCodeExist(fstart + fend))
                    {
                        fend++;
                    }
                    finalfcode = fstart + fend;
                    fIDtxt.Text = finalfcode;
                }
                else
                {
                    fIDtxt.Text = "";
                }
            }
        }
        public void DisplayData()
        {
            try
            {
                dataGridViewfaculty.DataSource = checker.DisplayFaculty().DefaultView;
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
                dataGridViewfaculty.DataSource = checker.SearchFaculty(sc).DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string last = fLasttxt.Text.Trim();
            string first = fFirsttxt.Text.Trim();
            string contact = contacttxt.Text.Trim();
            string dep = Depcombo.SelectedItem.ToString();
            long contactnum;

            DialogResult result = MessageBox.Show("Do you want to save changes to the instructor '" + temid + "' ?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if ((last =="")|| (first=="")|| (contact == ""))
                {
                    MessageBox.Show("Please check all the information you entered.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (long.TryParse(contact, out contactnum) == false)
                {
                    MessageBox.Show("Please check all the information you entered.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        checker.Editfaculty(temid, first, last, contact, dep);
                        MessageBox.Show("Instructor updated successfully.", "Instructor Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the instructor '" + temid + "' ?", "Delete Instructor Record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (checker.IFInsSetToSched(temid))
                    {
                        MessageBox.Show("Cannot delete intsuctor because it was assigned to a schedule.\nChange the instructor first.", "Cannot Delete The Instructor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        checker.DeleteFaculty(temid);
                        MessageBox.Show("Instructor record deleted successfully.", "Instructor Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Depcombo_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            DisplayData();
            finalfcode = "";
            fend = 1;
            funcs.ClearTextboxes(this.Controls);
            funcs.ClearCombobox(this.Controls);
            beingEdit = false;
            funcs.enableShow(clearbtn);
            funcs.disableHide(deletebtn);
            funcs.disableHide(editbtn);
            funcs.enableShow(createbtn);
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string last = fLasttxt.Text.Trim();
            string first = fFirsttxt.Text.Trim();
            string contact = contacttxt.Text.Trim();
            long contactnum;
            if ((Depcombo.SelectedItem == null) || (last =="") || (first == "") || (contact == ""))
            {
                MessageBox.Show("Please check all the information you entered.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (long.TryParse(contact,out contactnum) == false)
            {
                MessageBox.Show("Please check all the information you entered.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string dept = Depcombo.SelectedItem.ToString();
                try
                {
                    checker.Addfaculty(finalfcode, first, last, contact, dept);
                    MessageBox.Show("Instructor added successfully.", "Instructor Added",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewfaculty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }
        public void getTempVal(DataGridViewCellEventArgs e)
        {
            temid = dataGridViewfaculty.Rows[e.RowIndex].Cells[0].Value.ToString();
            fFirsttxt.Text = dataGridViewfaculty.Rows[e.RowIndex].Cells[1].Value.ToString();
            fLasttxt.Text = dataGridViewfaculty.Rows[e.RowIndex].Cells[2].Value.ToString();
            contacttxt.Text = dataGridViewfaculty.Rows[e.RowIndex].Cells[3].Value.ToString();
            Depcombo.SelectedItem = dataGridViewfaculty.Rows[e.RowIndex].Cells[4].Value.ToString();
            fIDtxt.Text = temid;
            funcs.enableShow(clearbtn);
            funcs.enableShow(deletebtn);
            funcs.enableShow(editbtn);
            funcs.disableHide(createbtn);
            beingEdit = true;
        }
    }
}
