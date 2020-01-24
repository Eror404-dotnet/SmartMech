namespace SmartMech.Forms
{
    partial class StudentsFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsFrom));
            this.gridStudent = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOMotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMotherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOFatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberFatherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridMother = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridFather = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFIOSearch = new System.Windows.Forms.TextBox();
            this.lFIOSearch = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMother)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFather)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridStudent
            // 
            this.gridStudent.AutoGenerateColumns = false;
            this.gridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.fIOMotherDataGridViewTextBoxColumn,
            this.numberMotherDataGridViewTextBoxColumn,
            this.idGroupDataGridViewTextBoxColumn,
            this.fIOFatherDataGridViewTextBoxColumn,
            this.numberFatherDataGridViewTextBoxColumn});
            this.gridStudent.DataSource = this.studentBindingSource;
            this.gridStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridStudent.Location = new System.Drawing.Point(0, 0);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.ReadOnly = true;
            this.gridStudent.RowHeadersWidth = 51;
            this.gridStudent.RowTemplate.Height = 24;
            this.gridStudent.Size = new System.Drawing.Size(843, 150);
            this.gridStudent.TabIndex = 0;
            this.gridStudent.SelectionChanged += new System.EventHandler(this.GridStudent_SelectionChanged);
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
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО студента";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 180;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 125;
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
            // idGroupDataGridViewTextBoxColumn
            // 
            this.idGroupDataGridViewTextBoxColumn.DataPropertyName = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn.HeaderText = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGroupDataGridViewTextBoxColumn.Name = "idGroupDataGridViewTextBoxColumn";
            this.idGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGroupDataGridViewTextBoxColumn.Visible = false;
            this.idGroupDataGridViewTextBoxColumn.Width = 125;
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
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SmartMech.DB.Student);
            // 
            // gridMother
            // 
            this.gridMother.AutoGenerateColumns = false;
            this.gridMother.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMother.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gridMother.DataSource = this.studentBindingSource;
            this.gridMother.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridMother.Location = new System.Drawing.Point(0, 150);
            this.gridMother.Name = "gridMother";
            this.gridMother.ReadOnly = true;
            this.gridMother.RowHeadersWidth = 51;
            this.gridMother.RowTemplate.Height = 24;
            this.gridMother.Size = new System.Drawing.Size(843, 150);
            this.gridMother.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdStudent";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО студента";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FIOMother";
            this.dataGridViewTextBoxColumn4.HeaderText = "ФИО матери";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumberMother";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер матери";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 180;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FIOFather";
            this.dataGridViewTextBoxColumn7.HeaderText = "FIOFather";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NumberFather";
            this.dataGridViewTextBoxColumn8.HeaderText = "NumberFather";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // gridFather
            // 
            this.gridFather.AutoGenerateColumns = false;
            this.gridFather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.gridFather.DataSource = this.studentBindingSource;
            this.gridFather.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridFather.Location = new System.Drawing.Point(0, 300);
            this.gridFather.Name = "gridFather";
            this.gridFather.ReadOnly = true;
            this.gridFather.RowHeadersWidth = 51;
            this.gridFather.RowTemplate.Height = 24;
            this.gridFather.Size = new System.Drawing.Size(843, 150);
            this.gridFather.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdStudent";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdStudent";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn11.HeaderText = "ФИО студента";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 180;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn12.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FIOMother";
            this.dataGridViewTextBoxColumn13.HeaderText = "FIOMother";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "NumberMother";
            this.dataGridViewTextBoxColumn14.HeaderText = "NumberMother";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IdGroup";
            this.dataGridViewTextBoxColumn15.HeaderText = "IdGroup";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "FIOFather";
            this.dataGridViewTextBoxColumn16.HeaderText = "ФИО отца";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 180;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "NumberFather";
            this.dataGridViewTextBoxColumn17.HeaderText = "Номер отца";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 180;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(328, 483);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtFIOSearch
            // 
            this.txtFIOSearch.Location = new System.Drawing.Point(12, 484);
            this.txtFIOSearch.Name = "txtFIOSearch";
            this.txtFIOSearch.Size = new System.Drawing.Size(310, 22);
            this.txtFIOSearch.TabIndex = 4;
            // 
            // lFIOSearch
            // 
            this.lFIOSearch.AutoSize = true;
            this.lFIOSearch.Location = new System.Drawing.Point(95, 464);
            this.lFIOSearch.Name = "lFIOSearch";
            this.lFIOSearch.Size = new System.Drawing.Size(159, 17);
            this.lFIOSearch.TabIndex = 5;
            this.lFIOSearch.Text = "Введите ФИО ученика";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(843, 26);
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
            // StudentsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lFIOSearch);
            this.Controls.Add(this.txtFIOSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gridFather);
            this.Controls.Add(this.gridMother);
            this.Controls.Add(this.gridStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentsFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Все ученики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsFrom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMother)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFather)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView gridStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOMotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMotherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOFatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFatherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView gridMother;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView gridFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFIOSearch;
        private System.Windows.Forms.Label lFIOSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDayWeek;
        private System.Windows.Forms.ToolStripStatusLabel LStatusTime;
        private System.Windows.Forms.Timer DateTimer;
    }
    #endregion
}