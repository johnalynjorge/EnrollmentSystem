
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
            this.label2 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridViewcurr = new System.Windows.Forms.DataGridView();
            this.createbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.ComboBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "School Year Start:";
            // 
            // end
            // 
            this.end.FormattingEnabled = true;
            this.end.Location = new System.Drawing.Point(258, 101);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(114, 21);
            this.end.TabIndex = 18;
            this.end.SelectedIndexChanged += new System.EventHandler(this.Coursecb_SelectedIndexChanged);
            this.end.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coursecb_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "School Year End:";
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
            // start
            // 
            this.start.FormattingEnabled = true;
            this.start.Location = new System.Drawing.Point(68, 101);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(114, 21);
            this.start.TabIndex = 47;
            this.start.SelectedIndexChanged += new System.EventHandler(this.start_SelectedIndexChanged);
            this.start.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coursecb_KeyDown);
            // 
            // curriculummenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 566);
            this.Controls.Add(this.start);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.dataGridViewcurr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox end;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dataGridViewcurr;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ComboBox start;
    }
}