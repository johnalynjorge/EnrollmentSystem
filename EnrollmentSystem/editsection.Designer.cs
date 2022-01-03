
namespace EnrollmentSystem
{
    partial class editsection
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
            this.label11 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.searchalready = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewAddedSt = new System.Windows.Forms.DataGridView();
            this.dataGridViewstudents = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semcb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ylcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coursecb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Currrcb = new System.Windows.Forms.ComboBox();
            this.sectiontxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedSt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(498, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 106;
            this.label11.Text = "Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(548, 305);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(352, 20);
            this.searchtxt.TabIndex = 105;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Search:";
            // 
            // searchalready
            // 
            this.searchalready.Location = new System.Drawing.Point(128, 305);
            this.searchalready.Name = "searchalready";
            this.searchalready.Size = new System.Drawing.Size(352, 20);
            this.searchalready.TabIndex = 103;
            this.searchalready.TextChanged += new System.EventHandler(this.searchalready_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.Enabled = false;
            this.clearbtn.Location = new System.Drawing.Point(470, 210);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 23);
            this.clearbtn.TabIndex = 102;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 101;
            this.label8.Text = "Student list:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 24);
            this.label6.TabIndex = 100;
            this.label6.Text = "Students already added:";
            // 
            // dataGridViewAddedSt
            // 
            this.dataGridViewAddedSt.AllowUserToAddRows = false;
            this.dataGridViewAddedSt.AllowUserToDeleteRows = false;
            this.dataGridViewAddedSt.AllowUserToResizeRows = false;
            this.dataGridViewAddedSt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddedSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddedSt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAddedSt.Location = new System.Drawing.Point(80, 331);
            this.dataGridViewAddedSt.Name = "dataGridViewAddedSt";
            this.dataGridViewAddedSt.RowHeadersVisible = false;
            this.dataGridViewAddedSt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddedSt.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewAddedSt.TabIndex = 99;
            this.dataGridViewAddedSt.VirtualMode = true;
            this.dataGridViewAddedSt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddedSt_CellDoubleClick);
            // 
            // dataGridViewstudents
            // 
            this.dataGridViewstudents.AllowUserToAddRows = false;
            this.dataGridViewstudents.AllowUserToDeleteRows = false;
            this.dataGridViewstudents.AllowUserToResizeRows = false;
            this.dataGridViewstudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewstudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewstudents.Location = new System.Drawing.Point(501, 331);
            this.dataGridViewstudents.Name = "dataGridViewstudents";
            this.dataGridViewstudents.RowHeadersVisible = false;
            this.dataGridViewstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewstudents.Size = new System.Drawing.Size(400, 200);
            this.dataGridViewstudents.TabIndex = 98;
            this.dataGridViewstudents.VirtualMode = true;
            this.dataGridViewstudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudents_CellDoubleClick);
            // 
            // deletebtn
            // 
            this.deletebtn.Enabled = false;
            this.deletebtn.Location = new System.Drawing.Point(786, 210);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(114, 23);
            this.deletebtn.TabIndex = 97;
            this.deletebtn.Text = "Remove ";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Enabled = false;
            this.addbtn.Location = new System.Drawing.Point(628, 210);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(114, 23);
            this.addbtn.TabIndex = 96;
            this.addbtn.Text = "Add ";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Student Name:";
            // 
            // nametxt
            // 
            this.nametxt.Enabled = false;
            this.nametxt.Location = new System.Drawing.Point(359, 165);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(425, 20);
            this.nametxt.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Student ID:";
            // 
            // idtxt
            // 
            this.idtxt.Enabled = false;
            this.idtxt.Location = new System.Drawing.Point(53, 165);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(275, 20);
            this.idtxt.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 84;
            this.label5.Text = "Edit Section";
            // 
            // numtxt
            // 
            this.numtxt.Enabled = false;
            this.numtxt.Location = new System.Drawing.Point(815, 111);
            this.numtxt.Name = "numtxt";
            this.numtxt.Size = new System.Drawing.Size(121, 20);
            this.numtxt.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Number of Students:";
            // 
            // semcb
            // 
            this.semcb.Enabled = false;
            this.semcb.FormattingEnabled = true;
            this.semcb.Location = new System.Drawing.Point(663, 110);
            this.semcb.Name = "semcb";
            this.semcb.Size = new System.Drawing.Size(121, 21);
            this.semcb.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "Semester:";
            // 
            // ylcb
            // 
            this.ylcb.Enabled = false;
            this.ylcb.FormattingEnabled = true;
            this.ylcb.Location = new System.Drawing.Point(511, 110);
            this.ylcb.Name = "ylcb";
            this.ylcb.Size = new System.Drawing.Size(121, 21);
            this.ylcb.TabIndex = 114;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 113;
            this.label7.Text = "Year Level:";
            // 
            // coursecb
            // 
            this.coursecb.Enabled = false;
            this.coursecb.FormattingEnabled = true;
            this.coursecb.Location = new System.Drawing.Point(359, 110);
            this.coursecb.Name = "coursecb";
            this.coursecb.Size = new System.Drawing.Size(121, 21);
            this.coursecb.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Course code:";
            // 
            // Currrcb
            // 
            this.Currrcb.Enabled = false;
            this.Currrcb.FormattingEnabled = true;
            this.Currrcb.Location = new System.Drawing.Point(207, 110);
            this.Currrcb.Name = "Currrcb";
            this.Currrcb.Size = new System.Drawing.Size(121, 21);
            this.Currrcb.TabIndex = 110;
            // 
            // sectiontxt
            // 
            this.sectiontxt.Enabled = false;
            this.sectiontxt.Location = new System.Drawing.Point(55, 111);
            this.sectiontxt.Name = "sectiontxt";
            this.sectiontxt.Size = new System.Drawing.Size(121, 20);
            this.sectiontxt.TabIndex = 109;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(204, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 108;
            this.label12.Text = "School year:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 107;
            this.label13.Text = "Section code:";
            // 
            // editsection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.numtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.semcb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ylcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.coursecb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Currrcb);
            this.Controls.Add(this.sectiontxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchalready);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewAddedSt);
            this.Controls.Add(this.dataGridViewstudents);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label5);
            this.Name = "editsection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.editsection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedSt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchalready;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewAddedSt;
        private System.Windows.Forms.DataGridView dataGridViewstudents;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox semcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ylcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox coursecb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Currrcb;
        private System.Windows.Forms.TextBox sectiontxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}