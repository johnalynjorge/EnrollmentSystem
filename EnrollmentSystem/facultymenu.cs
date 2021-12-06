﻿using System;
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
        static string finalfcode;
        checkDB checker = new checkDB();
        string temid, tempfirst, templast, tempnum, tempdep;
        public facultymenu()
        {
            InitializeComponent();
        }

        private void facultymenu_Load(object sender, EventArgs e)
        {
            string[] depts = { "Gneral Education", "Information Technology", "Business" };
            Depcombo.Items.AddRange(depts);
            ClearData();
        }

        private void fLasttxt_TextChanged(object sender, EventArgs e)
        {
            if (fLasttxt.Text.Trim() !="")
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

            DialogResult result = MessageBox.Show("Do you want to save changes to the instructor '" + temid + "' ?", "Save Changes?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if ((last =="")|| (first=="")|| (contact == ""))
                {
                    MessageBox.Show("Please check all the information you entered.", "Missing Information");
                }
                else
                {
                    try
                    {
                        checker.Editfaculty(temid, first, last, contact, dep);
                        MessageBox.Show("Instructor updated successfully.", "Instructor Updated");
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
            DialogResult result = MessageBox.Show("Do you want to delete the instructor '" + temid + "' ?", "Delete Instructor record?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.DeleteFaculty(temid);
                    MessageBox.Show("Instructor record deleted successfully.", "Instructor Deleted");
                    ClearData();
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
            fIDtxt.Text = "";
            fLasttxt.Text = "";
            fFirsttxt.Text = "";
            contacttxt.Text = "";
            Depcombo.SelectedItem = null;
            editbtn.Enabled = false;
            deletebtn.Enabled = false;
            fIDtxt.Enabled = false;
            createbtn.Enabled = true;
            clearbtn.Enabled = false;
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string last = fLasttxt.Text.Trim();
            string first = fFirsttxt.Text.Trim();
            string contact = contacttxt.Text.Trim();
            if ((Depcombo.SelectedItem == null) || (last =="") || (first == "") || (contact == ""))
            {
                MessageBox.Show("Please check all the information you entered.", "Missing Information");
            }
            else
            {
                string dept = Depcombo.SelectedItem.ToString();
                try
                {
                    checker.Addfaculty(finalfcode, first, last, contact, dept);
                    MessageBox.Show("Instructor added successfully.", "Instructor Added");
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
            tempfirst = dataGridViewfaculty.Rows[e.RowIndex].Cells[1].Value.ToString();
            templast = dataGridViewfaculty.Rows[e.RowIndex].Cells[2].Value.ToString();
            tempnum = dataGridViewfaculty.Rows[e.RowIndex].Cells[3].Value.ToString();
            tempdep = dataGridViewfaculty.Rows[e.RowIndex].Cells[4].Value.ToString();
            fFirsttxt.Text = tempfirst;
            fLasttxt.Text = templast;
            contacttxt.Text = tempnum;
            fIDtxt.Text = temid;
            Depcombo.SelectedItem = tempdep;
            createbtn.Enabled = false;
            editbtn.Enabled = true;
            deletebtn.Enabled = true;
            clearbtn.Enabled = true;
        }
    }
}
