
namespace EnrollmentSystem
{
    partial class coursemenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coursemenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cctxt = new System.Windows.Forms.TextBox();
            this.cntxt = new System.Windows.Forms.TextBox();
            this.dataGridViewcourse = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearstxt = new System.Windows.Forms.TextBox();
            this.semstxt = new System.Windows.Forms.TextBox();
            this.rutxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course name:";
            // 
            // cctxt
            // 
            this.cctxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cctxt.Location = new System.Drawing.Point(93, 140);
            this.cctxt.Name = "cctxt";
            this.cctxt.Size = new System.Drawing.Size(407, 26);
            this.cctxt.TabIndex = 5;
            // 
            // cntxt
            // 
            this.cntxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntxt.Location = new System.Drawing.Point(596, 140);
            this.cntxt.Name = "cntxt";
            this.cntxt.Size = new System.Drawing.Size(407, 26);
            this.cntxt.TabIndex = 6;
            // 
            // dataGridViewcourse
            // 
            this.dataGridViewcourse.AllowUserToAddRows = false;
            this.dataGridViewcourse.AllowUserToDeleteRows = false;
            this.dataGridViewcourse.AllowUserToResizeRows = false;
            this.dataGridViewcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcourse.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewcourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewcourse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewcourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewcourse.Location = new System.Drawing.Point(93, 460);
            this.dataGridViewcourse.Name = "dataGridViewcourse";
            this.dataGridViewcourse.RowHeadersVisible = false;
            this.dataGridViewcourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcourse.Size = new System.Drawing.Size(910, 281);
            this.dataGridViewcourse.TabIndex = 7;
            this.dataGridViewcourse.VirtualMode = true;
            this.dataGridViewcourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcourse_CellDoubleClick);
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(174, 417);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(829, 26);
            this.searchtxt.TabIndex = 8;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search:";
            // 
            // yearstxt
            // 
            this.yearstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearstxt.Location = new System.Drawing.Point(93, 237);
            this.yearstxt.MaxLength = 2;
            this.yearstxt.Name = "yearstxt";
            this.yearstxt.Size = new System.Drawing.Size(266, 26);
            this.yearstxt.TabIndex = 48;
            // 
            // semstxt
            // 
            this.semstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semstxt.Location = new System.Drawing.Point(414, 237);
            this.semstxt.MaxLength = 1;
            this.semstxt.Name = "semstxt";
            this.semstxt.Size = new System.Drawing.Size(266, 26);
            this.semstxt.TabIndex = 49;
            // 
            // rutxt
            // 
            this.rutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutxt.Location = new System.Drawing.Point(735, 237);
            this.rutxt.Name = "rutxt";
            this.rutxt.Size = new System.Drawing.Size(266, 26);
            this.rutxt.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Years:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Semesters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(731, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Required units:";
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.clearbtn.Enabled = false;
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ImageKey = "clear.png";
            this.clearbtn.ImageList = this.imageList1;
            this.clearbtn.Location = new System.Drawing.Point(503, 297);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(120, 50);
            this.clearbtn.TabIndex = 90;
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
            this.deletebtn.Location = new System.Drawing.Point(881, 297);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(120, 50);
            this.deletebtn.TabIndex = 89;
            this.deletebtn.Text = "Delete Course";
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
            this.editbtn.Location = new System.Drawing.Point(755, 297);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(120, 50);
            this.editbtn.TabIndex = 88;
            this.editbtn.Text = "Save Changes";
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
            this.addbtn.Location = new System.Drawing.Point(629, 297);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(120, 50);
            this.addbtn.TabIndex = 87;
            this.addbtn.Text = "Add Course";
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // coursemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rutxt);
            this.Controls.Add(this.semstxt);
            this.Controls.Add(this.yearstxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridViewcourse);
            this.Controls.Add(this.cntxt);
            this.Controls.Add(this.cctxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "coursemenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.coursemenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cctxt;
        private System.Windows.Forms.TextBox cntxt;
        private System.Windows.Forms.DataGridView dataGridViewcourse;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearstxt;
        private System.Windows.Forms.TextBox semstxt;
        private System.Windows.Forms.TextBox rutxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ImageList imageList1;
    }
}