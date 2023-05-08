namespace Exam_Routine_Sceduler
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.FirstBatch = new System.Windows.Forms.Label();
            this.Enter1 = new System.Windows.Forms.Button();
            this.Enter2 = new System.Windows.Forms.Button();
            this.Enter3 = new System.Windows.Forms.Button();
            this.Enter4 = new System.Windows.Forms.Button();
            this.SecondBatch = new System.Windows.Forms.Label();
            this.ThirdBatch = new System.Windows.Forms.Label();
            this.FourthBatch = new System.Windows.Forms.Label();
            this.subjectList1 = new System.Windows.Forms.TextBox();
            this.subjectList2 = new System.Windows.Forms.TextBox();
            this.subjectList3 = new System.Windows.Forms.TextBox();
            this.subjectList4 = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsExcelToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsExcelToolStripMenuItem
            // 
            this.saveAsExcelToolStripMenuItem.Name = "saveAsExcelToolStripMenuItem";
            this.saveAsExcelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.saveAsExcelToolStripMenuItem.Text = "Save as Excel";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Running Batch";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AllowDrop = true;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"});
            this.checkedListBox1.Location = new System.Drawing.Point(170, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // FirstBatch
            // 
            this.FirstBatch.AutoSize = true;
            this.FirstBatch.Location = new System.Drawing.Point(13, 158);
            this.FirstBatch.Name = "FirstBatch";
            this.FirstBatch.Size = new System.Drawing.Size(57, 13);
            this.FirstBatch.TabIndex = 4;
            this.FirstBatch.Text = "First Batch";
            // 
            // Enter1
            // 
            this.Enter1.Location = new System.Drawing.Point(670, 152);
            this.Enter1.Name = "Enter1";
            this.Enter1.Size = new System.Drawing.Size(75, 23);
            this.Enter1.TabIndex = 5;
            this.Enter1.Text = "Enter";
            this.Enter1.UseVisualStyleBackColor = true;
            this.Enter1.Click += new System.EventHandler(this.Enter1_Click);
            // 
            // Enter2
            // 
            this.Enter2.Location = new System.Drawing.Point(670, 181);
            this.Enter2.Name = "Enter2";
            this.Enter2.Size = new System.Drawing.Size(75, 23);
            this.Enter2.TabIndex = 5;
            this.Enter2.Text = "Enter";
            this.Enter2.UseVisualStyleBackColor = true;
            this.Enter2.Click += new System.EventHandler(this.Enter2_Click);
            // 
            // Enter3
            // 
            this.Enter3.Location = new System.Drawing.Point(670, 210);
            this.Enter3.Name = "Enter3";
            this.Enter3.Size = new System.Drawing.Size(75, 23);
            this.Enter3.TabIndex = 5;
            this.Enter3.Text = "Enter";
            this.Enter3.UseVisualStyleBackColor = true;
            this.Enter3.Click += new System.EventHandler(this.Enter3_Click);
            // 
            // Enter4
            // 
            this.Enter4.Location = new System.Drawing.Point(670, 239);
            this.Enter4.Name = "Enter4";
            this.Enter4.Size = new System.Drawing.Size(75, 23);
            this.Enter4.TabIndex = 5;
            this.Enter4.Text = "Enter";
            this.Enter4.UseVisualStyleBackColor = true;
            this.Enter4.Click += new System.EventHandler(this.Enter4_Click);
            // 
            // SecondBatch
            // 
            this.SecondBatch.AutoSize = true;
            this.SecondBatch.Location = new System.Drawing.Point(12, 187);
            this.SecondBatch.Name = "SecondBatch";
            this.SecondBatch.Size = new System.Drawing.Size(75, 13);
            this.SecondBatch.TabIndex = 4;
            this.SecondBatch.Text = "Second Batch";
            // 
            // ThirdBatch
            // 
            this.ThirdBatch.AutoSize = true;
            this.ThirdBatch.Location = new System.Drawing.Point(12, 216);
            this.ThirdBatch.Name = "ThirdBatch";
            this.ThirdBatch.Size = new System.Drawing.Size(62, 13);
            this.ThirdBatch.TabIndex = 4;
            this.ThirdBatch.Text = "Third Batch";
            // 
            // FourthBatch
            // 
            this.FourthBatch.AutoSize = true;
            this.FourthBatch.Location = new System.Drawing.Point(12, 245);
            this.FourthBatch.Name = "FourthBatch";
            this.FourthBatch.Size = new System.Drawing.Size(68, 13);
            this.FourthBatch.TabIndex = 4;
            this.FourthBatch.Text = "Fourth Batch";
            // 
            // subjectList1
            // 
            this.subjectList1.Location = new System.Drawing.Point(170, 154);
            this.subjectList1.Name = "subjectList1";
            this.subjectList1.Size = new System.Drawing.Size(478, 20);
            this.subjectList1.TabIndex = 6;
            // 
            // subjectList2
            // 
            this.subjectList2.Location = new System.Drawing.Point(170, 183);
            this.subjectList2.Name = "subjectList2";
            this.subjectList2.Size = new System.Drawing.Size(478, 20);
            this.subjectList2.TabIndex = 6;
            // 
            // subjectList3
            // 
            this.subjectList3.Location = new System.Drawing.Point(170, 212);
            this.subjectList3.Name = "subjectList3";
            this.subjectList3.Size = new System.Drawing.Size(478, 20);
            this.subjectList3.TabIndex = 6;
            // 
            // subjectList4
            // 
            this.subjectList4.Location = new System.Drawing.Point(170, 241);
            this.subjectList4.Name = "subjectList4";
            this.subjectList4.Size = new System.Drawing.Size(478, 20);
            this.subjectList4.TabIndex = 6;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(569, 61);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 7;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(771, 28);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.subjectList4);
            this.Controls.Add(this.subjectList3);
            this.Controls.Add(this.subjectList2);
            this.Controls.Add(this.subjectList1);
            this.Controls.Add(this.Enter4);
            this.Controls.Add(this.Enter3);
            this.Controls.Add(this.Enter2);
            this.Controls.Add(this.Enter1);
            this.Controls.Add(this.FourthBatch);
            this.Controls.Add(this.ThirdBatch);
            this.Controls.Add(this.SecondBatch);
            this.Controls.Add(this.FirstBatch);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Exam Scheduler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label FirstBatch;
        private System.Windows.Forms.Button Enter1;
        private System.Windows.Forms.Button Enter2;
        private System.Windows.Forms.Button Enter3;
        private System.Windows.Forms.Button Enter4;
        private System.Windows.Forms.Label SecondBatch;
        private System.Windows.Forms.Label ThirdBatch;
        private System.Windows.Forms.Label FourthBatch;
        private System.Windows.Forms.TextBox subjectList1;
        private System.Windows.Forms.TextBox subjectList2;
        private System.Windows.Forms.TextBox subjectList3;
        private System.Windows.Forms.TextBox subjectList4;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

