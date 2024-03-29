﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    class formFuncs
    {
        ArrayList arrayList;
        public void ClearTextboxes(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is TextBox) 
                    ((TextBox)ctrl).Text = string.Empty;
                ClearTextboxes(ctrl.Controls);
            }
        }
        public void ClearCombobox(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedItem = null;
                ClearCombobox(ctrl.Controls);
            }
        }
        public void ClearCombobox2(System.Windows.Forms.Control.ControlCollection ctrls)
        {
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is ComboBox)
                    ((ComboBox)ctrl).Text = null;
                ClearCombobox(ctrl.Controls);
            }
        }
        public Array DaysValues()
        {
            string[] array = {"MONDAY","TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"};
            return array;
        }
        public ArrayList Hours()
        {
            arrayList = new ArrayList();
            for(int a = 1; a<=12; a++)
            {
                if (a < 10)
                {
                    arrayList.Add("0"+a);
                }
                else
                {
                    arrayList.Add(a);
                }
            }
            return arrayList;
        }
        public ArrayList Minutes()
        {
            arrayList = new ArrayList();
            for (int a = 0; a <= 60; a++)
            {
                if (a < 10)
                {
                    arrayList.Add("0" + a);
                }
                else
                {
                    arrayList.Add(a);
                }
            }
            return arrayList;
        }
        public Array TimeValues()
        {
            string[] array = { "AM", "PM" };
            return array;
        }
        public Array TypeValues()
        {
            string[] array = { "LEC", "LAB" };
            return array;
        }
        public ArrayList Schoolyear()
        {
            arrayList = new ArrayList();
            for (int a = 2021; a <= 2030; a++)
            {
                arrayList.Add(a);
            }
            return arrayList;
        }
        public void disableHide(Button btn)
        {
            btn.Enabled = false;
            btn.Hide();
        }
        public void enableShow(Button btn)
        {
            btn.Enabled = true;
            btn.Show();
        }
        public ArrayList ReturnYearLevel(int years)
        {
            arrayList = new ArrayList();
            string ext;
            for (int num= 1; num <= years; num++){
                switch (num)
                {
                    case 1:
                        ext = "ST";
                        break;
                    case 2:
                        ext = "ND";
                        break;
                    case 3:
                        ext = "RD";
                        break;
                    default:
                        ext = "TH";
                        break;
                }
                arrayList.Add(num.ToString() + ext + " YEAR");
            }
            return arrayList;
        }
        public ArrayList ReturnSems(int sem)
        {
            arrayList = new ArrayList();
            string ext;
            for (int num = 1; num <= sem; num++)
            {
                switch (num)
                {
                    case 1:
                        ext = "ST";
                        break;
                    case 2:
                        ext = "ND";
                        break;
                    case 3:
                        ext = "RD";
                        break;
                    default:
                        ext = "TH";
                        break;
                }
                arrayList.Add(num.ToString() + ext + " SEM");
            }
            return arrayList;
        }
        public Array DeptValues()
        {
            string[] array = { "GE", "IT", "BM" };
            return array;
        }
    }
}
