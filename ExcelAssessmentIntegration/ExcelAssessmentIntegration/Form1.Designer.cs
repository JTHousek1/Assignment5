﻿namespace ExcelAssessmentIntegration
{
    partial class ExcelIntegrationAssessmentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelIntegrationAssessmentWindow));
            this.filterCriteriaGrpBx = new System.Windows.Forms.GroupBox();
            this.noneRB = new System.Windows.Forms.RadioButton();
            this.sectionRB = new System.Windows.Forms.RadioButton();
            this.courseRB = new System.Windows.Forms.RadioButton();
            this.semesterRB = new System.Windows.Forms.RadioButton();
            this.yearRB = new System.Windows.Forms.RadioButton();
            this.semesterCmBx = new System.Windows.Forms.ComboBox();
            this.courseCmBx = new System.Windows.Forms.ComboBox();
            this.readExcelBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.consoleBoxLB = new System.Windows.Forms.Label();
            this.consoleBxLB = new System.Windows.Forms.Label();
            this.consoleOutputTxB = new System.Windows.Forms.TextBox();
            this.yearCmBx = new System.Windows.Forms.ComboBox();
            this.sectionCmBx = new System.Windows.Forms.ComboBox();
            this.filesLBx = new System.Windows.Forms.ListBox();
            this.selectedFilesLBx = new System.Windows.Forms.ListBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.addSheetBtn = new System.Windows.Forms.Button();
            this.removeSheetBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filterCriteriaGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterCriteriaGrpBx
            // 
            this.filterCriteriaGrpBx.Controls.Add(this.noneRB);
            this.filterCriteriaGrpBx.Controls.Add(this.sectionRB);
            this.filterCriteriaGrpBx.Controls.Add(this.courseRB);
            this.filterCriteriaGrpBx.Controls.Add(this.semesterRB);
            this.filterCriteriaGrpBx.Controls.Add(this.yearRB);
            this.filterCriteriaGrpBx.Location = new System.Drawing.Point(12, 152);
            this.filterCriteriaGrpBx.Name = "filterCriteriaGrpBx";
            this.filterCriteriaGrpBx.Size = new System.Drawing.Size(106, 141);
            this.filterCriteriaGrpBx.TabIndex = 1;
            this.filterCriteriaGrpBx.TabStop = false;
            this.filterCriteriaGrpBx.Text = "Filter Criteria";
            // 
            // noneRB
            // 
            this.noneRB.AutoSize = true;
            this.noneRB.Location = new System.Drawing.Point(6, 19);
            this.noneRB.Name = "noneRB";
            this.noneRB.Size = new System.Drawing.Size(51, 17);
            this.noneRB.TabIndex = 0;
            this.noneRB.TabStop = true;
            this.noneRB.Text = "None";
            this.noneRB.UseVisualStyleBackColor = true;
            // 
            // sectionRB
            // 
            this.sectionRB.AutoSize = true;
            this.sectionRB.Location = new System.Drawing.Point(6, 111);
            this.sectionRB.Name = "sectionRB";
            this.sectionRB.Size = new System.Drawing.Size(61, 17);
            this.sectionRB.TabIndex = 3;
            this.sectionRB.TabStop = true;
            this.sectionRB.Text = "Section";
            this.sectionRB.UseVisualStyleBackColor = true;
            this.sectionRB.CheckedChanged += new System.EventHandler(this.filterCriteriaGrpBx_CheckedChanged);
            // 
            // courseRB
            // 
            this.courseRB.AutoSize = true;
            this.courseRB.Location = new System.Drawing.Point(6, 88);
            this.courseRB.Name = "courseRB";
            this.courseRB.Size = new System.Drawing.Size(58, 17);
            this.courseRB.TabIndex = 2;
            this.courseRB.TabStop = true;
            this.courseRB.Text = "Course";
            this.courseRB.UseVisualStyleBackColor = true;
            this.courseRB.CheckedChanged += new System.EventHandler(this.filterCriteriaGrpBx_CheckedChanged);
            // 
            // semesterRB
            // 
            this.semesterRB.AutoSize = true;
            this.semesterRB.Location = new System.Drawing.Point(6, 65);
            this.semesterRB.Name = "semesterRB";
            this.semesterRB.Size = new System.Drawing.Size(69, 17);
            this.semesterRB.TabIndex = 1;
            this.semesterRB.TabStop = true;
            this.semesterRB.Text = "Semester";
            this.semesterRB.UseVisualStyleBackColor = true;
            this.semesterRB.CheckedChanged += new System.EventHandler(this.filterCriteriaGrpBx_CheckedChanged);
            // 
            // yearRB
            // 
            this.yearRB.AutoSize = true;
            this.yearRB.Location = new System.Drawing.Point(6, 42);
            this.yearRB.Name = "yearRB";
            this.yearRB.Size = new System.Drawing.Size(47, 17);
            this.yearRB.TabIndex = 0;
            this.yearRB.TabStop = true;
            this.yearRB.Text = "Year";
            this.yearRB.UseVisualStyleBackColor = true;
            this.yearRB.CheckedChanged += new System.EventHandler(this.filterCriteriaGrpBx_CheckedChanged);
            // 
            // semesterCmBx
            // 
            this.semesterCmBx.Enabled = false;
            this.semesterCmBx.FormattingEnabled = true;
            this.semesterCmBx.Location = new System.Drawing.Point(276, 171);
            this.semesterCmBx.Name = "semesterCmBx";
            this.semesterCmBx.Size = new System.Drawing.Size(121, 21);
            this.semesterCmBx.TabIndex = 3;
            // 
            // courseCmBx
            // 
            this.courseCmBx.Enabled = false;
            this.courseCmBx.FormattingEnabled = true;
            this.courseCmBx.Location = new System.Drawing.Point(417, 171);
            this.courseCmBx.Name = "courseCmBx";
            this.courseCmBx.Size = new System.Drawing.Size(121, 21);
            this.courseCmBx.TabIndex = 4;
            // 
            // readExcelBtn
            // 
            this.readExcelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.readExcelBtn.Location = new System.Drawing.Point(234, 234);
            this.readExcelBtn.Name = "readExcelBtn";
            this.readExcelBtn.Size = new System.Drawing.Size(136, 23);
            this.readExcelBtn.TabIndex = 6;
            this.readExcelBtn.Text = "Read Excel Sheets";
            this.readExcelBtn.UseVisualStyleBackColor = true;
            this.readExcelBtn.Click += new System.EventHandler(this.ReadExcelBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(417, 234);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(136, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Year (Format: YY)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Section (Format: SS)";
            // 
            // consoleBoxLB
            // 
            this.consoleBoxLB.Location = new System.Drawing.Point(0, 0);
            this.consoleBoxLB.Name = "consoleBoxLB";
            this.consoleBoxLB.Size = new System.Drawing.Size(100, 23);
            this.consoleBoxLB.TabIndex = 16;
            // 
            // consoleBxLB
            // 
            this.consoleBxLB.AutoSize = true;
            this.consoleBxLB.Location = new System.Drawing.Point(443, 279);
            this.consoleBxLB.Name = "consoleBxLB";
            this.consoleBxLB.Size = new System.Drawing.Size(45, 13);
            this.consoleBxLB.TabIndex = 17;
            this.consoleBxLB.Text = "Console";
            this.consoleBxLB.Visible = false;
            // 
            // consoleOutputTxB
            // 
            this.consoleOutputTxB.Location = new System.Drawing.Point(446, 295);
            this.consoleOutputTxB.Multiline = true;
            this.consoleOutputTxB.Name = "consoleOutputTxB";
            this.consoleOutputTxB.Size = new System.Drawing.Size(237, 53);
            this.consoleOutputTxB.TabIndex = 18;
            this.consoleOutputTxB.Visible = false;
            // 
            // yearCmBx
            // 
            this.yearCmBx.Enabled = false;
            this.yearCmBx.FormattingEnabled = true;
            this.yearCmBx.Location = new System.Drawing.Point(136, 171);
            this.yearCmBx.Name = "yearCmBx";
            this.yearCmBx.Size = new System.Drawing.Size(121, 21);
            this.yearCmBx.TabIndex = 20;
            // 
            // sectionCmBx
            // 
            this.sectionCmBx.Enabled = false;
            this.sectionCmBx.FormattingEnabled = true;
            this.sectionCmBx.Location = new System.Drawing.Point(562, 171);
            this.sectionCmBx.Name = "sectionCmBx";
            this.sectionCmBx.Size = new System.Drawing.Size(121, 21);
            this.sectionCmBx.TabIndex = 21;
            // 
            // filesLBx
            // 
            this.filesLBx.FormattingEnabled = true;
            this.filesLBx.Location = new System.Drawing.Point(12, 25);
            this.filesLBx.Name = "filesLBx";
            this.filesLBx.Size = new System.Drawing.Size(280, 121);
            this.filesLBx.TabIndex = 22;
            // 
            // selectedFilesLBx
            // 
            this.selectedFilesLBx.FormattingEnabled = true;
            this.selectedFilesLBx.Location = new System.Drawing.Point(410, 25);
            this.selectedFilesLBx.Name = "selectedFilesLBx";
            this.selectedFilesLBx.Size = new System.Drawing.Size(280, 121);
            this.selectedFilesLBx.TabIndex = 23;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(325, 205);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(136, 23);
            this.filterBtn.TabIndex = 24;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // addSheetBtn
            // 
            this.addSheetBtn.Location = new System.Drawing.Point(309, 38);
            this.addSheetBtn.Name = "addSheetBtn";
            this.addSheetBtn.Size = new System.Drawing.Size(75, 23);
            this.addSheetBtn.TabIndex = 25;
            this.addSheetBtn.Text = "Add >>";
            this.addSheetBtn.UseVisualStyleBackColor = true;
            this.addSheetBtn.Click += new System.EventHandler(this.AddSheetBtn_Click);
            // 
            // removeSheetBtn
            // 
            this.removeSheetBtn.Location = new System.Drawing.Point(309, 79);
            this.removeSheetBtn.Name = "removeSheetBtn";
            this.removeSheetBtn.Size = new System.Drawing.Size(75, 23);
            this.removeSheetBtn.TabIndex = 26;
            this.removeSheetBtn.Text = "<< Remove";
            this.removeSheetBtn.UseVisualStyleBackColor = true;
            this.removeSheetBtn.Click += new System.EventHandler(this.RemoveSheetBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Available Files";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Selected Files for Processing";
            // 
            // ExcelIntegrationAssessmentWindow
            // 
            this.AcceptButton = this.readExcelBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(706, 362);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeSheetBtn);
            this.Controls.Add(this.addSheetBtn);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.selectedFilesLBx);
            this.Controls.Add(this.filesLBx);
            this.Controls.Add(this.sectionCmBx);
            this.Controls.Add(this.yearCmBx);
            this.Controls.Add(this.consoleOutputTxB);
            this.Controls.Add(this.consoleBxLB);
            this.Controls.Add(this.consoleBoxLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.readExcelBtn);
            this.Controls.Add(this.courseCmBx);
            this.Controls.Add(this.semesterCmBx);
            this.Controls.Add(this.filterCriteriaGrpBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelIntegrationAssessmentWindow";
            this.Text = "Excel Integration Assessment";
            this.Load += new System.EventHandler(this.formOnLoad);
            this.filterCriteriaGrpBx.ResumeLayout(false);
            this.filterCriteriaGrpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox filterCriteriaGrpBx;
        private System.Windows.Forms.RadioButton sectionRB;
        private System.Windows.Forms.RadioButton courseRB;
        private System.Windows.Forms.RadioButton semesterRB;
        private System.Windows.Forms.RadioButton yearRB;
        private System.Windows.Forms.ComboBox semesterCmBx;
        private System.Windows.Forms.ComboBox courseCmBx;
        private System.Windows.Forms.Button readExcelBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton noneRB;
        private System.Windows.Forms.Label consoleBoxLB;
        private System.Windows.Forms.Label consoleBxLB;
        private System.Windows.Forms.TextBox consoleOutputTxB;
        private System.Windows.Forms.ComboBox yearCmBx;
        private System.Windows.Forms.ComboBox sectionCmBx;
        private System.Windows.Forms.ListBox filesLBx;
        private System.Windows.Forms.ListBox selectedFilesLBx;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button addSheetBtn;
        private System.Windows.Forms.Button removeSheetBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

