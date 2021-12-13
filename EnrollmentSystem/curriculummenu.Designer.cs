
namespace EnrollmentSystem
{
    partial class curriculummenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.curriculumcodetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Coursecb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.semcb = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.YLcb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unitstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridViewcurr = new System.Windows.Forms.DataGridView();
            this.createbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcurr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curriculum Management";
            // 
            // curriculumcodetxt
            // 
            this.curriculumcodetxt.Location = new System.Drawing.Point(68, 101);
            this.curriculumcodetxt.Name = "curriculumcodetxt";
            this.curriculumcodetxt.Size = new System.Drawing.Size(187, 20);
            this.curriculumcodetxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curriculum Code:";
            // 
            // Coursecb
            // 
            this.Coursecb.FormattingEnabled = true;
            this.Coursecb.Location = new System.Drawing.Point(293, 101);
            this.Coursecb.Name = "Coursecb";
            this.Coursecb.Size = new System.Drawing.Size(114, 21);
            this.Coursecb.TabIndex = 18;
            this.Coursecb.SelectedIndexChanged += new System.EventHandler(this.Coursecb_SelectedIndexChanged);
            this.Coursecb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coursecb_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Course:";
            // 
            // semcb
            // 
            this.semcb.FormattingEnabled = true;
            this.semcb.Location = new System.Drawing.Point(577, 101);
            this.semcb.Name = "semcb";
            this.semcb.Size = new System.Drawing.Size(87, 21);
            this.semcb.TabIndex = 36;
            this.semcb.SelectedIndexChanged += new System.EventHandler(this.semcb_SelectedIndexChanged);
            this.semcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coursecb_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(574, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Semester:";
            // 
            // YLcb
            // 
            this.YLcb.FormattingEnabled = true;
            this.YLcb.Location = new System.Drawing.Point(445, 101);
            this.YLcb.Name = "YLcb";
            this.YLcb.Size = new System.Drawing.Size(94, 21);
            this.YLcb.TabIndex = 34;
            this.YLcb.SelectedIndexChanged += new System.EventHandler(this.YLcb_SelectedIndexChanged);
            this.YLcb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coursecb_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Year level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Total Units:";
            // 
            // unitstxt
            // 
            this.unitstxt.Location = new System.Drawing.Point(702, 102);
            this.unitstxt.Name = "unitstxt";
            this.unitstxt.Size = new System.Drawing.Size(187, 20);
            this.unitstxt.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(237, 234);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(554, 20);
            this.searchtxt.TabIndex = 43;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // dataGridViewcurr
            // 
            this.dataGridViewcurr.AllowUserToAddRows = false;
            this.dataGridViewcurr.AllowUserToDeleteRows = false;
            this.dataGridViewcurr.AllowUserToResizeRows = false;
            this.dataGridViewcurr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcurr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcurr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewcurr.Location = new System.Drawing.Point(31, 292);
            this.dataGridViewcurr.Name = "dataGridViewcurr";
            this.dataGridViewcurr.RowHeadersVisible = false;
            this.dataGridViewcurr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcurr.Size = new System.Drawing.Size(910, 224);
            this.dataGridViewcurr.TabIndex = 45;
            this.dataGridViewcurr.VirtualMode = true;
            this.dataGridViewcurr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcurr_CellDoubleClick);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(469, 147);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(114, 23);
            this.createbtn.TabIndex = 39;
            this.createbtn.Text = "Create Curriculum";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(622, 147);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(114, 23);
            this.editbtn.TabIndex = 40;
            this.editbtn.Text = "Edit Curriculum";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(775, 147);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(114, 23);
            this.deletebtn.TabIndex = 41;
            this.deletebtn.Text = "Delete Curriculum";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(316, 146);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 23);
            this.clearbtn.TabIndex = 46;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // curriculummenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.dataGridViewcurr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.unitstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.semcb);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.YLcb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Coursecb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.curriculumcodetxt);
            this.Controls.Add(this.label1);
            this.Name = "curriculummenu";
            this.Text = "Curriculumn Menu";
            this.Load += new System.EventHandler(this.curriculummenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcurr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox curriculumcodetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Coursecb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox semcb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox YLcb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unitstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dataGridViewcurr;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
    }
}