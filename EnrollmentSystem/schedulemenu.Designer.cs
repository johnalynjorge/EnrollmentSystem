
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schedulemenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label10 = new System.Windows.Forms.Label();
            this.inscb = new System.Windows.Forms.ComboBox();
            this.instxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridViewsched = new System.Windows.Forms.DataGridView();
            this.starttime = new System.Windows.Forms.DateTimePicker();
            this.endtime = new System.Windows.Forms.DateTimePicker();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.irregsched = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsched)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(410, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Schedule Management";
            // 
            // sectioncb
            // 
            this.sectioncb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectioncb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectioncb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectioncb.FormattingEnabled = true;
            this.sectioncb.Location = new System.Drawing.Point(106, 121);
            this.sectioncb.Name = "sectioncb";
            this.sectioncb.Size = new System.Drawing.Size(121, 28);
            this.sectioncb.TabIndex = 53;
            this.sectioncb.SelectedIndexChanged += new System.EventHandler(this.sectioncb_SelectedIndexChanged);
            this.sectioncb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Section Code:";
            // 
            // subjectcb
            // 
            this.subjectcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectcb.Enabled = false;
            this.subjectcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subjectcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectcb.FormattingEnabled = true;
            this.subjectcb.Location = new System.Drawing.Point(253, 121);
            this.subjectcb.Name = "subjectcb";
            this.subjectcb.Size = new System.Drawing.Size(121, 28);
            this.subjectcb.TabIndex = 55;
            this.subjectcb.SelectedIndexChanged += new System.EventHandler(this.subjectcb_SelectedIndexChanged);
            this.subjectcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Subject Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Subject Name:";
            // 
            // subjectn
            // 
            this.subjectn.Enabled = false;
            this.subjectn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectn.Location = new System.Drawing.Point(424, 123);
            this.subjectn.Name = "subjectn";
            this.subjectn.Size = new System.Drawing.Size(417, 26);
            this.subjectn.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Instructor ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Type:";
            // 
            // typecb
            // 
            this.typecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecb.FormattingEnabled = true;
            this.typecb.Location = new System.Drawing.Point(341, 267);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(150, 28);
            this.typecb.TabIndex = 63;
            this.typecb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Day:";
            // 
            // daycb
            // 
            this.daycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.daycb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daycb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daycb.FormattingEnabled = true;
            this.daycb.Location = new System.Drawing.Point(516, 267);
            this.daycb.Name = "daycb";
            this.daycb.Size = new System.Drawing.Size(150, 28);
            this.daycb.TabIndex = 65;
            this.daycb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // roomtxt
            // 
            this.roomtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtxt.Location = new System.Drawing.Point(106, 269);
            this.roomtxt.Name = "roomtxt";
            this.roomtxt.Size = new System.Drawing.Size(207, 26);
            this.roomtxt.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Room:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Start Time:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(862, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "End Time:";
            // 
            // inscb
            // 
            this.inscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscb.FormattingEnabled = true;
            this.inscb.Location = new System.Drawing.Point(106, 199);
            this.inscb.Name = "inscb";
            this.inscb.Size = new System.Drawing.Size(121, 28);
            this.inscb.TabIndex = 78;
            this.inscb.SelectedIndexChanged += new System.EventHandler(this.inscb_SelectedIndexChanged);
            this.inscb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sectioncb_KeyDown);
            // 
            // instxt
            // 
            this.instxt.Enabled = false;
            this.instxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instxt.Location = new System.Drawing.Point(256, 199);
            this.instxt.Name = "instxt";
            this.instxt.Size = new System.Drawing.Size(410, 26);
            this.instxt.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 20);
            this.label11.TabIndex = 79;
            this.label11.Text = "Instructor Name:";
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(157)))), ((int)(((byte)(222)))));
            this.createbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.Color.White;
            this.createbtn.ImageKey = "add.png";
            this.createbtn.ImageList = this.imageList1;
            this.createbtn.Location = new System.Drawing.Point(554, 336);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(150, 50);
            this.createbtn.TabIndex = 81;
            this.createbtn.Text = "Create Schedule";
            this.createbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createbtn.UseVisualStyleBackColor = false;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
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
            this.dataGridViewsched.Location = new System.Drawing.Point(106, 423);
            this.dataGridViewsched.Name = "dataGridViewsched";
            this.dataGridViewsched.RowHeadersVisible = false;
            this.dataGridViewsched.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsched.Size = new System.Drawing.Size(910, 283);
            this.dataGridViewsched.TabIndex = 82;
            this.dataGridViewsched.VirtualMode = true;
            this.dataGridViewsched.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsched_CellDoubleClick);
            // 
            // starttime
            // 
            this.starttime.CustomFormat = "hh:mm tt";
            this.starttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.starttime.Location = new System.Drawing.Point(691, 269);
            this.starttime.Name = "starttime";
            this.starttime.ShowUpDown = true;
            this.starttime.Size = new System.Drawing.Size(150, 26);
            this.starttime.TabIndex = 83;
            // 
            // endtime
            // 
            this.endtime.CustomFormat = "hh:mm tt";
            this.endtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endtime.Location = new System.Drawing.Point(866, 269);
            this.endtime.Name = "endtime";
            this.endtime.ShowUpDown = true;
            this.endtime.Size = new System.Drawing.Size(150, 26);
            this.endtime.TabIndex = 84;
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
            this.deletebtn.Location = new System.Drawing.Point(866, 336);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(150, 50);
            this.deletebtn.TabIndex = 86;
            this.deletebtn.Text = "Delete Schedule";
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ImageKey = "clear.png";
            this.clearbtn.ImageList = this.imageList1;
            this.clearbtn.Location = new System.Drawing.Point(398, 336);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(150, 50);
            this.clearbtn.TabIndex = 87;
            this.clearbtn.Text = "Clear";
            this.clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(105, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 32);
            this.panel1.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(252, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 30);
            this.panel2.TabIndex = 91;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(105, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 32);
            this.panel3.TabIndex = 92;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(339, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(156, 32);
            this.panel4.TabIndex = 93;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(514, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(156, 32);
            this.panel5.TabIndex = 94;
            // 
            // irregsched
            // 
            this.irregsched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.irregsched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.irregsched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irregsched.ImageKey = "person icon.png";
            this.irregsched.ImageList = this.imageList1;
            this.irregsched.Location = new System.Drawing.Point(866, 729);
            this.irregsched.Name = "irregsched";
            this.irregsched.Size = new System.Drawing.Size(150, 50);
            this.irregsched.TabIndex = 95;
            this.irregsched.Text = "Irregular Students";
            this.irregsched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.irregsched.UseVisualStyleBackColor = false;
            this.irregsched.Click += new System.EventHandler(this.irregsched_Click);
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
            this.editbtn.Location = new System.Drawing.Point(710, 336);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(150, 50);
            this.editbtn.TabIndex = 85;
            this.editbtn.Text = "Edit Schedule";
            this.editbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // schedulemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.irregsched);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
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
            this.Controls.Add(this.sectioncb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox inscb;
        private System.Windows.Forms.TextBox instxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.DataGridView dataGridViewsched;
        private System.Windows.Forms.DateTimePicker starttime;
        private System.Windows.Forms.DateTimePicker endtime;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button irregsched;
        private System.Windows.Forms.Button editbtn;
    }
}