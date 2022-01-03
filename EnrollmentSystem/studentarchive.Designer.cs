
namespace EnrollmentSystem
{
    partial class studentarchive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearbtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.searchsecttxt = new System.Windows.Forms.TextBox();
            this.dataGridViewstudent = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.semcb = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bdaytxt = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Gendercb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Coursecb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Statuscb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.YLcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SYcb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.middletxt = new System.Windows.Forms.TextBox();
            this.firsttxt = new System.Windows.Forms.TextBox();
            this.lasttxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // clearbtn
            // 
            this.clearbtn.Enabled = false;
            this.clearbtn.Location = new System.Drawing.Point(450, 249);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 23);
            this.clearbtn.TabIndex = 123;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 122;
            this.label17.Text = "Search:";
            // 
            // searchsecttxt
            // 
            this.searchsecttxt.Location = new System.Drawing.Point(114, 297);
            this.searchsecttxt.Name = "searchsecttxt";
            this.searchsecttxt.Size = new System.Drawing.Size(779, 20);
            this.searchsecttxt.TabIndex = 121;
            // 
            // dataGridViewstudent
            // 
            this.dataGridViewstudent.AllowUserToAddRows = false;
            this.dataGridViewstudent.AllowUserToDeleteRows = false;
            this.dataGridViewstudent.AllowUserToResizeRows = false;
            this.dataGridViewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewstudent.Location = new System.Drawing.Point(51, 323);
            this.dataGridViewstudent.Name = "dataGridViewstudent";
            this.dataGridViewstudent.RowHeadersVisible = false;
            this.dataGridViewstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewstudent.Size = new System.Drawing.Size(877, 207);
            this.dataGridViewstudent.TabIndex = 120;
            this.dataGridViewstudent.VirtualMode = true;
            this.dataGridViewstudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudent_CellDoubleClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Enabled = false;
            this.deletebtn.Location = new System.Drawing.Point(768, 249);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(104, 23);
            this.deletebtn.TabIndex = 119;
            this.deletebtn.Text = "Delete Student";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Enabled = false;
            this.addbtn.Location = new System.Drawing.Point(614, 249);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(104, 23);
            this.addbtn.TabIndex = 117;
            this.addbtn.Text = "Restore Student";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // semcb
            // 
            this.semcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.semcb.Enabled = false;
            this.semcb.FormattingEnabled = true;
            this.semcb.Location = new System.Drawing.Point(539, 75);
            this.semcb.Name = "semcb";
            this.semcb.Size = new System.Drawing.Size(87, 21);
            this.semcb.TabIndex = 116;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(536, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 115;
            this.label16.Text = "Semester:";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(283, 217);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.ReadOnly = true;
            this.addresstxt.Size = new System.Drawing.Size(590, 20);
            this.addresstxt.TabIndex = 114;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 113;
            this.label15.Text = "Address:";
            // 
            // bdaytxt
            // 
            this.bdaytxt.CustomFormat = "MM/dd/yyyy";
            this.bdaytxt.Enabled = false;
            this.bdaytxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdaytxt.Location = new System.Drawing.Point(109, 218);
            this.bdaytxt.Name = "bdaytxt";
            this.bdaytxt.Size = new System.Drawing.Size(135, 20);
            this.bdaytxt.TabIndex = 112;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(106, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 111;
            this.label14.Text = "Birthdate:";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(580, 168);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.ReadOnly = true;
            this.emailtxt.Size = new System.Drawing.Size(291, 20);
            this.emailtxt.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(579, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "E-Mail:";
            // 
            // numtxt
            // 
            this.numtxt.Location = new System.Drawing.Point(402, 169);
            this.numtxt.Name = "numtxt";
            this.numtxt.ReadOnly = true;
            this.numtxt.Size = new System.Drawing.Size(148, 20);
            this.numtxt.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(400, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Mobile number:";
            // 
            // Gendercb
            // 
            this.Gendercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.Gendercb.Enabled = false;
            this.Gendercb.FormattingEnabled = true;
            this.Gendercb.Location = new System.Drawing.Point(254, 168);
            this.Gendercb.Name = "Gendercb";
            this.Gendercb.Size = new System.Drawing.Size(118, 21);
            this.Gendercb.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(251, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 105;
            this.label11.Text = "Gender:";
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(109, 169);
            this.agetxt.Name = "agetxt";
            this.agetxt.ReadOnly = true;
            this.agetxt.Size = new System.Drawing.Size(115, 20);
            this.agetxt.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 103;
            this.label10.Text = "Age:";
            // 
            // Coursecb
            // 
            this.Coursecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.Coursecb.Enabled = false;
            this.Coursecb.FormattingEnabled = true;
            this.Coursecb.Location = new System.Drawing.Point(759, 75);
            this.Coursecb.Name = "Coursecb";
            this.Coursecb.Size = new System.Drawing.Size(114, 21);
            this.Coursecb.TabIndex = 102;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(756, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 101;
            this.label9.Text = "Course:";
            // 
            // Statuscb
            // 
            this.Statuscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.Statuscb.Enabled = false;
            this.Statuscb.FormattingEnabled = true;
            this.Statuscb.Location = new System.Drawing.Point(645, 75);
            this.Statuscb.Name = "Statuscb";
            this.Statuscb.Size = new System.Drawing.Size(95, 21);
            this.Statuscb.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "Status:";
            // 
            // YLcb
            // 
            this.YLcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.YLcb.Enabled = false;
            this.YLcb.FormattingEnabled = true;
            this.YLcb.Location = new System.Drawing.Point(425, 75);
            this.YLcb.Name = "YLcb";
            this.YLcb.Size = new System.Drawing.Size(94, 21);
            this.YLcb.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Year level:";
            // 
            // SYcb
            // 
            this.SYcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.SYcb.Enabled = false;
            this.SYcb.FormattingEnabled = true;
            this.SYcb.Location = new System.Drawing.Point(283, 75);
            this.SYcb.Name = "SYcb";
            this.SYcb.Size = new System.Drawing.Size(118, 21);
            this.SYcb.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "School Year:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(109, 74);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(148, 20);
            this.idtxt.TabIndex = 94;
            // 
            // middletxt
            // 
            this.middletxt.Location = new System.Drawing.Point(645, 120);
            this.middletxt.Name = "middletxt";
            this.middletxt.ReadOnly = true;
            this.middletxt.Size = new System.Drawing.Size(228, 20);
            this.middletxt.TabIndex = 93;
            // 
            // firsttxt
            // 
            this.firsttxt.Location = new System.Drawing.Point(369, 120);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.ReadOnly = true;
            this.firsttxt.Size = new System.Drawing.Size(238, 20);
            this.firsttxt.TabIndex = 92;
            // 
            // lasttxt
            // 
            this.lasttxt.Location = new System.Drawing.Point(109, 120);
            this.lasttxt.Name = "lasttxt";
            this.lasttxt.ReadOnly = true;
            this.lasttxt.Size = new System.Drawing.Size(232, 20);
            this.lasttxt.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Middle name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Last name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 124;
            this.label1.Text = "Student Archive";
            // 
            // studentarchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchsecttxt);
            this.Controls.Add(this.dataGridViewstudent);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.semcb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bdaytxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numtxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Gendercb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Coursecb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Statuscb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YLcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SYcb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.middletxt);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.lasttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "studentarchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Archive";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.studentarchive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox searchsecttxt;
        private System.Windows.Forms.DataGridView dataGridViewstudent;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ComboBox semcb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker bdaytxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numtxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Gendercb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Coursecb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Statuscb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox YLcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SYcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox middletxt;
        private System.Windows.Forms.TextBox firsttxt;
        private System.Windows.Forms.TextBox lasttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}