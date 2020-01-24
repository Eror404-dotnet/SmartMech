namespace SmartMech.Forms
{
    partial class FormRedactSudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRedactSudents));
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
            this.gridMother = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOMotherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMotherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOFatherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberFatherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridFather = new System.Windows.Forms.DataGridView();
            this.idStudentDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOMotherDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMotherDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOFatherDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberFatherDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.LAge = new System.Windows.Forms.Label();
            this.LFIO = new System.Windows.Forms.Label();
            this.txtAgeStudent = new System.Windows.Forms.TextBox();
            this.txtFIOStudent = new System.Windows.Forms.TextBox();
            this.dbMom = new System.Windows.Forms.GroupBox();
            this.LMobileMother = new System.Windows.Forms.Label();
            this.LFIOMother = new System.Windows.Forms.Label();
            this.txtMobileMom = new System.Windows.Forms.TextBox();
            this.txtFIOMom = new System.Windows.Forms.TextBox();
            this.dbFather = new System.Windows.Forms.GroupBox();
            this.LMobileFather = new System.Windows.Forms.Label();
            this.LFIOFather = new System.Windows.Forms.Label();
            this.txtMobileFather = new System.Windows.Forms.TextBox();
            this.txtFIOFather = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbGroups = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mbtnClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMother)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFather)).BeginInit();
            this.gbStudent.SuspendLayout();
            this.dbMom.SuspendLayout();
            this.dbFather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.gridStudent.Location = new System.Drawing.Point(0, 28);
            this.gridStudent.Name = "gridStudent";
            this.gridStudent.RowHeadersWidth = 51;
            this.gridStudent.RowTemplate.Height = 24;
            this.gridStudent.Size = new System.Drawing.Size(875, 271);
            this.gridStudent.TabIndex = 0;
            this.gridStudent.SelectionChanged += new System.EventHandler(this.GridStudent_SelectionChanged);
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
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО студента";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 180;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 180;
            // 
            // fIOMotherDataGridViewTextBoxColumn
            // 
            this.fIOMotherDataGridViewTextBoxColumn.DataPropertyName = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn.HeaderText = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOMotherDataGridViewTextBoxColumn.Name = "fIOMotherDataGridViewTextBoxColumn";
            this.fIOMotherDataGridViewTextBoxColumn.Visible = false;
            this.fIOMotherDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberMotherDataGridViewTextBoxColumn
            // 
            this.numberMotherDataGridViewTextBoxColumn.DataPropertyName = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn.HeaderText = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberMotherDataGridViewTextBoxColumn.Name = "numberMotherDataGridViewTextBoxColumn";
            this.numberMotherDataGridViewTextBoxColumn.Visible = false;
            this.numberMotherDataGridViewTextBoxColumn.Width = 125;
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
            // fIOFatherDataGridViewTextBoxColumn
            // 
            this.fIOFatherDataGridViewTextBoxColumn.DataPropertyName = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn.HeaderText = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIOFatherDataGridViewTextBoxColumn.Name = "fIOFatherDataGridViewTextBoxColumn";
            this.fIOFatherDataGridViewTextBoxColumn.Visible = false;
            this.fIOFatherDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberFatherDataGridViewTextBoxColumn
            // 
            this.numberFatherDataGridViewTextBoxColumn.DataPropertyName = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn.HeaderText = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberFatherDataGridViewTextBoxColumn.Name = "numberFatherDataGridViewTextBoxColumn";
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
            this.idStudentDataGridViewTextBoxColumn1,
            this.fIODataGridViewTextBoxColumn1,
            this.ageDataGridViewTextBoxColumn1,
            this.fIOMotherDataGridViewTextBoxColumn1,
            this.numberMotherDataGridViewTextBoxColumn1,
            this.idGroupDataGridViewTextBoxColumn1,
            this.fIOFatherDataGridViewTextBoxColumn1,
            this.numberFatherDataGridViewTextBoxColumn1});
            this.gridMother.DataSource = this.studentBindingSource;
            this.gridMother.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridMother.Location = new System.Drawing.Point(0, 299);
            this.gridMother.Name = "gridMother";
            this.gridMother.RowHeadersWidth = 51;
            this.gridMother.RowTemplate.Height = 24;
            this.gridMother.Size = new System.Drawing.Size(875, 117);
            this.gridMother.TabIndex = 1;
            // 
            // idStudentDataGridViewTextBoxColumn1
            // 
            this.idStudentDataGridViewTextBoxColumn1.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn1.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idStudentDataGridViewTextBoxColumn1.Name = "idStudentDataGridViewTextBoxColumn1";
            this.idStudentDataGridViewTextBoxColumn1.Visible = false;
            this.idStudentDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn1
            // 
            this.fIODataGridViewTextBoxColumn1.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn1.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn1.Name = "fIODataGridViewTextBoxColumn1";
            this.fIODataGridViewTextBoxColumn1.Visible = false;
            this.fIODataGridViewTextBoxColumn1.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn1
            // 
            this.ageDataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn1.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn1.Name = "ageDataGridViewTextBoxColumn1";
            this.ageDataGridViewTextBoxColumn1.Visible = false;
            this.ageDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fIOMotherDataGridViewTextBoxColumn1
            // 
            this.fIOMotherDataGridViewTextBoxColumn1.DataPropertyName = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn1.HeaderText = "ФИО мамы";
            this.fIOMotherDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fIOMotherDataGridViewTextBoxColumn1.Name = "fIOMotherDataGridViewTextBoxColumn1";
            this.fIOMotherDataGridViewTextBoxColumn1.Width = 180;
            // 
            // numberMotherDataGridViewTextBoxColumn1
            // 
            this.numberMotherDataGridViewTextBoxColumn1.DataPropertyName = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn1.HeaderText = "Номер мамы";
            this.numberMotherDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numberMotherDataGridViewTextBoxColumn1.Name = "numberMotherDataGridViewTextBoxColumn1";
            this.numberMotherDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idGroupDataGridViewTextBoxColumn1
            // 
            this.idGroupDataGridViewTextBoxColumn1.DataPropertyName = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn1.HeaderText = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idGroupDataGridViewTextBoxColumn1.Name = "idGroupDataGridViewTextBoxColumn1";
            this.idGroupDataGridViewTextBoxColumn1.Visible = false;
            this.idGroupDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fIOFatherDataGridViewTextBoxColumn1
            // 
            this.fIOFatherDataGridViewTextBoxColumn1.DataPropertyName = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn1.HeaderText = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fIOFatherDataGridViewTextBoxColumn1.Name = "fIOFatherDataGridViewTextBoxColumn1";
            this.fIOFatherDataGridViewTextBoxColumn1.Visible = false;
            this.fIOFatherDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numberFatherDataGridViewTextBoxColumn1
            // 
            this.numberFatherDataGridViewTextBoxColumn1.DataPropertyName = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn1.HeaderText = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numberFatherDataGridViewTextBoxColumn1.Name = "numberFatherDataGridViewTextBoxColumn1";
            this.numberFatherDataGridViewTextBoxColumn1.Visible = false;
            this.numberFatherDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gridFather
            // 
            this.gridFather.AutoGenerateColumns = false;
            this.gridFather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStudentDataGridViewTextBoxColumn2,
            this.fIODataGridViewTextBoxColumn2,
            this.ageDataGridViewTextBoxColumn2,
            this.fIOMotherDataGridViewTextBoxColumn2,
            this.numberMotherDataGridViewTextBoxColumn2,
            this.idGroupDataGridViewTextBoxColumn2,
            this.fIOFatherDataGridViewTextBoxColumn2,
            this.numberFatherDataGridViewTextBoxColumn2});
            this.gridFather.DataSource = this.studentBindingSource;
            this.gridFather.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridFather.Location = new System.Drawing.Point(0, 416);
            this.gridFather.Name = "gridFather";
            this.gridFather.RowHeadersWidth = 51;
            this.gridFather.RowTemplate.Height = 24;
            this.gridFather.Size = new System.Drawing.Size(875, 126);
            this.gridFather.TabIndex = 2;
            // 
            // idStudentDataGridViewTextBoxColumn2
            // 
            this.idStudentDataGridViewTextBoxColumn2.DataPropertyName = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn2.HeaderText = "IdStudent";
            this.idStudentDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idStudentDataGridViewTextBoxColumn2.Name = "idStudentDataGridViewTextBoxColumn2";
            this.idStudentDataGridViewTextBoxColumn2.Visible = false;
            this.idStudentDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn2
            // 
            this.fIODataGridViewTextBoxColumn2.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn2.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn2.Name = "fIODataGridViewTextBoxColumn2";
            this.fIODataGridViewTextBoxColumn2.Visible = false;
            this.fIODataGridViewTextBoxColumn2.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn2
            // 
            this.ageDataGridViewTextBoxColumn2.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn2.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn2.Name = "ageDataGridViewTextBoxColumn2";
            this.ageDataGridViewTextBoxColumn2.Visible = false;
            this.ageDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fIOMotherDataGridViewTextBoxColumn2
            // 
            this.fIOMotherDataGridViewTextBoxColumn2.DataPropertyName = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn2.HeaderText = "FIOMother";
            this.fIOMotherDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fIOMotherDataGridViewTextBoxColumn2.Name = "fIOMotherDataGridViewTextBoxColumn2";
            this.fIOMotherDataGridViewTextBoxColumn2.Visible = false;
            this.fIOMotherDataGridViewTextBoxColumn2.Width = 125;
            // 
            // numberMotherDataGridViewTextBoxColumn2
            // 
            this.numberMotherDataGridViewTextBoxColumn2.DataPropertyName = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn2.HeaderText = "NumberMother";
            this.numberMotherDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.numberMotherDataGridViewTextBoxColumn2.Name = "numberMotherDataGridViewTextBoxColumn2";
            this.numberMotherDataGridViewTextBoxColumn2.Visible = false;
            this.numberMotherDataGridViewTextBoxColumn2.Width = 125;
            // 
            // idGroupDataGridViewTextBoxColumn2
            // 
            this.idGroupDataGridViewTextBoxColumn2.DataPropertyName = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn2.HeaderText = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idGroupDataGridViewTextBoxColumn2.Name = "idGroupDataGridViewTextBoxColumn2";
            this.idGroupDataGridViewTextBoxColumn2.Visible = false;
            this.idGroupDataGridViewTextBoxColumn2.Width = 125;
            // 
            // fIOFatherDataGridViewTextBoxColumn2
            // 
            this.fIOFatherDataGridViewTextBoxColumn2.DataPropertyName = "FIOFather";
            this.fIOFatherDataGridViewTextBoxColumn2.HeaderText = "ФИО папа";
            this.fIOFatherDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.fIOFatherDataGridViewTextBoxColumn2.Name = "fIOFatherDataGridViewTextBoxColumn2";
            this.fIOFatherDataGridViewTextBoxColumn2.Width = 180;
            // 
            // numberFatherDataGridViewTextBoxColumn2
            // 
            this.numberFatherDataGridViewTextBoxColumn2.DataPropertyName = "NumberFather";
            this.numberFatherDataGridViewTextBoxColumn2.HeaderText = "Номер папы";
            this.numberFatherDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.numberFatherDataGridViewTextBoxColumn2.Name = "numberFatherDataGridViewTextBoxColumn2";
            this.numberFatherDataGridViewTextBoxColumn2.Width = 180;
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.LAge);
            this.gbStudent.Controls.Add(this.LFIO);
            this.gbStudent.Controls.Add(this.txtAgeStudent);
            this.gbStudent.Controls.Add(this.txtFIOStudent);
            this.gbStudent.Location = new System.Drawing.Point(12, 532);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(277, 245);
            this.gbStudent.TabIndex = 3;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Ученик";
            // 
            // LAge
            // 
            this.LAge.AutoSize = true;
            this.LAge.Location = new System.Drawing.Point(6, 139);
            this.LAge.Name = "LAge";
            this.LAge.Size = new System.Drawing.Size(62, 17);
            this.LAge.TabIndex = 3;
            this.LAge.Text = "Возраст";
            // 
            // LFIO
            // 
            this.LFIO.AutoSize = true;
            this.LFIO.Location = new System.Drawing.Point(6, 51);
            this.LFIO.Name = "LFIO";
            this.LFIO.Size = new System.Drawing.Size(42, 17);
            this.LFIO.TabIndex = 2;
            this.LFIO.Text = "ФИО";
            // 
            // txtAgeStudent
            // 
            this.txtAgeStudent.Location = new System.Drawing.Point(6, 159);
            this.txtAgeStudent.Name = "txtAgeStudent";
            this.txtAgeStudent.Size = new System.Drawing.Size(265, 22);
            this.txtAgeStudent.TabIndex = 1;
            // 
            // txtFIOStudent
            // 
            this.txtFIOStudent.Location = new System.Drawing.Point(6, 71);
            this.txtFIOStudent.Name = "txtFIOStudent";
            this.txtFIOStudent.Size = new System.Drawing.Size(265, 22);
            this.txtFIOStudent.TabIndex = 0;
            // 
            // dbMom
            // 
            this.dbMom.Controls.Add(this.LMobileMother);
            this.dbMom.Controls.Add(this.LFIOMother);
            this.dbMom.Controls.Add(this.txtMobileMom);
            this.dbMom.Controls.Add(this.txtFIOMom);
            this.dbMom.Location = new System.Drawing.Point(295, 532);
            this.dbMom.Name = "dbMom";
            this.dbMom.Size = new System.Drawing.Size(277, 245);
            this.dbMom.TabIndex = 4;
            this.dbMom.TabStop = false;
            this.dbMom.Text = "Мама";
            // 
            // LMobileMother
            // 
            this.LMobileMother.AutoSize = true;
            this.LMobileMother.Location = new System.Drawing.Point(6, 139);
            this.LMobileMother.Name = "LMobileMother";
            this.LMobileMother.Size = new System.Drawing.Size(84, 17);
            this.LMobileMother.TabIndex = 4;
            this.LMobileMother.Text = "Мобильный";
            // 
            // LFIOMother
            // 
            this.LFIOMother.AutoSize = true;
            this.LFIOMother.Location = new System.Drawing.Point(6, 51);
            this.LFIOMother.Name = "LFIOMother";
            this.LFIOMother.Size = new System.Drawing.Size(42, 17);
            this.LFIOMother.TabIndex = 4;
            this.LFIOMother.Text = "ФИО";
            // 
            // txtMobileMom
            // 
            this.txtMobileMom.Location = new System.Drawing.Point(7, 159);
            this.txtMobileMom.Name = "txtMobileMom";
            this.txtMobileMom.Size = new System.Drawing.Size(264, 22);
            this.txtMobileMom.TabIndex = 5;
            // 
            // txtFIOMom
            // 
            this.txtFIOMom.Location = new System.Drawing.Point(7, 71);
            this.txtFIOMom.Name = "txtFIOMom";
            this.txtFIOMom.Size = new System.Drawing.Size(264, 22);
            this.txtFIOMom.TabIndex = 4;
            // 
            // dbFather
            // 
            this.dbFather.Controls.Add(this.LMobileFather);
            this.dbFather.Controls.Add(this.LFIOFather);
            this.dbFather.Controls.Add(this.txtMobileFather);
            this.dbFather.Controls.Add(this.txtFIOFather);
            this.dbFather.Location = new System.Drawing.Point(578, 532);
            this.dbFather.Name = "dbFather";
            this.dbFather.Size = new System.Drawing.Size(277, 245);
            this.dbFather.TabIndex = 5;
            this.dbFather.TabStop = false;
            this.dbFather.Text = "Папа";
            // 
            // LMobileFather
            // 
            this.LMobileFather.AutoSize = true;
            this.LMobileFather.Location = new System.Drawing.Point(6, 139);
            this.LMobileFather.Name = "LMobileFather";
            this.LMobileFather.Size = new System.Drawing.Size(84, 17);
            this.LMobileFather.TabIndex = 6;
            this.LMobileFather.Text = "Мобильный";
            // 
            // LFIOFather
            // 
            this.LFIOFather.AutoSize = true;
            this.LFIOFather.Location = new System.Drawing.Point(6, 51);
            this.LFIOFather.Name = "LFIOFather";
            this.LFIOFather.Size = new System.Drawing.Size(42, 17);
            this.LFIOFather.TabIndex = 6;
            this.LFIOFather.Text = "ФИО";
            // 
            // txtMobileFather
            // 
            this.txtMobileFather.Location = new System.Drawing.Point(7, 159);
            this.txtMobileFather.Name = "txtMobileFather";
            this.txtMobileFather.Size = new System.Drawing.Size(264, 22);
            this.txtMobileFather.TabIndex = 7;
            // 
            // txtFIOFather
            // 
            this.txtFIOFather.Location = new System.Drawing.Point(6, 71);
            this.txtFIOFather.Name = "txtFIOFather";
            this.txtFIOFather.Size = new System.Drawing.Size(265, 22);
            this.txtFIOFather.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(221, 783);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cmbGroups
            // 
            this.cmbGroups.DataSource = this.groupBindingSource;
            this.cmbGroups.DisplayMember = "GroupName";
            this.cmbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGroups.FormattingEnabled = true;
            this.cmbGroups.Location = new System.Drawing.Point(12, 783);
            this.cmbGroups.Name = "cmbGroups";
            this.cmbGroups.Size = new System.Drawing.Size(203, 28);
            this.cmbGroups.TabIndex = 7;
            this.cmbGroups.ValueMember = "IdGroup";
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SmartMech.DB.Group);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(364, 783);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 31);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(507, 783);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 31);
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
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
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
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 845);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 26);
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
            // FormRedactSudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 871);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbGroups);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.dbFather);
            this.Controls.Add(this.dbMom);
            this.Controls.Add(this.gridFather);
            this.Controls.Add(this.gridMother);
            this.Controls.Add(this.gridStudent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormRedactSudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование.Ученики";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMother)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFather)).EndInit();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.dbMom.ResumeLayout(false);
            this.dbMom.PerformLayout();
            this.dbFather.ResumeLayout(false);
            this.dbFather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView gridMother;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOMotherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMotherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOFatherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFatherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView gridFather;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOMotherDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMotherDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGroupDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOFatherDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberFatherDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Label LAge;
        private System.Windows.Forms.Label LFIO;
        private System.Windows.Forms.TextBox txtAgeStudent;
        private System.Windows.Forms.TextBox txtFIOStudent;
        private System.Windows.Forms.GroupBox dbMom;
        private System.Windows.Forms.Label LMobileMother;
        private System.Windows.Forms.Label LFIOMother;
        private System.Windows.Forms.TextBox txtMobileMom;
        private System.Windows.Forms.TextBox txtFIOMom;
        private System.Windows.Forms.GroupBox dbFather;
        private System.Windows.Forms.Label LMobileFather;
        private System.Windows.Forms.Label LFIOFather;
        private System.Windows.Forms.TextBox txtMobileFather;
        private System.Windows.Forms.TextBox txtFIOFather;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbGroups;
        private System.Windows.Forms.BindingSource groupBindingSource;
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