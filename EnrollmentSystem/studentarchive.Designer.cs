
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentarchive));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clearbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.searchsecttxt = new System.Windows.Forms.TextBox();
            this.dataGridViewstudent = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bdaytxt = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.Gendercb = new System.Windows.Forms.TextBox();
            this.SYcb = new System.Windows.Forms.TextBox();
            this.YLcb = new System.Windows.Forms.TextBox();
            this.semcb = new System.Windows.Forms.TextBox();
            this.Statuscb = new System.Windows.Forms.TextBox();
            this.Coursecb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.clearbtn.Enabled = false;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ImageKey = "clear.png";
            this.clearbtn.ImageList = this.imageList1;
            this.clearbtn.Location = new System.Drawing.Point(640, 332);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(120, 50);
            this.clearbtn.TabIndex = 123;
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
            this.imageList1.Images.SetKeyName(4, "restore.jpg");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(62, 405);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 122;
            this.label17.Text = "Search:";
            // 
            // searchsecttxt
            // 
            this.searchsecttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchsecttxt.Location = new System.Drawing.Point(155, 399);
            this.searchsecttxt.Name = "searchsecttxt";
            this.searchsecttxt.Size = new System.Drawing.Size(858, 26);
            this.searchsecttxt.TabIndex = 121;
            this.searchsecttxt.TextChanged += new System.EventHandler(this.searchsecttxt_TextChanged);
            // 
            // dataGridViewstudent
            // 
            this.dataGridViewstudent.AllowUserToAddRows = false;
            this.dataGridViewstudent.AllowUserToDeleteRows = false;
            this.dataGridViewstudent.AllowUserToResizeRows = false;
            this.dataGridViewstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewstudent.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewstudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewstudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewstudent.Location = new System.Drawing.Point(66, 448);
            this.dataGridViewstudent.Name = "dataGridViewstudent";
            this.dataGridViewstudent.RowHeadersVisible = false;
            this.dataGridViewstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewstudent.Size = new System.Drawing.Size(947, 263);
            this.dataGridViewstudent.TabIndex = 120;
            this.dataGridViewstudent.VirtualMode = true;
            this.dataGridViewstudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewstudent_CellDoubleClick);
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
            this.deletebtn.Location = new System.Drawing.Point(892, 332);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(120, 50);
            this.deletebtn.TabIndex = 119;
            this.deletebtn.Text = "Delete Student";
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(157)))), ((int)(((byte)(222)))));
            this.addbtn.Enabled = false;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.ImageKey = "restore.jpg";
            this.addbtn.ImageList = this.imageList1;
            this.addbtn.Location = new System.Drawing.Point(766, 332);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(120, 50);
            this.addbtn.TabIndex = 117;
            this.addbtn.Text = "Restore Student";
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(738, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 115;
            this.label16.Text = "Semester:";
            // 
            // addresstxt
            // 
            this.addresstxt.BackColor = System.Drawing.Color.White;
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(284, 290);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.ReadOnly = true;
            this.addresstxt.Size = new System.Drawing.Size(728, 26);
            this.addresstxt.TabIndex = 114;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(280, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 113;
            this.label15.Text = "Address:";
            // 
            // bdaytxt
            // 
            this.bdaytxt.CustomFormat = "MM/dd/yyyy";
            this.bdaytxt.Enabled = false;
            this.bdaytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdaytxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdaytxt.Location = new System.Drawing.Point(97, 290);
            this.bdaytxt.Name = "bdaytxt";
            this.bdaytxt.Size = new System.Drawing.Size(135, 26);
            this.bdaytxt.TabIndex = 112;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(93, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 111;
            this.label14.Text = "Birthdate:";
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.White;
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(731, 229);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.ReadOnly = true;
            this.emailtxt.Size = new System.Drawing.Size(279, 26);
            this.emailtxt.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(727, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 20);
            this.label13.TabIndex = 109;
            this.label13.Text = "E-Mail:";
            // 
            // numtxt
            // 
            this.numtxt.BackColor = System.Drawing.Color.White;
            this.numtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numtxt.Location = new System.Drawing.Point(481, 229);
            this.numtxt.Name = "numtxt";
            this.numtxt.ReadOnly = true;
            this.numtxt.Size = new System.Drawing.Size(198, 26);
            this.numtxt.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 107;
            this.label12.Text = "Mobile number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(279, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 105;
            this.label11.Text = "Gender:";
            // 
            // agetxt
            // 
            this.agetxt.BackColor = System.Drawing.Color.White;
            this.agetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agetxt.Location = new System.Drawing.Point(97, 229);
            this.agetxt.Name = "agetxt";
            this.agetxt.ReadOnly = true;
            this.agetxt.Size = new System.Drawing.Size(135, 26);
            this.agetxt.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 103;
            this.label10.Text = "Age:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 101;
            this.label9.Text = "Course:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(891, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(585, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Year level:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 95;
            this.label6.Text = "School Year:";
            // 
            // idtxt
            // 
            this.idtxt.BackColor = System.Drawing.Color.White;
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(97, 99);
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(148, 26);
            this.idtxt.TabIndex = 94;
            // 
            // middletxt
            // 
            this.middletxt.BackColor = System.Drawing.Color.White;
            this.middletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middletxt.Location = new System.Drawing.Point(733, 168);
            this.middletxt.Name = "middletxt";
            this.middletxt.ReadOnly = true;
            this.middletxt.Size = new System.Drawing.Size(280, 26);
            this.middletxt.TabIndex = 93;
            // 
            // firsttxt
            // 
            this.firsttxt.BackColor = System.Drawing.Color.White;
            this.firsttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firsttxt.Location = new System.Drawing.Point(415, 168);
            this.firsttxt.Name = "firsttxt";
            this.firsttxt.ReadOnly = true;
            this.firsttxt.Size = new System.Drawing.Size(280, 26);
            this.firsttxt.TabIndex = 92;
            // 
            // lasttxt
            // 
            this.lasttxt.BackColor = System.Drawing.Color.White;
            this.lasttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasttxt.Location = new System.Drawing.Point(97, 168);
            this.lasttxt.Name = "lasttxt";
            this.lasttxt.ReadOnly = true;
            this.lasttxt.Size = new System.Drawing.Size(280, 26);
            this.lasttxt.TabIndex = 91;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Middle name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Last name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Student ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 124;
            this.label1.Text = "Student Archive";
            // 
            // Gendercb
            // 
            this.Gendercb.BackColor = System.Drawing.Color.White;
            this.Gendercb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gendercb.Location = new System.Drawing.Point(284, 229);
            this.Gendercb.Name = "Gendercb";
            this.Gendercb.ReadOnly = true;
            this.Gendercb.Size = new System.Drawing.Size(136, 26);
            this.Gendercb.TabIndex = 125;
            // 
            // SYcb
            // 
            this.SYcb.BackColor = System.Drawing.Color.White;
            this.SYcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SYcb.Location = new System.Drawing.Point(280, 99);
            this.SYcb.Name = "SYcb";
            this.SYcb.ReadOnly = true;
            this.SYcb.Size = new System.Drawing.Size(118, 26);
            this.SYcb.TabIndex = 126;
            // 
            // YLcb
            // 
            this.YLcb.BackColor = System.Drawing.Color.White;
            this.YLcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YLcb.Location = new System.Drawing.Point(589, 99);
            this.YLcb.Name = "YLcb";
            this.YLcb.ReadOnly = true;
            this.YLcb.Size = new System.Drawing.Size(118, 26);
            this.YLcb.TabIndex = 127;
            // 
            // semcb
            // 
            this.semcb.BackColor = System.Drawing.Color.White;
            this.semcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semcb.Location = new System.Drawing.Point(742, 99);
            this.semcb.Name = "semcb";
            this.semcb.ReadOnly = true;
            this.semcb.Size = new System.Drawing.Size(118, 26);
            this.semcb.TabIndex = 128;
            // 
            // Statuscb
            // 
            this.Statuscb.BackColor = System.Drawing.Color.White;
            this.Statuscb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuscb.Location = new System.Drawing.Point(895, 99);
            this.Statuscb.Name = "Statuscb";
            this.Statuscb.ReadOnly = true;
            this.Statuscb.Size = new System.Drawing.Size(118, 26);
            this.Statuscb.TabIndex = 129;
            // 
            // Coursecb
            // 
            this.Coursecb.BackColor = System.Drawing.Color.White;
            this.Coursecb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursecb.Location = new System.Drawing.Point(438, 99);
            this.Coursecb.Name = "Coursecb";
            this.Coursecb.ReadOnly = true;
            this.Coursecb.Size = new System.Drawing.Size(118, 26);
            this.Coursecb.TabIndex = 130;
            // 
            // studentarchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.Coursecb);
            this.Controls.Add(this.Statuscb);
            this.Controls.Add(this.semcb);
            this.Controls.Add(this.YLcb);
            this.Controls.Add(this.SYcb);
            this.Controls.Add(this.Gendercb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.searchsecttxt);
            this.Controls.Add(this.dataGridViewstudent);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bdaytxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numtxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.agetxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.middletxt);
            this.Controls.Add(this.firsttxt);
            this.Controls.Add(this.lasttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker bdaytxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numtxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox Gendercb;
        private System.Windows.Forms.TextBox SYcb;
        private System.Windows.Forms.TextBox YLcb;
        private System.Windows.Forms.TextBox semcb;
        private System.Windows.Forms.TextBox Statuscb;
        private System.Windows.Forms.TextBox Coursecb;
    }
}