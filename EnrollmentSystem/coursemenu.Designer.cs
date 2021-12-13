
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coursemenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cctxt = new System.Windows.Forms.TextBox();
            this.cntxt = new System.Windows.Forms.TextBox();
            this.dataGridViewcourse = new System.Windows.Forms.DataGridView();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.yearstxt = new System.Windows.Forms.TextBox();
            this.semstxt = new System.Windows.Forms.TextBox();
            this.rutxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course name:";
            // 
            // cctxt
            // 
            this.cctxt.Location = new System.Drawing.Point(109, 94);
            this.cctxt.Name = "cctxt";
            this.cctxt.Size = new System.Drawing.Size(343, 20);
            this.cctxt.TabIndex = 5;
            // 
            // cntxt
            // 
            this.cntxt.Location = new System.Drawing.Point(519, 94);
            this.cntxt.Name = "cntxt";
            this.cntxt.Size = new System.Drawing.Size(386, 20);
            this.cntxt.TabIndex = 6;
            // 
            // dataGridViewcourse
            // 
            this.dataGridViewcourse.AllowUserToAddRows = false;
            this.dataGridViewcourse.AllowUserToDeleteRows = false;
            this.dataGridViewcourse.AllowUserToResizeRows = false;
            this.dataGridViewcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcourse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewcourse.Location = new System.Drawing.Point(41, 294);
            this.dataGridViewcourse.Name = "dataGridViewcourse";
            this.dataGridViewcourse.RowHeadersVisible = false;
            this.dataGridViewcourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcourse.Size = new System.Drawing.Size(910, 224);
            this.dataGridViewcourse.TabIndex = 7;
            this.dataGridViewcourse.VirtualMode = true;
            this.dataGridViewcourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewcourse_CellDoubleClick);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(268, 257);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(554, 20);
            this.searchtxt.TabIndex = 8;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search:";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(497, 178);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(114, 23);
            this.addbtn.TabIndex = 11;
            this.addbtn.Text = "Add Course";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(644, 178);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(114, 23);
            this.editbtn.TabIndex = 12;
            this.editbtn.Text = "Edit Course";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(791, 178);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(114, 23);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "Delete Course";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(350, 178);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 23);
            this.clearbtn.TabIndex = 47;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // yearstxt
            // 
            this.yearstxt.Location = new System.Drawing.Point(109, 142);
            this.yearstxt.Name = "yearstxt";
            this.yearstxt.Size = new System.Drawing.Size(227, 20);
            this.yearstxt.TabIndex = 48;
            // 
            // semstxt
            // 
            this.semstxt.Location = new System.Drawing.Point(393, 142);
            this.semstxt.Name = "semstxt";
            this.semstxt.Size = new System.Drawing.Size(227, 20);
            this.semstxt.TabIndex = 49;
            // 
            // rutxt
            // 
            this.rutxt.Location = new System.Drawing.Point(677, 142);
            this.rutxt.Name = "rutxt";
            this.rutxt.Size = new System.Drawing.Size(227, 20);
            this.rutxt.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Years:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Semesters:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Required units:";
            // 
            // coursemenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rutxt);
            this.Controls.Add(this.semstxt);
            this.Controls.Add(this.yearstxt);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridViewcourse);
            this.Controls.Add(this.cntxt);
            this.Controls.Add(this.cctxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.TextBox yearstxt;
        private System.Windows.Forms.TextBox semstxt;
        private System.Windows.Forms.TextBox rutxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}