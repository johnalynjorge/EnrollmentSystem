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
    public partial class MainMenu : Form
    {
        static int formnum = 1;
        studentmenu st;
        coursemenu cm;
        curriculummenu crm;
        facultymenu fm;
        subjectmenu sbm;
        sectionmenu scm;
        schedulemenu sdm;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checknum(1) == false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                st = new studentmenu();
                st.TopLevel = false;
                st.AutoScroll = true;
                st.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(st);
                st.Show();
                setFormNum(1);
                position(studentMbtn);
                isActive(studentMbtn);
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log out?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                login log = new login();
                log.ShowDialog();
                this.Close();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            st = new studentmenu();
            st.TopLevel = false;
            st.AutoScroll = true;
            st.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(st);
            st.Show();
            position(studentMbtn);
            isActive(studentMbtn);
        }

        private void CourseMngt_Click(object sender, EventArgs e)
        {
            if (checknum(2) == false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                cm = new coursemenu();
                cm.TopLevel = false;
                cm.AutoScroll = true;
                cm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(cm);
                cm.Show();
                setFormNum(2);
                position(CourseMngt);
                isActive(CourseMngt);
            }
        }
        public void closeForm()
        {
            if (formnum == 1)
            {
                st.Close();
            }
            else if (formnum == 2)
            {
                cm.Close();
            }
            else if (formnum == 3)
            {
                sbm.Close();
            }
            else if (formnum == 4)
            {
                fm.Close();
            }
            else if (formnum == 5)
            {
                crm.Close();
            }
            else if (formnum == 6)
            {
                scm.Close();
            }
            else if (formnum == 7)
            {
                sdm.Close();
            }
        }

        public void setFormNum(int value)
        {
            formnum = value;
        }
        public bool checknum(int value)
        {
            if (value == formnum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void curBtn_Click(object sender, EventArgs e)
        {
            if (checknum(5) == false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                crm = new curriculummenu();
                crm.TopLevel = false;
                crm.AutoScroll = true;
                crm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(crm);
                crm.Show();
                setFormNum(5);
                position(curBtn);
                isActive(curBtn);
            }
        }

        private void FacultyMngt_Click(object sender, EventArgs e)
        {
            if (checknum(4) == false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                fm = new facultymenu();
                fm.TopLevel = false;
                fm.AutoScroll = true;
                fm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(fm);
                fm.Show();
                setFormNum(4);
                position(FacultyMngt);
                isActive(FacultyMngt);
            }
        }

        private void SubjectMngt_Click(object sender, EventArgs e)
        {
            if (checknum(3)== false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                sbm = new subjectmenu();
                sbm.TopLevel = false;
                sbm.AutoScroll = true;
                sbm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(sbm);
                sbm.Show();
                setFormNum(3);
                position(SubjectMngt);
                isActive(SubjectMngt);
            }
        }

        private void SectionMngt_Click(object sender, EventArgs e)
        {
            if (checknum(6) == false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                scm = new sectionmenu();
                scm.TopLevel = false;
                scm.AutoScroll = true;
                scm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(scm);
                scm.Show();
                setFormNum(6);
                position(SectionMngt);
                isActive(SectionMngt);
            }
        }

        private void ScheduleMngt_Click(object sender, EventArgs e)
        {
            if (checknum(7) == false)
            {
                mainpanel.Controls.Clear();
                closeForm();
                sdm = new schedulemenu();
                sdm.TopLevel = false;
                sdm.AutoScroll = true;
                sdm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(sdm);
                sdm.Show();
                setFormNum(7);
                position(ScheduleMngt);
                isActive(ScheduleMngt);
            }
        }
            private void position(Button btn)
        {
            indicator.Location = new Point(btn.Location.X - indicator.Width, btn.Location.Y);
        }
        private void isActive(Button btn)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button)
                {
                    if (ctrl.Name == btn.Name)
                    {
                        ctrl.BackColor = Color.FromArgb(112, 169, 165);
                        //ctrl.ForeColor = Color.White;
                    }
                    else
                    {
                        ctrl.BackColor = Color.FromArgb(68, 203, 191);
                        //ctrl.ForeColor = Color.Black;
                    }
                }
            }
        }

    }
    
}
