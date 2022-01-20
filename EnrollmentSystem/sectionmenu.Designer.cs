
namespace EnrollmentSystem
{
    partial class sectionmenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sectionmenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sectiontxt = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridViewsetion = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.searchsecttxt = new System.Windows.Forms.TextBox();
            this.Currrcb = new System.Windows.Forms.ComboBox();
            this.coursecb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ylcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.semcb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsetion)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Section Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Section code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "School year:";
            // 
            // sectiontxt
            // 
            this.sectiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectiontxt.Location = new System.Drawing.Point(111, 138);
            this.sectiontxt.Name = "sectiontxt";
            this.sectiontxt.ReadOnly = true;
            this.sectiontxt.Size = new System.Drawing.Size(207, 26);
            this.sectiontxt.TabIndex = 55;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.clearbtn.Enabled = false;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ImageKey = "clear.png";
            this.clearbtn.ImageList = this.imageList1;
            this.clearbtn.Location = new System.Drawing.Point(442, 274);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(130, 50);
            this.clearbtn.TabIndex = 60;
            this.clearbtn.Text = "Clear";
            this.clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "clear.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "edit.jpg");
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(130)))));
            this.deletebtn.Enabled = false;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.ImageKey = "delete.png";
            this.deletebtn.ImageList = this.imageList1;
            this.deletebtn.Location = new System.Drawing.Point(856, 274);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(130, 50);
            this.deletebtn.TabIndex = 59;
            this.deletebtn.Text = "Delete Section";
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.editbtn.Enabled = false;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.ImageKey = "edit.jpg";
            this.editbtn.ImageList = this.imageList1;
            this.editbtn.Location = new System.Drawing.Point(718, 274);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(130, 50);
            this.editbtn.TabIndex = 58;
            this.editbtn.Text = "Manage Students";
            this.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(157)))), ((int)(((byte)(222)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.ImageKey = "add.png";
            this.addbtn.ImageList = this.imageList1;
            this.addbtn.Location = new System.Drawing.Point(580, 274);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(130, 50);
            this.addbtn.TabIndex = 57;
            this.addbtn.Text = "Create Section";
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dataGridViewsetion
            // 
            this.dataGridViewsetion.AllowUserToAddRows = false;
            this.dataGridViewsetion.AllowUserToDeleteRows = false;
            this.dataGridViewsetion.AllowUserToResizeRows = false;
            this.dataGridViewsetion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsetion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewsetion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewsetion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewsetion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewsetion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewsetion.Location = new System.Drawing.Point(111, 394);
            this.dataGridViewsetion.Name = "dataGridViewsetion";
            this.dataGridViewsetion.RowHeadersVisible = false;
            this.dataGridViewsetion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsetion.Size = new System.Drawing.Size(877, 278);
            this.dataGridViewsetion.TabIndex = 61;
            this.dataGridViewsetion.VirtualMode = true;
            this.dataGridViewsetion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsetion_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 82;
            this.label10.Text = "Search:";
            // 
            // searchsecttxt
            // 
            this.searchsecttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchsecttxt.Location = new System.Drawing.Point(209, 352);
            this.searchsecttxt.Name = "searchsecttxt";
            this.searchsecttxt.Size = new System.Drawing.Size(779, 26);
            this.searchsecttxt.TabIndex = 81;
            this.searchsecttxt.TextChanged += new System.EventHandler(this.searchsecttxt_TextChanged);
            // 
            // Currrcb
            // 
            this.Currrcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Currrcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Currrcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currrcb.FormattingEnabled = true;
            this.Currrcb.Location = new System.Drawing.Point(445, 138);
            this.Currrcb.Name = "Currrcb";
            this.Currrcb.Size = new System.Drawing.Size(207, 28);
            this.Currrcb.TabIndex = 83;
            this.Currrcb.SelectedIndexChanged += new System.EventHandler(this.Currrcb_SelectedIndexChanged);
            this.Currrcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Currrcb_KeyDown);
            // 
            // coursecb
            // 
            this.coursecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coursecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursecb.FormattingEnabled = true;
            this.coursecb.Location = new System.Drawing.Point(779, 138);
            this.coursecb.Name = "coursecb";
            this.coursecb.Size = new System.Drawing.Size(207, 28);
            this.coursecb.TabIndex = 85;
            this.coursecb.SelectedIndexChanged += new System.EventHandler(this.coursecb_SelectedIndexChanged);
            this.coursecb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Currrcb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Course code:";
            // 
            // ylcb
            // 
            this.ylcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ylcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ylcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ylcb.FormattingEnabled = true;
            this.ylcb.Location = new System.Drawing.Point(111, 220);
            this.ylcb.Name = "ylcb";
            this.ylcb.Size = new System.Drawing.Size(207, 28);
            this.ylcb.TabIndex = 87;
            this.ylcb.SelectedIndexChanged += new System.EventHandler(this.ylcb_SelectedIndexChanged);
            this.ylcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Currrcb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Year Level:";
            // 
            // semcb
            // 
            this.semcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.semcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semcb.FormattingEnabled = true;
            this.semcb.Location = new System.Drawing.Point(445, 220);
            this.semcb.Name = "semcb";
            this.semcb.Size = new System.Drawing.Size(207, 28);
            this.semcb.TabIndex = 89;
            this.semcb.SelectedIndexChanged += new System.EventHandler(this.ylcb_SelectedIndexChanged);
            this.semcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Currrcb_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Semester:";
            // 
            // numtxt
            // 
            this.numtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numtxt.Location = new System.Drawing.Point(779, 222);
            this.numtxt.Name = "numtxt";
            this.numtxt.ReadOnly = true;
            this.numtxt.Size = new System.Drawing.Size(207, 26);
            this.numtxt.TabIndex = 91;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(775, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 90;
            this.label6.Text = "Number of Students:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(444, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 32);
            this.panel1.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(777, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 32);
            this.panel2.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(109, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 32);
            this.panel3.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(443, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 32);
            this.panel4.TabIndex = 95;
            // 
            // sectionmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.numtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.semcb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ylcb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coursecb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Currrcb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchsecttxt);
            this.Controls.Add(this.dataGridViewsetion);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.sectiontxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sectionmenu";
            this.Text = "sectionmenu";
            this.Load += new System.EventHandler(this.sectionmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsetion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sectiontxt;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView dataGridViewsetion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox searchsecttxt;
        private System.Windows.Forms.ComboBox Currrcb;
        private System.Windows.Forms.ComboBox coursecb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ylcb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox semcb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imageList1;
    }
}