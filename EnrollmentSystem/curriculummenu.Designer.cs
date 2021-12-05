
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
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
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Units:";
            // 
            // unitstxt
            // 
            this.unitstxt.Location = new System.Drawing.Point(702, 102);
            this.unitstxt.Name = "unitstxt";
            this.unitstxt.Size = new System.Drawing.Size(187, 20);
            this.unitstxt.TabIndex = 38;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(753, 148);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(104, 23);
            this.deletebtn.TabIndex = 41;
            this.deletebtn.Text = "Delete Curriculum";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(599, 148);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(104, 23);
            this.editbtn.TabIndex = 40;
            this.editbtn.Text = "Edit Curriculum";
            this.editbtn.UseVisualStyleBackColor = true;
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(445, 148);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(104, 23);
            this.createbtn.TabIndex = 39;
            this.createbtn.Text = "Create Curriculum";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // curriculummenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
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
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button createbtn;
    }
}