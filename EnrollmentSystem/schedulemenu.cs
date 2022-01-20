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
    public partial class schedulemenu : Form
    {
        checkDB checker = new checkDB();
        ArrayList arrayList = new ArrayList();
        string[] instructorvalues;
        formFuncs f = new formFuncs();
        bool flag;
        findirregular formfind;
        public schedulemenu()
        {
            InitializeComponent();
        }

        private void schedulemenu_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dset in checker.FillSection().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                sectioncb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
                foreach(DataRow dset in checker.FillInstructor().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                inscb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            daycb.Items.AddRange((object[])f.DaysValues());
            typecb.Items.AddRange((object[])f.TypeValues());
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.disableHide(editbtn);
            f.enableShow(createbtn);
        }

        private void sectioncb_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectcb.Items.Clear();
            subjectcb.Text = "";
            subjectcb.DropDownHeight = 106;
            if (sectioncb.SelectedItem != null)
            {
                subjectcb.Enabled = true;
                
                try
                {
                    foreach (DataRow dset in checker.FillSubject(sectioncb.SelectedItem.ToString()).Rows)
                    {
                        arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                    }
                    subjectcb.Items.AddRange(arrayList.ToArray());
                    arrayList.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DisplayData();
                clearbtn.Enabled = true;
            }
        }

        private void subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectcb.SelectedItem != null)
            {
                try
                {
                    subjectn.Text = checker.returnSubjectName(subjectcb.SelectedItem.ToString());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void inscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inscb.SelectedItem != null)
            {
                try
                {
                    instructorvalues = (string[])checker.returnInstructor(inscb.SelectedItem.ToString());
                    instxt.Text = instructorvalues[1] + " " + instructorvalues[2];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if (checkParts())
            {
                MessageBox.Show("Please check all information", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else if (checker.IfScheduleExist(sectioncb.SelectedItem.ToString(),subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString()))
            {
                MessageBox.Show("The schedule for that subject already exist.", "Schedule Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string section = sectioncb.SelectedItem.ToString();
                string subject = subjectcb.SelectedItem.ToString();
                string ins = inscb.SelectedItem.ToString();
                string day = daycb.SelectedItem.ToString();
                string room = roomtxt.Text;
                string type = typecb.SelectedItem.ToString();
                try
                {
                    checker.AddSchedule(section, subject, ins, day, starttime.Text.ToString(), endtime.Text.ToString(), room, type);
                    MessageBox.Show("Schedule created successfully", "Schedule Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    sectioncb.SelectedItem = section;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sectioncb_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        public Boolean checkParts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text.Trim() == string.Empty)
                    {
                        flag = true;
                        break;
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedItem == null)
                    {
                        flag = true;
                        break;
                    }
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
        public void DisplayData()
        {
            try
            {
                dataGridViewsched.DataSource = checker.DisplaySched(sectioncb.SelectedItem.ToString()).DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clearData()
        {
            f.ClearCombobox(this.Controls);
            f.ClearTextboxes(this.Controls);
            
        }

        private void dataGridViewsched_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }
        public void getTempVal(DataGridViewCellEventArgs e)
        {

            sectioncb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[0].Value.ToString();
            subjectcb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[1].Value.ToString();
            inscb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[2].Value.ToString();
            daycb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[3].Value.ToString();
            starttime.Text = dataGridViewsched.Rows[e.RowIndex].Cells[4].Value.ToString();
            endtime.Text = dataGridViewsched.Rows[e.RowIndex].Cells[5].Value.ToString();
            roomtxt.Text = dataGridViewsched.Rows[e.RowIndex].Cells[6].Value.ToString();
            typecb.SelectedItem = dataGridViewsched.Rows[e.RowIndex].Cells[7].Value.ToString();
            sectioncb.Enabled = false;
            subjectcb.Enabled = false;
            typecb.Enabled = false;
            f.enableShow(clearbtn);
            f.enableShow(deletebtn);
            f.enableShow(editbtn);
            f.disableHide(createbtn);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearData();
            buttonDone();
            dataGridViewsched.DataSource = null;
            subjectcb.Enabled = false;
        }
        public void buttonDone()
        {
            f.enableShow(clearbtn);
            f.disableHide(deletebtn);
            f.disableHide(editbtn);
            f.enableShow(createbtn);
            sectioncb.Enabled = true;
            subjectcb.Enabled = true;
            typecb.Enabled = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string section = sectioncb.SelectedItem.ToString();
;            DialogResult result = MessageBox.Show("Do you want to delete the schedule for '" + sectioncb.SelectedItem.ToString() + " / " +
                subjectcb.SelectedItem.ToString() + " / " + typecb.SelectedItem.ToString() + "'? \n" +
                "If you will delete this, the schedule of the irregular students that are also set on this schedule will also be deleted" +
                "\nThis action cannot be undone. ", "Delete Schedule?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.DeleteIrregSchedFromMain(sectioncb.SelectedItem.ToString(), subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString());
                    checker.DeleteSched(sectioncb.SelectedItem.ToString(), subjectcb.SelectedItem.ToString(), typecb.SelectedItem.ToString());
                    MessageBox.Show("Schedule deleted successfully.", "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearData();
                    buttonDone();
                    sectioncb.SelectedItem = section;
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            string section = sectioncb.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("Do you want to save changes the schedule for '" + sectioncb.SelectedItem.ToString() + " / " +
                 subjectcb.SelectedItem.ToString() + " / " + typecb.SelectedItem.ToString() + "' ?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (checkParts()) {
                    MessageBox.Show("Please check all information", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }
                else
                {
                    try
                    {
                        checker.EditSchedule(section, subjectcb.SelectedItem.ToString(), inscb.SelectedItem.ToString(), daycb.SelectedItem.ToString(), starttime.Text.ToString(), endtime.Text.ToString(), roomtxt.Text, typecb.SelectedItem.ToString());
                        MessageBox.Show("Schedule edited successfully.", "Schedule Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearData();
                        buttonDone();
                        sectioncb.SelectedItem = section;
                        DisplayData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
            
        }

        private void irregsched_Click(object sender, EventArgs e)
        {
            formfind = new findirregular();
            formfind.ShowDialog();
        }
    }
}
