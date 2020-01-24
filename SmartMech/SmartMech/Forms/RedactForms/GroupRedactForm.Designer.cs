namespace SmartMech.Forms.RedactForms
{
    partial class GroupRedactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupRedactForm));
            this.gridGroup = new System.Windows.Forms.DataGridView();
            this.idGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.gbNameSet = new System.Windows.Forms.GroupBox();
            this.rbtnEV3 = new System.Windows.Forms.RadioButton();
            this.rbtnWeDo = new System.Windows.Forms.RadioButton();
            this.LNameSet = new System.Windows.Forms.Label();
            this.PickerDay = new System.Windows.Forms.DateTimePicker();
            this.LStartStudy = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LTeacher = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbtnClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.gbNameSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroup
            // 
            this.gridGroup.AutoGenerateColumns = false;
            this.gridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGroupDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.setNameDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.idTeacherDataGridViewTextBoxColumn,
            this.teacherDataGridViewTextBoxColumn,
            this.studentsDataGridViewTextBoxColumn});
            this.gridGroup.DataSource = this.groupBindingSource;
            this.gridGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridGroup.Location = new System.Drawing.Point(0, 28);
            this.gridGroup.Name = "gridGroup";
            this.gridGroup.RowHeadersWidth = 51;
            this.gridGroup.RowTemplate.Height = 24;
            this.gridGroup.Size = new System.Drawing.Size(793, 186);
            this.gridGroup.TabIndex = 0;
            this.gridGroup.SelectionChanged += new System.EventHandler(this.GridGroup_SelectionChanged);
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
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "Название группы";
            this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // setNameDataGridViewTextBoxColumn
            // 
            this.setNameDataGridViewTextBoxColumn.DataPropertyName = "SetName";
            this.setNameDataGridViewTextBoxColumn.HeaderText = "Название набора";
            this.setNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.setNameDataGridViewTextBoxColumn.Name = "setNameDataGridViewTextBoxColumn";
            this.setNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Старт занятий";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 180;
            // 
            // idTeacherDataGridViewTextBoxColumn
            // 
            this.idTeacherDataGridViewTextBoxColumn.DataPropertyName = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn.HeaderText = "IdTeacher";
            this.idTeacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTeacherDataGridViewTextBoxColumn.Name = "idTeacherDataGridViewTextBoxColumn";
            this.idTeacherDataGridViewTextBoxColumn.Visible = false;
            this.idTeacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "Teacher";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Teacher";
            this.teacherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.Visible = false;
            this.teacherDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsDataGridViewTextBoxColumn
            // 
            this.studentsDataGridViewTextBoxColumn.DataPropertyName = "Students";
            this.studentsDataGridViewTextBoxColumn.HeaderText = "Students";
            this.studentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentsDataGridViewTextBoxColumn.Name = "studentsDataGridViewTextBoxColumn";
            this.studentsDataGridViewTextBoxColumn.Visible = false;
            this.studentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SmartMech.DB.Group);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(12, 221);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(154, 22);
            this.txtGroupName.TabIndex = 1;
            // 
            // gbNameSet
            // 
            this.gbNameSet.Controls.Add(this.rbtnEV3);
            this.gbNameSet.Controls.Add(this.rbtnWeDo);
            this.gbNameSet.Location = new System.Drawing.Point(12, 258);
            this.gbNameSet.Name = "gbNameSet";
            this.gbNameSet.Size = new System.Drawing.Size(200, 100);
            this.gbNameSet.TabIndex = 2;
            this.gbNameSet.TabStop = false;
            this.gbNameSet.Text = "Набор для группы";
            // 
            // rbtnEV3
            // 
            this.rbtnEV3.AutoSize = true;
            this.rbtnEV3.Location = new System.Drawing.Point(6, 57);
            this.rbtnEV3.Name = "rbtnEV3";
            this.rbtnEV3.Size = new System.Drawing.Size(55, 21);
            this.rbtnEV3.TabIndex = 4;
            this.rbtnEV3.TabStop = true;
            this.rbtnEV3.Text = "EV3";
            this.rbtnEV3.UseVisualStyleBackColor = true;
            // 
            // rbtnWeDo
            // 
            this.rbtnWeDo.AutoSize = true;
            this.rbtnWeDo.Location = new System.Drawing.Point(6, 30);
            this.rbtnWeDo.Name = "rbtnWeDo";
            this.rbtnWeDo.Size = new System.Drawing.Size(68, 21);
            this.rbtnWeDo.TabIndex = 3;
            this.rbtnWeDo.TabStop = true;
            this.rbtnWeDo.Text = "WeDo";
            this.rbtnWeDo.UseVisualStyleBackColor = true;
            // 
            // LNameSet
            // 
            this.LNameSet.AutoSize = true;
            this.LNameSet.Location = new System.Drawing.Point(12, 201);
            this.LNameSet.Name = "LNameSet";
            this.LNameSet.Size = new System.Drawing.Size(144, 17);
            this.LNameSet.TabIndex = 5;
            this.LNameSet.Text = "Введите имя набора";
            // 
            // PickerDay
            // 
            this.PickerDay.Location = new System.Drawing.Point(12, 392);
            this.PickerDay.Name = "PickerDay";
            this.PickerDay.Size = new System.Drawing.Size(200, 22);
            this.PickerDay.TabIndex = 6;
            // 
            // LStartStudy
            // 
            this.LStartStudy.AutoSize = true;
            this.LStartStudy.Location = new System.Drawing.Point(12, 372);
            this.LStartStudy.Name = "LStartStudy";
            this.LStartStudy.Size = new System.Drawing.Size(116, 17);
            this.LStartStudy.TabIndex = 7;
            this.LStartStudy.Text = "Начало занятий";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DataSource = this.teacherBindingSource;
            this.cmbTeacher.DisplayMember = "FIO";
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(12, 452);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(200, 24);
            this.cmbTeacher.TabIndex = 8;
            this.cmbTeacher.ValueMember = "IdTeacher";
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(SmartMech.DB.Teacher);
            // 
            // LTeacher
            // 
            this.LTeacher.AutoSize = true;
            this.LTeacher.Location = new System.Drawing.Point(12, 432);
            this.LTeacher.Name = "LTeacher";
            this.LTeacher.Size = new System.Drawing.Size(132, 17);
            this.LTeacher.TabIndex = 9;
            this.LTeacher.Text = "Выберите учителя";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(430, 460);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(559, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 12;
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
            this.menuStrip1.Size = new System.Drawing.Size(793, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mbtnClearAll
            // 
            this.mbtnClearAll.Name = "mbtnClearAll";
            this.mbtnClearAll.Size = new System.Drawing.Size(87, 24);
            this.mbtnClearAll.Text = "Очистить";
            this.mbtnClearAll.Click += new System.EventHandler(this.MbtnClearAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 26);
            this.statusStrip1.TabIndex = 14;
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
            // GroupRedactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LTeacher);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.LStartStudy);
            this.Controls.Add(this.PickerDay);
            this.Controls.Add(this.LNameSet);
            this.Controls.Add(this.gbNameSet);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.gridGroup);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "GroupRedactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование.Группы";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.gbNameSet.ResumeLayout(false);
            this.gbNameSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridGroup;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.GroupBox gbNameSet;
        private System.Windows.Forms.RadioButton rbtnEV3;
        private System.Windows.Forms.RadioButton rbtnWeDo;
        private System.Windows.Forms.Label LNameSet;
        private System.Windows.Forms.DateTimePicker PickerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Label LStartStudy;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.Label LTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mbtnClearAll;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDayWeek;
        private System.Windows.Forms.ToolStripStatusLabel LStatusTime;
        private System.Windows.Forms.Timer DateTimer;
    }
}