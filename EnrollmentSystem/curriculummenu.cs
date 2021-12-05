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
        static int currcodeend = 1;
        static string finalcurrcode;
        checkDB checker = new checkDB();
        ArrayList arraylist = new ArrayList();
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
                foreach (DataRow dset in checker.FillCourseStudentAdd().Rows)
                {
                    arraylist.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                Coursecb.Items.AddRange(arraylist.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            editbtn.Enabled = false;
            deletebtn.Enabled = false;
            curriculumcodetxt.Enabled = false;
            unitstxt.Enabled = false;
        }

        private void Coursecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            currcodestart = Coursecb.SelectedItem.ToString();
            while (checker.IfCurrCodeExist(currcodestart + "-" + currcodeend))
            {
                currcodeend++;
            }
            finalcurrcode = currcodestart + "-" + currcodeend;
            curriculumcodetxt.Text = finalcurrcode;
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            if ((Coursecb.SelectedIndex > -1) || (YLcb.SelectedIndex>-1) || (semcb.SelectedIndex > -1))
            {
                string currc = curriculumcodetxt.Text;
                string coursec = Coursecb.SelectedItem.ToString();
                string yearC = YLcb.SelectedItem.ToString();
                string semc = semcb.SelectedItem.ToString();
                try
                {
                    checker.CreateCurr(currc, coursec, yearC, semc);
                    MessageBox.Show("Curriculum created successfully.", "Curriculum Created");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please check all the information you entered.", "Missing Information");
            }

        }
    }
}
