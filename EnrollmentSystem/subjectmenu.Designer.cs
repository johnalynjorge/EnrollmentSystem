
namespace EnrollmentSystem
{
    partial class subjectmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjectmenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.sctxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sntxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.utxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridViewsubs = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsubs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Management";
            // 
            // sctxt
            // 
            this.sctxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sctxt.Location = new System.Drawing.Point(93, 150);
            this.sctxt.Name = "sctxt";
            this.sctxt.ReadOnly = true;
            this.sctxt.Size = new System.Drawing.Size(198, 26);
            this.sctxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Code:";
            // 
            // sntxt
            // 
            this.sntxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sntxt.Location = new System.Drawing.Point(343, 150);
            this.sntxt.MaxLength = 100;
            this.sntxt.Name = "sntxt";
            this.sntxt.Size = new System.Drawing.Size(662, 26);
            this.sntxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject Name:";
            // 
            // categorycb
            // 
            this.categorycb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorycb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categorycb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Location = new System.Drawing.Point(93, 231);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(198, 28);
            this.categorycb.TabIndex = 8;
            this.categorycb.SelectedIndexChanged += new System.EventHandler(this.categorycb_SelectedIndexChanged);
            this.categorycb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categorycb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            // 
            // utxt
            // 
            this.utxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utxt.Location = new System.Drawing.Point(342, 231);
            this.utxt.Name = "utxt";
            this.utxt.Size = new System.Drawing.Size(198, 26);
            this.utxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Units";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(130)))));
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.ImageKey = "delete.png";
            this.deletebtn.ImageList = this.imageList1;
            this.deletebtn.Location = new System.Drawing.Point(886, 292);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(120, 50);
            this.deletebtn.TabIndex = 44;
            this.deletebtn.Text = "Delete \r\nSubject";
            this.deletebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
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
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(203)))), ((int)(((byte)(191)))));
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.ImageKey = "edit.jpg";
            this.editbtn.ImageList = this.imageList1;
            this.editbtn.Location = new System.Drawing.Point(760, 292);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(120, 50);
            this.editbtn.TabIndex = 43;
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
            this.addbtn.Location = new System.Drawing.Point(634, 292);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(120, 50);
            this.addbtn.TabIndex = 42;
            this.addbtn.Text = "Add \r\nSubject";
            this.addbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dataGridViewsubs
            // 
            this.dataGridViewsubs.AllowUserToAddRows = false;
            this.dataGridViewsubs.AllowUserToDeleteRows = false;
            this.dataGridViewsubs.AllowUserToResizeRows = false;
            this.dataGridViewsubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsubs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewsubs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewsubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewsubs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewsubs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewsubs.Location = new System.Drawing.Point(96, 416);
            this.dataGridViewsubs.Name = "dataGridViewsubs";
            this.dataGridViewsubs.RowHeadersVisible = false;
            this.dataGridViewsubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsubs.Size = new System.Drawing.Size(910, 299);
            this.dataGridViewsubs.TabIndex = 48;
            this.dataGridViewsubs.VirtualMode = true;
            this.dataGridViewsubs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsubs_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(190, 375);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(816, 26);
            this.searchtxt.TabIndex = 46;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(229)))), ((int)(((byte)(239)))));
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ImageKey = "clear.png";
            this.clearbtn.ImageList = this.imageList1;
            this.clearbtn.Location = new System.Drawing.Point(508, 292);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(120, 50);
            this.clearbtn.TabIndex = 49;
            this.clearbtn.Text = "Clear";
            this.clearbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(92, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 33);
            this.panel1.TabIndex = 89;
            // 
            // subjectmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.dataGridViewsubs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.utxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.categorycb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sntxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sctxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "subjectmenu";
            this.Text = "subjectmenu";
            this.Load += new System.EventHandler(this.subjectmenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sctxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sntxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categorycb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox utxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DataGridView dataGridViewsubs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
    }
}