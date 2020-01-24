namespace SmartMech.Forms
{
    partial class TeacherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.gridTeachers = new System.Windows.Forms.DataGridView();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridGroups = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearchFIO = new System.Windows.Forms.Button();
            this.txtFIOSearch = new System.Windows.Forms.TextBox();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOMotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOFatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberFatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LFOSearch = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.LStudentsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTeachers
            // 
            this.gridTeachers.AutoGenerateColumns = false;
            this.gridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeacherDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.mobilePhoneDataGridViewTextBoxColumn,
            this.mailBoxDataGridViewTextBoxColumn,
            this.groupsDataGridViewTextBoxColumn});
            this.gridTeachers.DataSource = this.teacherBindingSource;
            this.gridTeachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridTeachers.Location = new System.Drawing.Point(0, 0);
            this.gridTeachers.Name = "gridTeachers";
            this.gridTeachers.ReadOnly = true;
            this.gridTeachers.RowHeadersWidth = 51;
            this.gridTeachers.RowTemplate.Height = 24;
            this.gridTeachers.Size = new System.Drawing.Size(1042, 256);
            this.gridTeachers.TabIndex = 0;
            this.gridTeachers.SelectionChanged += new System.EventHandler(this.GridTeachers_SelectionChanged);
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            this.idTeacherDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTeacherDataGridViewTextBoxColumn.Visible = false;
            this.idTeacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО учителя";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 180;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            this.mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            this.mobilePhoneDataGridViewTextBoxColumn.HeaderText = "Мобильный телефон";
            this.mobilePhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            this.mobilePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobilePhoneDataGridViewTextBoxColumn.Width = 180;
            // 
            // mailBoxDataGridViewTextBoxColumn
            // 
            this.mailBoxDataGridViewTextBoxColumn.DataPropertyName = "MailBox";
            this.mailBoxDataGridViewTextBoxColumn.HeaderText = "Почтовый адрес";
            this.mailBoxDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailBoxDataGridViewTextBoxColumn.Name = "mailBoxDataGridViewTextBoxColumn";
            this.mailBoxDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailBoxDataGridViewTextBoxColumn.Width = 180;
            // 
            // groupsDataGridViewTextBoxColumn
            // 
            this.groupsDataGridViewTextBoxColumn.DataPropertyName = "Groups";
            this.groupsDataGridViewTextBoxColumn.HeaderText = "Groups";
            this.groupsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupsDataGridViewTextBoxColumn.Name = "groupsDataGridViewTextBoxColumn";
            this.groupsDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupsDataGridViewTextBoxColumn.Visible = false;
            this.groupsDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SmartMech.DB.Teacher);
            // 
            // gridGroups
            // 
            this.gridGroups.AutoGenerateColumns = false;
            this.gridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.idTeacherDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.gridGroups.DataSource = this.groupsBindingSource;
            this.gridGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridGroups.Location = new System.Drawing.Point(0, 256);
            this.gridGroups.Name = "gridGroups";
            this.gridGroups.ReadOnly = true;
            this.gridGroups.RowHeadersWidth = 51;
            this.gridGroups.RowTemplate.Height = 24;
            this.gridGroups.Size = new System.Drawing.Size(1042, 142);
            this.gridGroups.TabIndex = 1;
            this.gridGroups.SelectionChanged += new System.EventHandler(this.GridGroups_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdGroup";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdGroup";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GroupName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер группы";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SetName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Название набора";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Day";
            this.dataGridViewTextBoxColumn4.HeaderText = "День недели";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // idTeacherDataGridViewTextBoxColumn2
            // 
            this.idTeacherDataGridViewTextBoxColumn2.DataPropertyName = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn2.HeaderText = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idTeacherDataGridViewTextBoxColumn2.Name = "idTeacherDataGridViewTextBoxColumn2";
            this.idTeacherDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idTeacherDataGridViewTextBoxColumn2.Visible = false;
            this.idTeacherDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Teacher";
            this.dataGridViewTextBoxColumn5.HeaderText = "Teacher";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataSource = typeof(SmartMech.DB.Group);
            // 
            // btnSearchFIO
            // 
            this.btnSearchFIO.Location = new System.Drawing.Point(276, 583);
            this.btnSearchFIO.Name = "btnSearchFIO";
            this.btnSearchFIO.Size = new System.Drawing.Size(137, 23);
            this.btnSearchFIO.TabIndex = 2;
            this.btnSearchFIO.Text = "Поиск";
            this.btnSearchFIO.UseVisualStyleBackColor = true;
            this.btnSearchFIO.Click += new System.EventHandler(this.BtnSearchFIO_Click);
            // 
            // txtFIOSearch
            // 
            this.txtFIOSearch.Location = new System.Drawing.Point(14, 583);
            this.txtFIOSearch.Name = "txtFIOSearch";
            this.txtFIOSearch.Size = new System.Drawing.Size(256, 22);
            this.txtFIOSearch.TabIndex = 3;
            // 
            // gridStudents
            // 
            this.gridStudents.AutoGenerateColumns = false;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn,
            this.fIOMotherDataGridViewTextBoxColumn,
            this.numberMotherDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.fIOFatherDataGridViewTextBoxColumn,
            this.numberFatherDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.gridStudents.DataSource = this.studentBindingSource;
            this.gridStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridStudents.Location = new System.Drawing.Point(0, 398);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.ReadOnly = true;
            this.gridStudents.RowHeadersWidth = 51;
            this.gridStudents.RowTemplate.Height = 24;
            this.gridStudents.Size = new System.Drawing.Size(1042, 142);
            this.gridStudents.TabIndex = 4;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStudentDataGridViewTextBoxColumn.Visible = false;
            this.idStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            this.fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn1.HeaderText = "ФИО студента";
            this.fIODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
            this.fIODataGridViewTextBoxColumn1.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn1.Width = 180;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 180;
            // 
            // fIOMotherDataGridViewTextBoxColumn
            // 
            this.fIOMotherDataGridViewTextBoxColumn.DataPropertyName = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn.HeaderText = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOMotherDataGridViewTextBoxColumn.Name = "fIOMotherDataGridViewTextBoxColumn";
            this.fIOMotherDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOMotherDataGridViewTextBoxColumn.Visible = false;
            this.fIOMotherDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberMotherDataGridViewTextBoxColumn
            // 
            this.numberMotherDataGridViewTextBoxColumn.DataPropertyName = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn.HeaderText = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberMotherDataGridViewTextBoxColumn.Name = "numberMotherDataGridViewTextBoxColumn";
            this.numberMotherDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberMotherDataGridViewTextBoxColumn.Visible = false;
            this.numberMotherDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdGroup";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdGroup";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // fIOFatherDataGridViewTextBoxColumn
            // 
            this.fIOFatherDataGridViewTextBoxColumn.DataPropertyName = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn.HeaderText = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOFatherDataGridViewTextBoxColumn.Name = "fIOFatherDataGridViewTextBoxColumn";
            this.fIOFatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIOFatherDataGridViewTextBoxColumn.Visible = false;
            this.fIOFatherDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberFatherDataGridViewTextBoxColumn
            // 
            this.numberFatherDataGridViewTextBoxColumn.DataPropertyName = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn.HeaderText = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberFatherDataGridViewTextBoxColumn.Name = "numberFatherDataGridViewTextBoxColumn";
            this.numberFatherDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberFatherDataGridViewTextBoxColumn.Visible = false;
            this.numberFatherDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupDataGridViewTextBoxColumn.Visible = false;
            this.groupDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SmartMech.DB.Student);
            // 
            // LFOSearch
            // 
            this.LFOSearch.AutoSize = true;
            this.LFOSearch.Location = new System.Drawing.Point(69, 563);
            this.LFOSearch.Name = "LFOSearch";
            this.LFOSearch.Size = new System.Drawing.Size(159, 17);
            this.LFOSearch.TabIndex = 5;
            this.LFOSearch.Text = "Введите ФИО учителя";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1042, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LStatusDate
            // 
            this.LStatusDate.BackColor = System.Drawing.SystemColors.Control;
            this.LStatusDate.Name = "LStatusDate";
            this.LStatusDate.Size = new System.Drawing.Size(88, 20);
            this.LStatusDate.Text = "LStatusDate";
            // 
            // LStatusDayWeek
            // 
            this.LStatusDayWeek.BackColor = System.Drawing.SystemColors.Control;
            this.LStatusDayWeek.Name = "LStatusDayWeek";
            this.LStatusDayWeek.Size = new System.Drawing.Size(118, 20);
            this.LStatusDayWeek.Text = "LStatusDayWeek";
            // 
            // LStatusTime
            // 
            this.LStatusTime.BackColor = System.Drawing.SystemColors.Control;
            this.LStatusTime.Name = "LStatusTime";
            this.LStatusTime.Size = new System.Drawing.Size(63, 20);
            this.LStatusTime.Text = "00:00:00";
            // 
            // DateTimer
            // 
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // LStudentsCount
            // 
            this.LStudentsCount.AutoSize = true;
            this.LStudentsCount.Location = new System.Drawing.Point(833, 547);
            this.LStudentsCount.Name = "LStudentsCount";
            this.LStudentsCount.Size = new System.Drawing.Size(0, 17);
            this.LStudentsCount.TabIndex = 7;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 658);
            this.Controls.Add(this.LStudentsCount);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LFOSearch);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.txtFIOSearch);
            this.Controls.Add(this.btnSearchFIO);
            this.Controls.Add(this.gridGroups);
            this.Controls.Add(this.gridTeachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все учителя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridView gridGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.Button btnSearchFIO;
        private System.Windows.Forms.TextBox txtFIOSearch;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOMotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOFatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Label LFOSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDayWeek;
        private System.Windows.Forms.ToolStripStatusLabel LStatusTime;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Label LStudentsCount;
    }
}