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
    public partial class findirregular : Form
    {
        checkDB checker = new checkDB();
        ArrayList arrayList = new ArrayList();
        string[] studentvalues;

        public findirregular()
        {
            InitializeComponent();
        }

        private void findirregular_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow dset in checker.FillIrregular().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                studentcb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
                foreach (DataRow dset in checker.FillInstructor().Rows)
                {
                    arrayList.Add(string.Join(";", dset.ItemArray.Select(item => item.ToString())));
                }
                inscb.Items.AddRange(arrayList.ToArray());
                arrayList.Clear();
                arrayList.Clear();
                foreach (DataRow dset in checker.FillAllSubjects().Rows)
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
        }

        private void studentcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentcb.SelectedItem != null)
            {
                try
                {
                    studentvalues = (string[])checker.returnStudentName(studentcb.SelectedItem.ToString());
                    studentnametxt.Text = studentvalues[0] + " " + studentvalues[1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
