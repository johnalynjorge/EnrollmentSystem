using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace EnrollmentSystem
{
    public partial class studentmenu : Form
    {
        checkDB checker = new checkDB();
        ArrayList arrayList = new ArrayList();
        static string STstart = "S-", finalid;
        static int STend = 1;
        bool beingEdit = false, flag = false;
        formFuncs funcs = new formFuncs();
        studentarchive sa;
        public studentmenu()
        {
            InitializeComponent();
        }

        private void studentmenu_Load(object sender, EventArgs e)
        {
            DisplayData();

            string[] yls = {"First Year","Second  Year","Third Year","Fourth Year" };
            YLcb.Items.AddRange(yls);

            string[] sems = {"First Sem","Second Sem"};
            semcb.Items.AddRange(sems);

            string[] stats = {"Regular","Irregular"};
            Statuscb.Items.AddRange(stats);

            string[] genders = {"Male","Female"}; 
            Gendercb.Items.AddRange(genders);

            try
            {
                foreach(DataRow dset in checker.FillCourse().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                Coursecb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
                foreach (DataRow dset in checker.FillSchoolYear().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                SYcb.Items.AddRange(arrayList.ToArray());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu mn = new menu();
            mn.ShowDialog();
            this.Close();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int age;
            if (checkParts())
            {
                MessageBox.Show("Please check all information", "Missing information");
                flag = false;
            }
            else if (int.TryParse(agetxt.Text, out age))
            {
                try
                {
                    checker.AddStudentMain(idtxt.Text, lasttxt.Text, firsttxt.Text, middletxt.Text, SYcb.SelectedItem.ToString(), YLcb.SelectedItem.ToString(),
                        semcb.SelectedItem.ToString(), Statuscb.SelectedItem.ToString(),Coursecb.SelectedItem.ToString(),age,Gendercb.SelectedItem.ToString(),
                        numtxt.Text, emailtxt.Text, bdaytxt.Text.ToString(),addresstxt.Text);
                    MessageBox.Show("Student added successfully.", "Student Added");
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid age", "Invalid Information");
            }
           
        }
        public void clearData()
        {
            STend = 1;
            finalid = "";
            funcs.ClearTextboxes(this.Controls);
            funcs.ClearCombobox(this.Controls);
            DisplayData();
            SYcb.Enabled = true;
            YLcb.Enabled = true;
            semcb.Enabled = true;
            Statuscb.Enabled = true;
            Coursecb.Enabled = true;
            deletebtn.Enabled = true;
            beingEdit = false;
            editbtn.Enabled = false;
            deletebtn.Enabled = false;
            addbtn.Enabled = true;
            clearbtn.Enabled = false;
        }
        public void DisplayData()
        {
            try
            {
                dataGridViewstudent.DataSource = checker.DisplayStudents().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                getTempVal(e);
            }
        }
        public void getTempVal(DataGridViewCellEventArgs e)
        {

            
            lasttxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[1].Value.ToString();
            idtxt.Text= dataGridViewstudent.Rows[e.RowIndex].Cells[0].Value.ToString();
            firsttxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[2].Value.ToString();
            middletxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[3].Value.ToString();
            SYcb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[4].Value.ToString();
            YLcb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[5].Value.ToString();
            semcb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[6].Value.ToString();
            Statuscb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[7].Value.ToString();
            Coursecb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[8].Value.ToString();
            agetxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[9].Value.ToString();
            Gendercb.SelectedItem = dataGridViewstudent.Rows[e.RowIndex].Cells[10].Value.ToString();
            numtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[11].Value.ToString();
            emailtxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[12].Value.ToString();
            bdaytxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[13].Value.ToString();
            addresstxt.Text = dataGridViewstudent.Rows[e.RowIndex].Cells[14].Value.ToString();
            SYcb.Enabled = false;
            YLcb.Enabled = false;
            semcb.Enabled = false;
            Statuscb.Enabled = false;
            Coursecb.Enabled = false;
            deletebtn.Enabled = true;
            clearbtn.Enabled = true;
            addbtn.Enabled = false;
            editbtn.Enabled = true;
            beingEdit = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clearData(); 
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the student '" + idtxt.Text + "' ?", "Delete Student?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    checker.AddStudentArchive(idtxt.Text);
                    checker.DeleteStudentMain(idtxt.Text);
                    MessageBox.Show("Student deleted successfully.\nAdded to the archive", "Student Deleted");
                    clearData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void archivebtn_Click(object sender, EventArgs e)
        {
            sa = new studentarchive();
            sa.ShowDialog();
            DisplayData();
        }

        public Boolean checkParts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.Name != middletxt.Name && c.Name != searchsecttxt.Name)
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

        private void lasttxt_TextChanged(object sender, EventArgs e)
        {
            if (beingEdit == false)
            {
                if (lasttxt.Text.Trim() != "")
                {
                    STend = 1;
                    while (checker.IfStudentMain(STstart + STend) || checker.IfStudentArchive(STstart + STend))
                    {
                        STend++;
                    }
                    finalid = STstart + STend;
                    idtxt.Text = finalid;
                }
                else
                {
                    idtxt.Text = "";
                }
            }
        }
    }
}
