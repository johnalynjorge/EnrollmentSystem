
namespace EnrollmentSystem
{
    partial class facultymenu
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
            this.fIDtxt = new System.Windows.Forms.TextBox();
            this.fLasttxt = new System.Windows.Forms.TextBox();
            this.fFirsttxt = new System.Windows.Forms.TextBox();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.Depcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewfaculty = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faculty Management";
            // 
            // fIDtxt
            // 
            this.fIDtxt.Enabled = false;
            this.fIDtxt.Location = new System.Drawing.Point(124, 109);
            this.fIDtxt.Name = "fIDtxt";
            this.fIDtxt.Size = new System.Drawing.Size(200, 20);
            this.fIDtxt.TabIndex = 3;
            // 
            // fLasttxt
            // 
            this.fLasttxt.Location = new System.Drawing.Point(378, 109);
            this.fLasttxt.Name = "fLasttxt";
            this.fLasttxt.Size = new System.Drawing.Size(200, 20);
            this.fLasttxt.TabIndex = 4;
            this.fLasttxt.TextChanged += new System.EventHandler(this.fLasttxt_TextChanged);
            // 
            // fFirsttxt
            // 
            this.fFirsttxt.Location = new System.Drawing.Point(632, 109);
            this.fFirsttxt.Name = "fFirsttxt";
            this.fFirsttxt.Size = new System.Drawing.Size(200, 20);
            this.fFirsttxt.TabIndex = 5;
            // 
            // contacttxt
            // 
            this.contacttxt.Location = new System.Drawing.Point(124, 168);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(200, 20);
            this.contacttxt.TabIndex = 6;
            // 
            // Depcombo
            // 
            this.Depcombo.FormattingEnabled = true;
            this.Depcombo.Location = new System.Drawing.Point(378, 167);
            this.Depcombo.Name = "Depcombo";
            this.Depcombo.Size = new System.Drawing.Size(200, 21);
            this.Depcombo.TabIndex = 7;
            this.Depcombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Depcombo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instructor ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contact Number::";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Department:";
            // 
            // dataGridViewfaculty
            // 
            this.dataGridViewfaculty.AllowUserToAddRows = false;
            this.dataGridViewfaculty.AllowUserToDeleteRows = false;
            this.dataGridViewfaculty.AllowUserToResizeRows = false;
            this.dataGridViewfaculty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewfaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfaculty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewfaculty.Location = new System.Drawing.Point(34, 312);
            this.dataGridViewfaculty.Name = "dataGridViewfaculty";
            this.dataGridViewfaculty.RowHeadersVisible = false;
            this.dataGridViewfaculty.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewfaculty.Size = new System.Drawing.Size(910, 224);
            this.dataGridViewfaculty.TabIndex = 48;
            this.dataGridViewfaculty.VirtualMode = true;
            this.dataGridViewfaculty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewfaculty_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Search:";
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(240, 273);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(554, 20);
            this.searchtxt.TabIndex = 46;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(718, 208);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(114, 23);
            this.deletebtn.TabIndex = 51;
            this.deletebtn.Text = "Delete Instructor";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(567, 208);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(114, 23);
            this.editbtn.TabIndex = 50;
            this.editbtn.Text = "Edit Instructor";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(416, 208);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(114, 23);
            this.createbtn.TabIndex = 49;
            this.createbtn.Text = "Add Instructor";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(265, 208);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(114, 23);
            this.clearbtn.TabIndex = 52;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // facultymenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.dataGridViewfaculty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Depcombo);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.fFirsttxt);
            this.Controls.Add(this.fLasttxt);
            this.Controls.Add(this.fIDtxt);
            this.Controls.Add(this.label1);
            this.Name = "facultymenu";
            this.Text = "facultymenu";
            this.Load += new System.EventHandler(this.facultymenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fIDtxt;
        private System.Windows.Forms.TextBox fLasttxt;
        private System.Windows.Forms.TextBox fFirsttxt;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.ComboBox Depcombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewfaculty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button clearbtn;
    }
}