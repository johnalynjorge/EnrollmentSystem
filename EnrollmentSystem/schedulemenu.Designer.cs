
namespace EnrollmentSystem
{
    partial class schedulemenu
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
            this.label7 = new System.Windows.Forms.Label();
            this.sectioncb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectcb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.daycb = new System.Windows.Forms.ComboBox();
            this.roomtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.starth = new System.Windows.Forms.ComboBox();
            this.startm = new System.Windows.Forms.ComboBox();
            this.startt = new System.Windows.Forms.ComboBox();
            this.endt = new System.Windows.Forms.ComboBox();
            this.endm = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.endh = new System.Windows.Forms.ComboBox();
            this.inscb = new System.Windows.Forms.ComboBox();
            this.instxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.dataGridViewsched = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsched)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Schedule Management";
            // 
            // sectioncb
            // 
            this.sectioncb.FormattingEnabled = true;
            this.sectioncb.Location = new System.Drawing.Point(90, 103);
            this.sectioncb.Name = "sectioncb";
            this.sectioncb.Size = new System.Drawing.Size(121, 21);
            this.sectioncb.TabIndex = 53;
            this.sectioncb.SelectedIndexChanged += new System.EventHandler(this.sectioncb_SelectedIndexChanged);
            this.sectioncb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Section Code:";
            // 
            // subjectcb
            // 
            this.subjectcb.Enabled = false;
            this.subjectcb.FormattingEnabled = true;
            this.subjectcb.Location = new System.Drawing.Point(237, 103);
            this.subjectcb.Name = "subjectcb";
            this.subjectcb.Size = new System.Drawing.Size(121, 21);
            this.subjectcb.TabIndex = 55;
            this.subjectcb.SelectedIndexChanged += new System.EventHandler(this.subjectcb_SelectedIndexChanged);
            this.subjectcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Subject Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Subject Name:";
            // 
            // subjectn
            // 
            this.subjectn.Enabled = false;
            this.subjectn.Location = new System.Drawing.Point(377, 103);
            this.subjectn.Name = "subjectn";
            this.subjectn.Size = new System.Drawing.Size(343, 20);
            this.subjectn.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Instructor ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Type:";
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(240, 204);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(80, 21);
            this.typecb.TabIndex = 63;
            this.typecb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Day:";
            // 
            // daycb
            // 
            this.daycb.FormattingEnabled = true;
            this.daycb.Location = new System.Drawing.Point(370, 205);
            this.daycb.Name = "daycb";
            this.daycb.Size = new System.Drawing.Size(87, 21);
            this.daycb.TabIndex = 65;
            this.daycb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // roomtxt
            // 
            this.roomtxt.Location = new System.Drawing.Point(90, 205);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(121, 20);
            this.roomtxt.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Room:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Start Time:";
            // 
            // starth
            // 
            this.starth.FormattingEnabled = true;
            this.starth.Location = new System.Drawing.Point(487, 205);
            this.starth.Name = "starth";
            this.starth.Size = new System.Drawing.Size(50, 21);
            this.starth.TabIndex = 69;
            this.starth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // startm
            // 
            this.startm.FormattingEnabled = true;
            this.startm.Location = new System.Drawing.Point(552, 205);
            this.startm.Name = "startm";
            this.startm.Size = new System.Drawing.Size(50, 21);
            this.startm.TabIndex = 71;
            this.startm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // startt
            // 
            this.startt.FormattingEnabled = true;
            this.startt.Location = new System.Drawing.Point(617, 205);
            this.startt.Name = "startt";
            this.startt.Size = new System.Drawing.Size(50, 21);
            this.startt.TabIndex = 72;
            this.startt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // endt
            // 
            this.endt.FormattingEnabled = true;
            this.endt.Location = new System.Drawing.Point(842, 205);
            this.endt.Name = "endt";
            this.endt.Size = new System.Drawing.Size(50, 21);
            this.endt.TabIndex = 76;
            this.endt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // endm
            // 
            this.endm.FormattingEnabled = true;
            this.endm.Location = new System.Drawing.Point(777, 205);
            this.endm.Name = "endm";
            this.endm.Size = new System.Drawing.Size(50, 21);
            this.endm.TabIndex = 75;
            this.endm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(709, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "End Time:";
            // 
            // endh
            // 
            this.endh.FormattingEnabled = true;
            this.endh.Location = new System.Drawing.Point(712, 205);
            this.endh.Name = "endh";
            this.endh.Size = new System.Drawing.Size(50, 21);
            this.endh.TabIndex = 73;
            this.endh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // inscb
            // 
            this.inscb.FormattingEnabled = true;
            this.inscb.Location = new System.Drawing.Point(90, 154);
            this.inscb.Name = "inscb";
            this.inscb.Size = new System.Drawing.Size(121, 21);
            this.inscb.TabIndex = 78;
            this.inscb.SelectedIndexChanged += new System.EventHandler(this.inscb_SelectedIndexChanged);
            // 
            // instxt
            // 
            this.instxt.Enabled = false;
            this.instxt.Location = new System.Drawing.Point(240, 154);
            this.instxt.Name = "instxt";
            this.instxt.Size = new System.Drawing.Size(343, 20);
            this.instxt.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Instructor name:";
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(633, 252);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(114, 23);
            this.createbtn.TabIndex = 81;
            this.createbtn.Text = "Create Schedule";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // dataGridViewsched
            // 
            this.dataGridViewsched.AllowUserToAddRows = false;
            this.dataGridViewsched.AllowUserToDeleteRows = false;
            this.dataGridViewsched.AllowUserToResizeRows = false;
            this.dataGridViewsched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewsched.Location = new System.Drawing.Point(38, 330);
            this.dataGridViewsched.Name = "dataGridViewsched";
            this.dataGridViewsched.RowHeadersVisible = false;
            this.dataGridViewsched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsched.Size = new System.Drawing.Size(910, 224);
            this.dataGridViewsched.TabIndex = 82;
            this.dataGridViewsched.VirtualMode = true;
            // 
            // schedulemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.dataGridViewsched);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.instxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inscb);
            this.Controls.Add(this.endt);
            this.Controls.Add(this.endm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.endh);
            this.Controls.Add(this.startt);
            this.Controls.Add(this.startm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.starth);
            this.Controls.Add(this.roomtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.daycb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.typecb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subjectn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectcb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sectioncb);
            this.Controls.Add(this.label7);
            this.Name = "schedulemenu";
            this.Text = "schedulemenu";
            this.Load += new System.EventHandler(this.schedulemenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsched)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sectioncb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox daycb;
        private System.Windows.Forms.TextBox roomtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox starth;
        private System.Windows.Forms.ComboBox startm;
        private System.Windows.Forms.ComboBox startt;
        private System.Windows.Forms.ComboBox endt;
        private System.Windows.Forms.ComboBox endm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox endh;
        private System.Windows.Forms.ComboBox inscb;
        private System.Windows.Forms.TextBox instxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.DataGridView dataGridViewsched;
    }
}