﻿using System;
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
    public partial class sectionmenu : Form
    {
        checkDB checker = new checkDB();
        formFuncs f = new formFuncs();
        char letter = 'A';
        static string sectioncode;
        ArrayList arrayList = new ArrayList();
        editsection es;
        public sectionmenu()
        {
            InitializeComponent();
        }

        private void sectionmenu_Load(object sender, EventArgs e)
        {
            
            DisplaySections();
            foreach (DataRow dset in checker.FillCurriculum().Rows)
            {
                arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
            }
            Currrcb.Items.AddRange(arrayList.ToArray());
            arrayList.Clear();
            //foreach (DataRow dset in checker.FillCourse().Rows)
            //{
            //    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
            //}
            //coursecb.Items.AddRange(arrayList.ToArray());
            //arrayList.Clear();
            
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.enableShow(addbtn);
            f.disableHide(editbtn);
        }

        public void clearData()
        {
            f.ClearTextboxes(this.Controls);
            f.ClearCombobox(this.Controls);
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.enableShow(addbtn);
            f.disableHide(editbtn);
            sectioncode = "";
            letter = 'A';
            DisplaySections();
            Currrcb.Enabled = true;
            coursecb.Enabled = true;
            ylcb.Enabled = true;
            semcb.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sectioncode != null)
                {
                    checker.AddSection(sectioncode, Currrcb.SelectedItem.ToString(), coursecb.SelectedItem.ToString(), ylcb.SelectedItem.ToString(), semcb.SelectedItem.ToString(), 0) ;
                    MessageBox.Show("Section created successfully.", "Section Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                }
                else
                {
                    MessageBox.Show("Please check all the information you entered.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            DialogResult result = MessageBox.Show("Do you want to delete the section '" + sectiontxt.Text + "'?\n" +
                "Schedules under this section will also be deleted.\nThis action cannot be undone. ", "Delete Section?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (numtxt.Text != "0")
                    {
                        MessageBox.Show("Cannot delete settion because there are students added in the section", "Cannot Delete Section", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        checker.DeleteSection(sectiontxt.Text);
                        checker.DeleteSchedBySection(sectiontxt.Text);
                        checker.DeleteSchedBySectionIrregular(sectiontxt.Text);
                        MessageBox.Show("Section deleted successfully.", "Section Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearData();
                    }
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
            
            Currrcb.SelectedItem = dataGridViewsetion.Rows[e.RowIndex].Cells[1].Value.ToString();
            coursecb.SelectedItem = dataGridViewsetion.Rows[e.RowIndex].Cells[2].Value.ToString();
            ylcb.SelectedItem = dataGridViewsetion.Rows[e.RowIndex].Cells[3].Value.ToString();
            semcb.SelectedItem = dataGridViewsetion.Rows[e.RowIndex].Cells[4].Value.ToString();
            numtxt.Text = dataGridViewsetion.Rows[e.RowIndex].Cells[5].Value.ToString();
            sectiontxt.Text = dataGridViewsetion.Rows[e.RowIndex].Cells[0].Value.ToString();
            f.enableShow(clearbtn);
            f.enableShow(deletebtn);
            f.disableHide(addbtn);
            f.enableShow(editbtn);
            Currrcb.Enabled = false;
            coursecb.Enabled = false;
            ylcb.Enabled = false;
            semcb.Enabled = false;
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

        private void Currrcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateCode();
            coursecb.Items.Clear();
            coursecb.DropDownHeight = 106;
            if (Currrcb.SelectedItem != null)
            {
                try
                {
                    foreach (DataRow dset in checker.FillSelectedCourse(Currrcb.SelectedItem.ToString()).Rows)
                    {
                        arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                    }
                    coursecb.Items.AddRange(arrayList.ToArray());
                    arrayList.Clear();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Currrcb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            es = new editsection(sectiontxt.Text);
            es.ShowDialog();
            clearData();
        }

        private void coursecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateCode();

            ylcb.Items.Clear();
            semcb.Items.Clear();
            ylcb.DropDownHeight = 106;
            semcb.DropDownHeight = 106;

            if (coursecb.SelectedItem != null)
            {
                try
                {
                    ylcb.Items.AddRange(f.ReturnYearLevel(checker.ReturnCourseYears(coursecb.SelectedItem.ToString())).ToArray());
                    semcb.Items.AddRange(f.ReturnSems(checker.ReturnCourseSems(coursecb.SelectedItem.ToString())).ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void GenerateCode()
        {
            letter = 'A';
            if (Currrcb.SelectedItem != null && coursecb.SelectedItem != null && ylcb.SelectedItem != null && semcb.SelectedItem != null)
            {
                while (checker.IfSectionExist(sectioncode = coursecb.SelectedItem.ToString() + (ylcb.SelectedIndex + 1) + "." + (semcb.SelectedIndex + 1) + letter))
                {
                    letter++;
                }
                sectioncode = coursecb.SelectedItem.ToString() + (ylcb.SelectedIndex + 1) + "." + (semcb.SelectedIndex + 1) + letter;
                sectiontxt.Text = sectioncode;
            }
            clearbtn.Enabled = true;
        }

        private void ylcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateCode();
        }
    }
}
