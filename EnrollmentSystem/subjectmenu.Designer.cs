
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(subjectmenu));
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
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.dataGridViewsubs = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsubs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subject Management";
            // 
            // sctxt
            // 
            this.sctxt.Enabled = false;
            this.sctxt.Location = new System.Drawing.Point(93, 108);
            this.sctxt.Name = "sctxt";
            this.sctxt.Size = new System.Drawing.Size(198, 20);
            this.sctxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Code:";
            // 
            // sntxt
            // 
            this.sntxt.Location = new System.Drawing.Point(342, 108);
            this.sntxt.Name = "sntxt";
            this.sntxt.Size = new System.Drawing.Size(516, 20);
            this.sntxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subject Name:";
            // 
            // categorycb
            // 
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Location = new System.Drawing.Point(93, 160);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(198, 21);
            this.categorycb.TabIndex = 8;
            this.categorycb.SelectedIndexChanged += new System.EventHandler(this.categorycb_SelectedIndexChanged);
            this.categorycb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categorycb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            // 
            // utxt
            // 
            this.utxt.Location = new System.Drawing.Point(342, 160);
            this.utxt.Name = "utxt";
            this.utxt.Size = new System.Drawing.Size(198, 20);
            this.utxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Units";
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(744, 210);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(114, 23);
            this.deletebtn.TabIndex = 44;
            this.deletebtn.Text = "Delete Subject";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(594, 210);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(114, 23);
            this.editbtn.TabIndex = 43;
            this.editbtn.Text = "Edit Subject";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(444, 210);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(114, 23);
            this.addbtn.TabIndex = 42;
            this.addbtn.Text = "Add Subject";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dataGridViewsubs
            // 
            this.dataGridViewsubs.AllowUserToAddRows = false;
            this.dataGridViewsubs.AllowUserToDeleteRows = false;
            this.dataGridViewsubs.AllowUserToResizeRows = false;
            this.dataGridViewsubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewsubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsubs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewsubs.Location = new System.Drawing.Point(34, 310);
            this.dataGridViewsubs.Name = "dataGridViewsubs";
            this.dataGridViewsubs.RowHeadersVisible = false;
            this.dataGridViewsubs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewsubs.Size = new System.Drawing.Size(910, 224);
            this.dataGridViewsubs.TabIndex = 48;
            this.dataGridViewsubs.VirtualMode = true;
            this.dataGridViewsubs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewsubs_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(240, 266);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(554, 20);
            this.searchtxt.TabIndex = 46;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(294, 210);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 23);
            this.clearbtn.TabIndex = 49;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // subjectmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
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
    }
}