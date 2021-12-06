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
    public partial class MainMenu : Form
    {
        static int formnum = 1;
        studentmenu st;
        coursemenu cm;
        curriculummenu crm;
        facultymenu fm;
        subjectmenu sbm;
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
                st.FormBorderStyle = FormBorderStyle.None;
                st.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(st);
                st.Show();
                setFormNum(1);
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Log out", MessageBoxButtons.YesNo);
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
            st.FormBorderStyle = FormBorderStyle.None;
            st.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(st);
            st.Show();
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
                cm.FormBorderStyle = FormBorderStyle.None;
                cm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(cm);
                cm.Show();
                setFormNum(2);
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

            }
            else if (formnum == 7)
            {

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
                crm.FormBorderStyle = FormBorderStyle.None;
                crm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(crm);
                crm.Show();
                setFormNum(5);
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
                fm.FormBorderStyle = FormBorderStyle.None;
                fm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(fm);
                fm.Show();
                setFormNum(4);
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
                sbm.FormBorderStyle = FormBorderStyle.None;
                sbm.Dock = DockStyle.Fill;
                mainpanel.Controls.Add(sbm);
                sbm.Show();
                setFormNum(3);
            }
        }
        
    }
    
}
