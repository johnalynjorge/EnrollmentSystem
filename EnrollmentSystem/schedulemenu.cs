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
        static string section, subject;
        string[] instructorvalues;
        formFuncs f = new formFuncs();
        bool flag;
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
            starth.Items.AddRange(f.Hours().ToArray());
            endh.Items.AddRange(f.Hours().ToArray());
            startm.Items.AddRange(f.Minutes().ToArray());
            endm.Items.AddRange(f.Minutes().ToArray());
            startt.Items.AddRange((object[])f.TimeValues());
            endt.Items.AddRange((object[])f.TimeValues());
            typecb.Items.AddRange((object[])f.TypeValues());

        }

        private void sectioncb_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectcb.Items.Clear();
            subjectcb.Text = "";
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
                MessageBox.Show("Please check all information", "Missing information");
                flag = false;
            }
            else
            {
                string start = starth.SelectedItem.ToString() + ":" + startm.SelectedItem.ToString() + " " + startt.SelectedItem.ToString();
                string end = endh.SelectedItem.ToString() + ":" + endm.SelectedItem.ToString() + " " + endt.SelectedItem.ToString();
                string section = sectioncb.SelectedItem.ToString();
                string subject = subjectcb.SelectedItem.ToString();
                string ins = inscb.SelectedItem.ToString();
                string day = daycb.SelectedItem.ToString();
                string room = roomtxt.Text;
                string type = typecb.SelectedItem.ToString();
                try
                {
                    checker.AddSchedule(section, subject, ins, day, start, end, room, type);
                    MessageBox.Show("Schedule created successfully", "Schedule Created");
                    clearData();
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
                    if (textBox.Text == string.Empty)
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
    }
}
