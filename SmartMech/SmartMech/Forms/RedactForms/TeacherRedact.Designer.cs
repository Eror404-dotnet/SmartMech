namespace SmartMech.Forms.RedactForms
{
    partial class TeacherRedactFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherRedactFrom));
            this.dbgridTeacher = new System.Windows.Forms.DataGridView();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LFIO = new System.Windows.Forms.Label();
            this.LMobile = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbtnClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbgridTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbgridTeacher
            // 
            this.dbgridTeacher.AutoGenerateColumns = false;
            this.dbgridTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgridTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTeacherDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.mobilePhoneDataGridViewTextBoxColumn,
            this.mailBoxDataGridViewTextBoxColumn,
            this.groupsDataGridViewTextBoxColumn});
            this.dbgridTeacher.DataSource = this.teacherBindingSource;
            this.dbgridTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbgridTeacher.Location = new System.Drawing.Point(0, 28);
            this.dbgridTeacher.Name = "dbgridTeacher";
            this.dbgridTeacher.ReadOnly = true;
            this.dbgridTeacher.RowHeadersWidth = 51;
            this.dbgridTeacher.RowTemplate.Height = 24;
            this.dbgridTeacher.Size = new System.Drawing.Size(1077, 259);
            this.dbgridTeacher.TabIndex = 0;
            this.dbgridTeacher.SelectionChanged += new System.EventHandler(this.DbgridTeacher_SelectionChanged);
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
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(12, 316);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(252, 22);
            this.txtFIO.TabIndex = 1;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(300, 316);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(252, 22);
            this.txtMobile.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(590, 316);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(252, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // LFIO
            // 
            this.LFIO.AutoSize = true;
            this.LFIO.Location = new System.Drawing.Point(40, 296);
            this.LFIO.Name = "LFIO";
            this.LFIO.Size = new System.Drawing.Size(159, 17);
            this.LFIO.TabIndex = 4;
            this.LFIO.Text = "Введите ФИО учителя";
            // 
            // LMobile
            // 
            this.LMobile.AutoSize = true;
            this.LMobile.Location = new System.Drawing.Point(338, 296);
            this.LMobile.Name = "LMobile";
            this.LMobile.Size = new System.Drawing.Size(183, 17);
            this.LMobile.TabIndex = 5;
            this.LMobile.Text = "Введите телефон учителя";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(587, 296);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(255, 17);
            this.LEmail.TabIndex = 6;
            this.LEmail.Text = "Введите электронный адрес учителя";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(940, 315);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(95, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(940, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(940, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnClearAll});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbtnClearAll
            // 
            this.mbtnClearAll.Name = "mbtnClearAll";
            this.mbtnClearAll.Size = new System.Drawing.Size(87, 24);
            this.mbtnClearAll.Text = "Очистить";
            this.mbtnClearAll.Click += new System.EventHandler(this.MbtnClearAll_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1077, 26);
            this.statusStrip1.TabIndex = 11;
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
            // TeacherRedactFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LMobile);
            this.Controls.Add(this.LFIO);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.dbgridTeacher);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeacherRedactFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование.Учителя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherRedactFrom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dbgridTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbgridTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LFIO;
        private System.Windows.Forms.Label LMobile;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbtnClearAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDayWeek;
        private System.Windows.Forms.ToolStripStatusLabel LStatusTime;
        private System.Windows.Forms.Timer DateTimer;
    }
}