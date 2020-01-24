namespace SmartMech.Forms
{
    partial class PrisutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrisutForm));
            this.dbgridPrisut = new System.Windows.Forms.DataGridView();
            this.idPrisutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePrisutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePickerToday = new System.Windows.Forms.DateTimePicker();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbFIO = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grboxPrisut = new System.Windows.Forms.GroupBox();
            this.rbtnOfficial = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TimePickerDateSearch = new System.Windows.Forms.DateTimePicker();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.cmbFIOSearch = new System.Windows.Forms.ComboBox();
            this.btnFIOSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbtnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbgridPrisut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePrisutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.grboxPrisut.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgridPrisut
            // 
            this.dbgridPrisut.AutoGenerateColumns = false;
            this.dbgridPrisut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgridPrisut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrisutDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn,
            this.idGroupDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.prisutDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn});
            this.dbgridPrisut.DataSource = this.tablePrisutBindingSource;
            this.dbgridPrisut.Location = new System.Drawing.Point(12, 61);
            this.dbgridPrisut.Name = "dbgridPrisut";
            this.dbgridPrisut.RowHeadersVisible = false;
            this.dbgridPrisut.RowHeadersWidth = 51;
            this.dbgridPrisut.RowTemplate.Height = 24;
            this.dbgridPrisut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgridPrisut.Size = new System.Drawing.Size(1041, 243);
            this.dbgridPrisut.TabIndex = 0;
            // 
            // idPrisutDataGridViewTextBoxColumn
            // 
            this.idPrisutDataGridViewTextBoxColumn.DataPropertyName = "IdPrisut";
            this.idPrisutDataGridViewTextBoxColumn.HeaderText = "IdPrisut";
            this.idPrisutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPrisutDataGridViewTextBoxColumn.Name = "idPrisutDataGridViewTextBoxColumn";
            this.idPrisutDataGridViewTextBoxColumn.Visible = false;
            this.idPrisutDataGridViewTextBoxColumn.Width = 125;
            // 
            // idStudentDataGridViewTextBoxColumn
            // 
            this.idStudentDataGridViewTextBoxColumn.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idStudentDataGridViewTextBoxColumn.Name = "idStudentDataGridViewTextBoxColumn";
            this.idStudentDataGridViewTextBoxColumn.Visible = false;
            this.idStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // idGroupDataGridViewTextBoxColumn
            // 
            this.idGroupDataGridViewTextBoxColumn.DataPropertyName = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn.HeaderText = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGroupDataGridViewTextBoxColumn.Name = "idGroupDataGridViewTextBoxColumn";
            this.idGroupDataGridViewTextBoxColumn.Visible = false;
            this.idGroupDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 185;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Номер группы";
            this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.Width = 185;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 185;
            // 
            // prisutDataGridViewTextBoxColumn
            // 
            this.prisutDataGridViewTextBoxColumn.DataPropertyName = "Prisut";
            this.prisutDataGridViewTextBoxColumn.HeaderText = "Присутствие";
            this.prisutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prisutDataGridViewTextBoxColumn.Name = "prisutDataGridViewTextBoxColumn";
            this.prisutDataGridViewTextBoxColumn.Width = 185;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.Visible = false;
            this.groupDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.Visible = false;
            this.studentDataGridViewTextBoxColumn.Width = 125;
            // 
            // tablePrisutBindingSource
            // 
            this.tablePrisutBindingSource.DataSource = typeof(SmartMech.DB.TablePrisut);
            // 
            // datePickerToday
            // 
            this.datePickerToday.Location = new System.Drawing.Point(12, 331);
            this.datePickerToday.Name = "datePickerToday";
            this.datePickerToday.Size = new System.Drawing.Size(200, 22);
            this.datePickerToday.TabIndex = 1;
            this.datePickerToday.ValueChanged += new System.EventHandler(this.DatePickerToday_ValueChanged);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.groupBindingSource;
            this.cmbGroup.DisplayMember = "GroupName";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(12, 31);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(153, 24);
            this.cmbGroup.TabIndex = 2;
            this.cmbGroup.ValueMember = "IdGroup";
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.CmbGroup_SelectedIndexChanged);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SmartMech.DB.Group);
            // 
            // cmbFIO
            // 
            this.cmbFIO.DataSource = this.studentBindingSource;
            this.cmbFIO.DisplayMember = "FIO";
            this.cmbFIO.FormattingEnabled = true;
            this.cmbFIO.Location = new System.Drawing.Point(13, 360);
            this.cmbFIO.Name = "cmbFIO";
            this.cmbFIO.Size = new System.Drawing.Size(199, 24);
            this.cmbFIO.TabIndex = 3;
            this.cmbFIO.ValueMember = "IdStudent";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SmartMech.DB.Student);
            // 
            // grboxPrisut
            // 
            this.grboxPrisut.Controls.Add(this.rbtnOfficial);
            this.grboxPrisut.Controls.Add(this.rbtnNo);
            this.grboxPrisut.Controls.Add(this.rbtnYes);
            this.grboxPrisut.Location = new System.Drawing.Point(12, 391);
            this.grboxPrisut.Name = "grboxPrisut";
            this.grboxPrisut.Size = new System.Drawing.Size(200, 150);
            this.grboxPrisut.TabIndex = 4;
            this.grboxPrisut.TabStop = false;
            this.grboxPrisut.Text = "Присутствует";
            // 
            // rbtnOfficial
            // 
            this.rbtnOfficial.AutoSize = true;
            this.rbtnOfficial.Location = new System.Drawing.Point(43, 123);
            this.rbtnOfficial.Name = "rbtnOfficial";
            this.rbtnOfficial.Size = new System.Drawing.Size(118, 21);
            this.rbtnOfficial.TabIndex = 2;
            this.rbtnOfficial.TabStop = true;
            this.rbtnOfficial.Text = "Предупредил";
            this.rbtnOfficial.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(43, 75);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(54, 21);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "Нет";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(43, 30);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(48, 21);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Да";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 470);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Записать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 433);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TimePickerDateSearch
            // 
            this.TimePickerDateSearch.Location = new System.Drawing.Point(853, 331);
            this.TimePickerDateSearch.Name = "TimePickerDateSearch";
            this.TimePickerDateSearch.Size = new System.Drawing.Size(200, 22);
            this.TimePickerDateSearch.TabIndex = 7;
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.Location = new System.Drawing.Point(853, 360);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(200, 31);
            this.btnDateSearch.TabIndex = 8;
            this.btnDateSearch.Text = "Поиск по дате";
            this.btnDateSearch.UseVisualStyleBackColor = true;
            this.btnDateSearch.Click += new System.EventHandler(this.BtnDateSearch_Click);
            // 
            // cmbFIOSearch
            // 
            this.cmbFIOSearch.DataSource = this.studentBindingSource;
            this.cmbFIOSearch.DisplayMember = "FIO";
            this.cmbFIOSearch.FormattingEnabled = true;
            this.cmbFIOSearch.Location = new System.Drawing.Point(854, 474);
            this.cmbFIOSearch.Name = "cmbFIOSearch";
            this.cmbFIOSearch.Size = new System.Drawing.Size(199, 24);
            this.cmbFIOSearch.TabIndex = 9;
            this.cmbFIOSearch.ValueMember = "IdStudent";
            // 
            // btnFIOSearch
            // 
            this.btnFIOSearch.Location = new System.Drawing.Point(854, 504);
            this.btnFIOSearch.Name = "btnFIOSearch";
            this.btnFIOSearch.Size = new System.Drawing.Size(200, 31);
            this.btnFIOSearch.TabIndex = 10;
            this.btnFIOSearch.Text = "Поиск по фамилии";
            this.btnFIOSearch.UseVisualStyleBackColor = true;
            this.btnFIOSearch.Click += new System.EventHandler(this.BtnFIOSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnClear});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbtnClear
            // 
            this.mbtnClear.Name = "mbtnClear";
            this.mbtnClear.Size = new System.Drawing.Size(132, 24);
            this.mbtnClear.Text = "Очистить поиск";
            this.mbtnClear.Click += new System.EventHandler(this.MbtnClear_Click);
            // 
            // DateTimer
            // 
            this.DateTimer.Interval = 1000;
            this.DateTimer.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1065, 26);
            this.statusStrip1.TabIndex = 15;
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
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PrisutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 600);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFIOSearch);
            this.Controls.Add(this.cmbFIOSearch);
            this.Controls.Add(this.btnDateSearch);
            this.Controls.Add(this.TimePickerDateSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grboxPrisut);
            this.Controls.Add(this.cmbFIO);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.datePickerToday);
            this.Controls.Add(this.dbgridPrisut);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PrisutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Присутствие";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrisutForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dbgridPrisut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePrisutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.grboxPrisut.ResumeLayout(false);
            this.grboxPrisut.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgridPrisut;
        private System.Windows.Forms.DateTimePicker datePickerToday;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbFIO;
        private System.Windows.Forms.GroupBox grboxPrisut;
        private System.Windows.Forms.RadioButton rbtnOfficial;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource tablePrisutBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrisutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker TimePickerDateSearch;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.ComboBox cmbFIOSearch;
        private System.Windows.Forms.Button btnFIOSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbtnClear;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDayWeek;
        private System.Windows.Forms.ToolStripStatusLabel LStatusTime;
        private System.Windows.Forms.Button btnDelete;
    }
}