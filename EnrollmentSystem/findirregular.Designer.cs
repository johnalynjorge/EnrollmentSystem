
namespace EnrollmentSystem
{
    partial class findirregular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findirregular));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.clearbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.starttime = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewsched = new System.Windows.Forms.DataGridView();
            this.createbtn = new System.Windows.Forms.Button();
            this.instxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inscb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roomtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.daycb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.subjectn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectcb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentnametxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "clear.png");
            this.imageList1.Images.SetKeyName(2, "delete.png");
            this.imageList1.Images.SetKeyName(3, "edit.jpg");
            this.imageList1.Images.SetKeyName(4, "person icon.png");
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.clearbtn.Enabled = false;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ImageKey = "clear.png";
            this.clearbtn.ImageList = this.imageList1;
            this.clearbtn.Location = new System.Drawing.Point(499, 284);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(150, 50);
            this.clearbtn.TabIndex = 120;
            this.clearbtn.Text = "Clear";
            this.clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearbtn.UseVisualStyleBackColor = false;
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
            this.deletebtn.Location = new System.Drawing.Point(849, 284);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(150, 50);
            this.deletebtn.TabIndex = 119;
            this.deletebtn.Text = "Delete Schedule";
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // endtime
            // 
            this.endtime.CustomFormat = "hh:mm tt";
            this.endtime.Enabled = false;
            this.endtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtime.Location = new System.Drawing.Point(849, 236);
            this.endtime.Name = "endtime";
            this.endtime.ShowUpDown = true;
            this.endtime.Size = new System.Drawing.Size(150, 26);
            this.endtime.TabIndex = 117;
            // 
            // starttime
            // 
            this.starttime.CustomFormat = "hh:mm tt";
            this.starttime.Enabled = false;
            this.starttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttime.Location = new System.Drawing.Point(674, 236);
            this.starttime.Name = "starttime";
            this.starttime.ShowUpDown = true;
            this.starttime.Size = new System.Drawing.Size(150, 26);
            this.starttime.TabIndex = 116;
            // 
            // dataGridViewsched
            // 
            this.dataGridViewsched.AllowUserToAddRows = false;
            this.dataGridViewsched.AllowUserToDeleteRows = false;
            this.dataGridViewsched.AllowUserToResizeRows = false;
            this.dataGridViewsched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsched.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewsched.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewsched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewsched.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewsched.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewsched.Location = new System.Drawing.Point(551, 404);
            this.dataGridViewsched.Name = "dataGridViewsched";
            this.dataGridViewsched.RowHeadersVisible = false;
            this.dataGridViewsched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsched.Size = new System.Drawing.Size(500, 283);
            this.dataGridViewsched.TabIndex = 115;
            this.dataGridViewsched.VirtualMode = true;
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(157)))), ((int)(((byte)(222)))));
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.ImageKey = "add.png";
            this.createbtn.ImageList = this.imageList1;
            this.createbtn.Location = new System.Drawing.Point(674, 284);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(150, 50);
            this.createbtn.TabIndex = 114;
            this.createbtn.Text = "Create Schedule";
            this.createbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createbtn.UseVisualStyleBackColor = false;
            // 
            // instxt
            // 
            this.instxt.Enabled = false;
            this.instxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instxt.Location = new System.Drawing.Point(239, 166);
            this.instxt.Name = "instxt";
            this.instxt.Size = new System.Drawing.Size(410, 26);
            this.instxt.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(235, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 112;
            this.label11.Text = "Instructor Name:";
            // 
            // inscb
            // 
            this.inscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.inscb.Enabled = false;
            this.inscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscb.FormattingEnabled = true;
            this.inscb.Location = new System.Drawing.Point(88, 166);
            this.inscb.Name = "inscb";
            this.inscb.Size = new System.Drawing.Size(121, 30);
            this.inscb.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(845, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 110;
            this.label10.Text = "End Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(670, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 109;
            this.label9.Text = "Start Time:";
            // 
            // roomtxt
            // 
            this.roomtxt.Enabled = false;
            this.roomtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtxt.Location = new System.Drawing.Point(89, 236);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(207, 26);
            this.roomtxt.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 107;
            this.label5.Text = "Room:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 106;
            this.label8.Text = "Day:";
            // 
            // daycb
            // 
            this.daycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.daycb.Enabled = false;
            this.daycb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daycb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daycb.FormattingEnabled = true;
            this.daycb.Location = new System.Drawing.Point(499, 236);
            this.daycb.Name = "daycb";
            this.daycb.Size = new System.Drawing.Size(150, 28);
            this.daycb.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 104;
            this.label6.Text = "Type:";
            // 
            // typecb
            // 
            this.typecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.typecb.Enabled = false;
            this.typecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(324, 236);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(150, 28);
            this.typecb.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "Instructor ID:";
            // 
            // subjectn
            // 
            this.subjectn.Enabled = false;
            this.subjectn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectn.Location = new System.Drawing.Point(674, 90);
            this.subjectn.Name = "subjectn";
            this.subjectn.Size = new System.Drawing.Size(325, 26);
            this.subjectn.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Subject Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Subject Code:";
            // 
            // subjectcb
            // 
            this.subjectcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.subjectcb.Enabled = false;
            this.subjectcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectcb.FormattingEnabled = true;
            this.subjectcb.Location = new System.Drawing.Point(518, 88);
            this.subjectcb.Name = "subjectcb";
            this.subjectcb.Size = new System.Drawing.Size(121, 30);
            this.subjectcb.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "Student ID:";
            // 
            // studentcb
            // 
            this.studentcb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.studentcb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.studentcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentcb.FormattingEnabled = true;
            this.studentcb.Location = new System.Drawing.Point(89, 88);
            this.studentcb.Name = "studentcb";
            this.studentcb.Size = new System.Drawing.Size(121, 28);
            this.studentcb.TabIndex = 96;
            this.studentcb.SelectedIndexChanged += new System.EventHandler(this.studentcb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 25);
            this.label7.TabIndex = 95;
            this.label7.Text = "Schedule Management For Irregular Students\r\n";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(88, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 32);
            this.panel1.TabIndex = 121;
            // 
            // studentnametxt
            // 
            this.studentnametxt.Enabled = false;
            this.studentnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentnametxt.Location = new System.Drawing.Point(239, 92);
            this.studentnametxt.Name = "studentnametxt";
            this.studentnametxt.Size = new System.Drawing.Size(239, 26);
            this.studentnametxt.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(235, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 126;
            this.label12.Text = "Student Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(31, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(500, 283);
            this.dataGridView1.TabIndex = 128;
            this.dataGridView1.VirtualMode = true;
            // 
            // findirregular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentnametxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.endtime);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.dataGridViewsched);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.instxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.inscb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.studentcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "findirregular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Irregular Student Schedule";
            this.Load += new System.EventHandler(this.findirregular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DateTimePicker endtime;
        private System.Windows.Forms.DateTimePicker starttime;
        private System.Windows.Forms.DataGridView dataGridViewsched;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.TextBox instxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox inscb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roomtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox daycb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subjectn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subjectcb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox studentcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox studentnametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}