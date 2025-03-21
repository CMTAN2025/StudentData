﻿namespace DXApplication1
{
    partial class StudentData
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
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grpControlListOfStudent = new DevExpress.XtraEditors.GroupControl();
            this.grdControlListOfStudent = new DevExpress.XtraGrid.GridControl();
            this.grdViewListOfStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Course = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YearLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblControlSearch = new DevExpress.XtraEditors.LabelControl();
            this.txtEditSearchStudent = new DevExpress.XtraEditors.TextEdit();
            this.txtEditYearLevel = new DevExpress.XtraEditors.TextEdit();
            this.txtEditCourse = new DevExpress.XtraEditors.TextEdit();
            this.txtEditAge = new DevExpress.XtraEditors.TextEdit();
            this.txtEditLastName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblControlStudentData = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchStudent = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grpControlListOfStudent)).BeginInit();
            this.grpControlListOfStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlListOfStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListOfStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSearchStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditYearLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditFirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Location = new System.Drawing.Point(441, 183);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(264, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(63, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpControlListOfStudent
            // 
            this.grpControlListOfStudent.Controls.Add(this.btnSearchStudent);
            this.grpControlListOfStudent.Controls.Add(this.grdControlListOfStudent);
            this.grpControlListOfStudent.Controls.Add(this.lblControlSearch);
            this.grpControlListOfStudent.Controls.Add(this.txtEditSearchStudent);
            this.grpControlListOfStudent.Location = new System.Drawing.Point(116, 239);
            this.grpControlListOfStudent.Name = "grpControlListOfStudent";
            this.grpControlListOfStudent.Size = new System.Drawing.Size(595, 309);
            this.grpControlListOfStudent.TabIndex = 31;
            this.grpControlListOfStudent.Text = "LIST OF STUDENTS";
            // 
            // grdControlListOfStudent
            // 
            this.grdControlListOfStudent.Location = new System.Drawing.Point(11, 68);
            this.grdControlListOfStudent.MainView = this.grdViewListOfStudent;
            this.grdControlListOfStudent.Name = "grdControlListOfStudent";
            this.grdControlListOfStudent.Size = new System.Drawing.Size(549, 236);
            this.grdControlListOfStudent.TabIndex = 8;
            this.grdControlListOfStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewListOfStudent});
            // 
            // grdViewListOfStudent
            // 
            this.grdViewListOfStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.Age,
            this.Course,
            this.YearLevel});
            this.grdViewListOfStudent.GridControl = this.grdControlListOfStudent;
            this.grdViewListOfStudent.Name = "grdViewListOfStudent";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 25;
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            this.FirstName.Width = 94;
            // 
            // MiddleName
            // 
            this.MiddleName.Caption = "Middle Name";
            this.MiddleName.FieldName = "MiddleName";
            this.MiddleName.MinWidth = 25;
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Visible = true;
            this.MiddleName.VisibleIndex = 1;
            this.MiddleName.Width = 94;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 25;
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 2;
            this.LastName.Width = 94;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 25;
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 3;
            this.Age.Width = 94;
            // 
            // Course
            // 
            this.Course.Caption = "Course";
            this.Course.FieldName = "Course";
            this.Course.MinWidth = 25;
            this.Course.Name = "Course";
            this.Course.Visible = true;
            this.Course.VisibleIndex = 4;
            this.Course.Width = 94;
            // 
            // YearLevel
            // 
            this.YearLevel.Caption = "Year Level";
            this.YearLevel.FieldName = "YearLevel";
            this.YearLevel.MinWidth = 25;
            this.YearLevel.Name = "YearLevel";
            this.YearLevel.Visible = true;
            this.YearLevel.VisibleIndex = 5;
            this.YearLevel.Width = 94;
            // 
            // lblControlSearch
            // 
            this.lblControlSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlSearch.Appearance.Options.UseFont = true;
            this.lblControlSearch.Location = new System.Drawing.Point(11, 37);
            this.lblControlSearch.Name = "lblControlSearch";
            this.lblControlSearch.Size = new System.Drawing.Size(67, 24);
            this.lblControlSearch.TabIndex = 7;
            this.lblControlSearch.Text = "Search:";
            // 
            // txtEditSearchStudent
            // 
            this.txtEditSearchStudent.Location = new System.Drawing.Point(82, 40);
            this.txtEditSearchStudent.Name = "txtEditSearchStudent";
            this.txtEditSearchStudent.Size = new System.Drawing.Size(234, 22);
            this.txtEditSearchStudent.TabIndex = 1;
            // 
            // txtEditYearLevel
            // 
            this.txtEditYearLevel.Location = new System.Drawing.Point(604, 134);
            this.txtEditYearLevel.Name = "txtEditYearLevel";
            this.txtEditYearLevel.Size = new System.Drawing.Size(54, 22);
            this.txtEditYearLevel.TabIndex = 30;
            // 
            // txtEditCourse
            // 
            this.txtEditCourse.Location = new System.Drawing.Point(342, 134);
            this.txtEditCourse.Name = "txtEditCourse";
            this.txtEditCourse.Size = new System.Drawing.Size(175, 22);
            this.txtEditCourse.TabIndex = 29;
            // 
            // txtEditAge
            // 
            this.txtEditAge.Location = new System.Drawing.Point(38, 134);
            this.txtEditAge.Name = "txtEditAge";
            this.txtEditAge.Size = new System.Drawing.Size(133, 22);
            this.txtEditAge.TabIndex = 28;
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(604, 60);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(204, 22);
            this.txtEditLastName.TabIndex = 27;
            // 
            // txtEditMiddleName
            // 
            this.txtEditMiddleName.Location = new System.Drawing.Point(342, 60);
            this.txtEditMiddleName.Name = "txtEditMiddleName";
            this.txtEditMiddleName.Size = new System.Drawing.Size(175, 22);
            this.txtEditMiddleName.TabIndex = 26;
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(38, 60);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(213, 22);
            this.txtEditFirstName.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(570, 38);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 16);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "Last Name:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(319, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Middle Name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(572, 104);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Year Level:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(319, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 16);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Course:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 16);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Age:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 16);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = "First Name:";
            // 
            // lblControlStudentData
            // 
            this.lblControlStudentData.Appearance.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlStudentData.Appearance.Options.UseFont = true;
            this.lblControlStudentData.Location = new System.Drawing.Point(382, -32);
            this.lblControlStudentData.Name = "lblControlStudentData";
            this.lblControlStudentData.Size = new System.Drawing.Size(154, 24);
            this.lblControlStudentData.TabIndex = 18;
            this.lblControlStudentData.Text = "STUDENT DATA";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(294, -1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(258, 25);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "STUDENT DATA FORM";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchStudent.Appearance.Options.UseFont = true;
            this.btnSearchStudent.Appearance.Options.UseForeColor = true;
            this.btnSearchStudent.Location = new System.Drawing.Point(342, 35);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(77, 29);
            this.btnSearchStudent.TabIndex = 36;
            this.btnSearchStudent.Text = "SEARCH";
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // StudentData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 583);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpControlListOfStudent);
            this.Controls.Add(this.txtEditYearLevel);
            this.Controls.Add(this.txtEditCourse);
            this.Controls.Add(this.txtEditAge);
            this.Controls.Add(this.txtEditLastName);
            this.Controls.Add(this.txtEditMiddleName);
            this.Controls.Add(this.txtEditFirstName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblControlStudentData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentData";
            this.Text = "Student Data";
            ((System.ComponentModel.ISupportInitialize)(this.grpControlListOfStudent)).EndInit();
            this.grpControlListOfStudent.ResumeLayout(false);
            this.grpControlListOfStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdControlListOfStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewListOfStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditSearchStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditYearLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditCourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditFirstName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl grpControlListOfStudent;
        private DevExpress.XtraEditors.LabelControl lblControlSearch;
        private DevExpress.XtraEditors.TextEdit txtEditSearchStudent;
        private DevExpress.XtraEditors.TextEdit txtEditYearLevel;
        private DevExpress.XtraEditors.TextEdit txtEditCourse;
        private DevExpress.XtraEditors.TextEdit txtEditAge;
        private DevExpress.XtraEditors.TextEdit txtEditLastName;
        private DevExpress.XtraEditors.TextEdit txtEditMiddleName;
        private DevExpress.XtraEditors.TextEdit txtEditFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblControlStudentData;
        private DevExpress.XtraGrid.GridControl grdControlListOfStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewListOfStudent;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn MiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn Course;
        private DevExpress.XtraGrid.Columns.GridColumn YearLevel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearchStudent;
    }
}

