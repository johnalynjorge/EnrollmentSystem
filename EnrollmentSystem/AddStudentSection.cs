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
    public partial class AddStudentSection : Form
    {
        string studentid, sy, course, yl, semester;
        checkDB checker = new checkDB();
        
        public AddStudentSection(string id, string sy, string course, string yl, string sem)
        {
            InitializeComponent();
            this.studentid = id;
            this.sy = sy;
            this.course = course;
            this.yl = yl;
            this.semester = sem; 
        }

        private void AddStudentSection_Load(object sender, EventArgs e)
        {
            DisplaySections();
            idtxt.Text = studentid;
            SYcb.SelectedItem = sy;
            Coursecb.SelectedItem = course;
            YLcb.SelectedItem = yl;
            semcb.SelectedItem = semester;
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
    }
}
