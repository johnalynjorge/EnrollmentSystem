
namespace EnrollmentSystem
{
    partial class menu
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
            this.StudentMngt = new System.Windows.Forms.Button();
            this.CourseMngt = new System.Windows.Forms.Button();
            this.SubjectMngt = new System.Windows.Forms.Button();
            this.FacultyMngt = new System.Windows.Forms.Button();
            this.SectionMngt = new System.Windows.Forms.Button();
            this.ScheduleMngt = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentMngt
            // 
            this.StudentMngt.Location = new System.Drawing.Point(169, 32);
            this.StudentMngt.Name = "StudentMngt";
            this.StudentMngt.Size = new System.Drawing.Size(190, 23);
            this.StudentMngt.TabIndex = 0;
            this.StudentMngt.Text = "Student Managemnt";
            this.StudentMngt.UseVisualStyleBackColor = true;
            this.StudentMngt.Click += new System.EventHandler(this.StudentMngt_Click);
            // 
            // CourseMngt
            // 
            this.CourseMngt.Location = new System.Drawing.Point(169, 91);
            this.CourseMngt.Name = "CourseMngt";
            this.CourseMngt.Size = new System.Drawing.Size(190, 23);
            this.CourseMngt.TabIndex = 1;
            this.CourseMngt.Text = "Course Management";
            this.CourseMngt.UseVisualStyleBackColor = true;
            this.CourseMngt.Click += new System.EventHandler(this.CourseMngt_Click);
            // 
            // SubjectMngt
            // 
            this.SubjectMngt.Location = new System.Drawing.Point(169, 149);
            this.SubjectMngt.Name = "SubjectMngt";
            this.SubjectMngt.Size = new System.Drawing.Size(190, 23);
            this.SubjectMngt.TabIndex = 2;
            this.SubjectMngt.Text = "Subject Managemnt";
            this.SubjectMngt.UseVisualStyleBackColor = true;
            // 
            // FacultyMngt
            // 
            this.FacultyMngt.Location = new System.Drawing.Point(169, 208);
            this.FacultyMngt.Name = "FacultyMngt";
            this.FacultyMngt.Size = new System.Drawing.Size(190, 23);
            this.FacultyMngt.TabIndex = 3;
            this.FacultyMngt.Text = "Faculty Managemnt";
            this.FacultyMngt.UseVisualStyleBackColor = true;
            // 
            // SectionMngt
            // 
            this.SectionMngt.Location = new System.Drawing.Point(169, 268);
            this.SectionMngt.Name = "SectionMngt";
            this.SectionMngt.Size = new System.Drawing.Size(190, 23);
            this.SectionMngt.TabIndex = 4;
            this.SectionMngt.Text = "Section Managemnt";
            this.SectionMngt.UseVisualStyleBackColor = true;
            // 
            // ScheduleMngt
            // 
            this.ScheduleMngt.Location = new System.Drawing.Point(169, 324);
            this.ScheduleMngt.Name = "ScheduleMngt";
            this.ScheduleMngt.Size = new System.Drawing.Size(190, 23);
            this.ScheduleMngt.TabIndex = 5;
            this.ScheduleMngt.Text = "Schedule Managemnt";
            this.ScheduleMngt.UseVisualStyleBackColor = true;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Location = new System.Drawing.Point(169, 384);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(190, 23);
            this.Logoutbtn.TabIndex = 6;
            this.Logoutbtn.Text = "Log Out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.ScheduleMngt);
            this.Controls.Add(this.SectionMngt);
            this.Controls.Add(this.FacultyMngt);
            this.Controls.Add(this.SubjectMngt);
            this.Controls.Add(this.CourseMngt);
            this.Controls.Add(this.StudentMngt);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentMngt;
        private System.Windows.Forms.Button CourseMngt;
        private System.Windows.Forms.Button SubjectMngt;
        private System.Windows.Forms.Button FacultyMngt;
        private System.Windows.Forms.Button SectionMngt;
        private System.Windows.Forms.Button ScheduleMngt;
        private System.Windows.Forms.Button Logoutbtn;
    }
}