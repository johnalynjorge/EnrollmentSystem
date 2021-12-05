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
        public studentmenu()
        {
            InitializeComponent();
        }

        private void studentmenu_Load(object sender, EventArgs e)
        {
            string[] sys = {"2021-2022", "2022-2023"};
            SYcb.Items.AddRange(sys);

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

        }
    }
}
