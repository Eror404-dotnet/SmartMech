namespace SmartMech.Forms
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.dbGridPay = new System.Windows.Forms.DataGridView();
            this.idPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datePickerDatePay = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateStart = new System.Windows.Forms.DateTimePicker();
            this.cmbFIO = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grboxTypePay = new System.Windows.Forms.GroupBox();
            this.rbtnToCard = new System.Windows.Forms.RadioButton();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.rbtnMoney = new System.Windows.Forms.RadioButton();
            this.btnPayAdd = new System.Windows.Forms.Button();
            this.rbtnWithoutSale = new System.Windows.Forms.RadioButton();
            this.rbtnWithSale = new System.Windows.Forms.RadioButton();
            this.grbPayCount = new System.Windows.Forms.GroupBox();
            this.LAllPay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.grboxTypePay.SuspendLayout();
            this.grbPayCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbGridPay
            // 
            this.dbGridPay.AutoGenerateColumns = false;
            this.dbGridPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridPay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPayDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.datePayDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.idStudentDataGridViewTextBoxColumn,
            this.countPayDataGridViewTextBoxColumn,
            this.typePayDataGridViewTextBoxColumn,
            this.studentDataGridViewTextBoxColumn});
            this.dbGridPay.DataSource = this.tablePayBindingSource;
            this.dbGridPay.Location = new System.Drawing.Point(13, 74);
            this.dbGridPay.Name = "dbGridPay";
            this.dbGridPay.RowHeadersWidth = 51;
            this.dbGridPay.RowTemplate.Height = 24;
            this.dbGridPay.Size = new System.Drawing.Size(1485, 196);
            this.dbGridPay.TabIndex = 0;
            // 
            // idPayDataGridViewTextBoxColumn
            // 
            this.idPayDataGridViewTextBoxColumn.DataPropertyName = "IdPay";
            this.idPayDataGridViewTextBoxColumn.HeaderText = "IdPay";
            this.idPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPayDataGridViewTextBoxColumn.Name = "idPayDataGridViewTextBoxColumn";
            this.idPayDataGridViewTextBoxColumn.Visible = false;
            this.idPayDataGridViewTextBoxColumn.Width = 125;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.Width = 185;
            // 
            // datePayDataGridViewTextBoxColumn
            // 
            this.datePayDataGridViewTextBoxColumn.DataPropertyName = "DatePay";
            this.datePayDataGridViewTextBoxColumn.HeaderText = "Дата оплаты";
            this.datePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datePayDataGridViewTextBoxColumn.Name = "datePayDataGridViewTextBoxColumn";
            this.datePayDataGridViewTextBoxColumn.Width = 185;
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "Дата старта";
            this.dateStartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            this.dateStartDataGridViewTextBoxColumn.Width = 185;
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
            // countPayDataGridViewTextBoxColumn
            // 
            this.countPayDataGridViewTextBoxColumn.DataPropertyName = "CountPay";
            this.countPayDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.countPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countPayDataGridViewTextBoxColumn.Name = "countPayDataGridViewTextBoxColumn";
            this.countPayDataGridViewTextBoxColumn.Width = 185;
            // 
            // typePayDataGridViewTextBoxColumn
            // 
            this.typePayDataGridViewTextBoxColumn.DataPropertyName = "TypePay";
            this.typePayDataGridViewTextBoxColumn.HeaderText = "Тип оплаты";
            this.typePayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typePayDataGridViewTextBoxColumn.Name = "typePayDataGridViewTextBoxColumn";
            this.typePayDataGridViewTextBoxColumn.Width = 185;
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
            // tablePayBindingSource
            // 
            this.tablePayBindingSource.DataSource = typeof(SmartMech.DB.TablePay);
            // 
            // datePickerDatePay
            // 
            this.datePickerDatePay.Location = new System.Drawing.Point(13, 276);
            this.datePickerDatePay.Name = "datePickerDatePay";
            this.datePickerDatePay.Size = new System.Drawing.Size(200, 22);
            this.datePickerDatePay.TabIndex = 1;
            // 
            // datePickerDateStart
            // 
            this.datePickerDateStart.Location = new System.Drawing.Point(13, 316);
            this.datePickerDateStart.Name = "datePickerDateStart";
            this.datePickerDateStart.Size = new System.Drawing.Size(200, 22);
            this.datePickerDateStart.TabIndex = 2;
            // 
            // cmbFIO
            // 
            this.cmbFIO.DataSource = this.studentBindingSource;
            this.cmbFIO.DisplayMember = "FIO";
            this.cmbFIO.FormattingEnabled = true;
            this.cmbFIO.Location = new System.Drawing.Point(13, 355);
            this.cmbFIO.Name = "cmbFIO";
            this.cmbFIO.Size = new System.Drawing.Size(200, 24);
            this.cmbFIO.TabIndex = 3;
            this.cmbFIO.ValueMember = "IdStudent";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SmartMech.DB.Student);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.groupBindingSource;
            this.cmbGroup.DisplayMember = "GroupName";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(13, 24);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(155, 24);
            this.cmbGroup.TabIndex = 4;
            this.cmbGroup.ValueMember = "IdGroup";
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.CmbGroup_SelectedIndexChanged);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(SmartMech.DB.Group);
            // 
            // grboxTypePay
            // 
            this.grboxTypePay.Controls.Add(this.rbtnToCard);
            this.grboxTypePay.Controls.Add(this.rbtnCard);
            this.grboxTypePay.Controls.Add(this.rbtnMoney);
            this.grboxTypePay.Location = new System.Drawing.Point(13, 444);
            this.grboxTypePay.Name = "grboxTypePay";
            this.grboxTypePay.Size = new System.Drawing.Size(200, 172);
            this.grboxTypePay.TabIndex = 6;
            this.grboxTypePay.TabStop = false;
            this.grboxTypePay.Text = "Тип оплаты";
            // 
            // rbtnToCard
            // 
            this.rbtnToCard.AutoSize = true;
            this.rbtnToCard.Location = new System.Drawing.Point(45, 145);
            this.rbtnToCard.Name = "rbtnToCard";
            this.rbtnToCard.Size = new System.Drawing.Size(147, 21);
            this.rbtnToCard.TabIndex = 2;
            this.rbtnToCard.TabStop = true;
            this.rbtnToCard.Text = "Перевод на карту";
            this.rbtnToCard.UseVisualStyleBackColor = true;
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.Location = new System.Drawing.Point(45, 84);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(77, 21);
            this.rbtnCard.TabIndex = 1;
            this.rbtnCard.TabStop = true;
            this.rbtnCard.Text = "Картой";
            this.rbtnCard.UseVisualStyleBackColor = true;
            // 
            // rbtnMoney
            // 
            this.rbtnMoney.AutoSize = true;
            this.rbtnMoney.Location = new System.Drawing.Point(45, 21);
            this.rbtnMoney.Name = "rbtnMoney";
            this.rbtnMoney.Size = new System.Drawing.Size(97, 21);
            this.rbtnMoney.TabIndex = 0;
            this.rbtnMoney.TabStop = true;
            this.rbtnMoney.Text = "Наличные";
            this.rbtnMoney.UseVisualStyleBackColor = true;
            // 
            // btnPayAdd
            // 
            this.btnPayAdd.Location = new System.Drawing.Point(233, 589);
            this.btnPayAdd.Name = "btnPayAdd";
            this.btnPayAdd.Size = new System.Drawing.Size(108, 27);
            this.btnPayAdd.TabIndex = 7;
            this.btnPayAdd.Text = "Провести";
            this.btnPayAdd.UseVisualStyleBackColor = true;
            this.btnPayAdd.Click += new System.EventHandler(this.BtnPayAdd_Click);
            // 
            // rbtnWithoutSale
            // 
            this.rbtnWithoutSale.AutoSize = true;
            this.rbtnWithoutSale.Location = new System.Drawing.Point(6, 15);
            this.rbtnWithoutSale.Name = "rbtnWithoutSale";
            this.rbtnWithoutSale.Size = new System.Drawing.Size(103, 21);
            this.rbtnWithoutSale.TabIndex = 8;
            this.rbtnWithoutSale.TabStop = true;
            this.rbtnWithoutSale.Text = "Нет скидки";
            this.rbtnWithoutSale.UseVisualStyleBackColor = true;
            // 
            // rbtnWithSale
            // 
            this.rbtnWithSale.AutoSize = true;
            this.rbtnWithSale.Location = new System.Drawing.Point(114, 15);
            this.rbtnWithSale.Name = "rbtnWithSale";
            this.rbtnWithSale.Size = new System.Drawing.Size(103, 21);
            this.rbtnWithSale.TabIndex = 9;
            this.rbtnWithSale.TabStop = true;
            this.rbtnWithSale.Text = "Со скидкой";
            this.rbtnWithSale.UseVisualStyleBackColor = true;
            // 
            // grbPayCount
            // 
            this.grbPayCount.Controls.Add(this.rbtnWithSale);
            this.grbPayCount.Controls.Add(this.rbtnWithoutSale);
            this.grbPayCount.Location = new System.Drawing.Point(12, 385);
            this.grbPayCount.Name = "grbPayCount";
            this.grbPayCount.Size = new System.Drawing.Size(223, 42);
            this.grbPayCount.TabIndex = 10;
            this.grbPayCount.TabStop = false;
            this.grbPayCount.Text = "Оплата";
            // 
            // LAllPay
            // 
            this.LAllPay.AutoSize = true;
            this.LAllPay.Location = new System.Drawing.Point(15, 633);
            this.LAllPay.Name = "LAllPay";
            this.LAllPay.Size = new System.Drawing.Size(46, 17);
            this.LAllPay.TabIndex = 11;
            this.LAllPay.Text = "label1";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1510, 659);
            this.Controls.Add(this.LAllPay);
            this.Controls.Add(this.grbPayCount);
            this.Controls.Add(this.btnPayAdd);
            this.Controls.Add(this.grboxTypePay);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.cmbFIO);
            this.Controls.Add(this.datePickerDateStart);
            this.Controls.Add(this.datePickerDatePay);
            this.Controls.Add(this.dbGridPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплаты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PayForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dbGridPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.grboxTypePay.ResumeLayout(false);
            this.grboxTypePay.PerformLayout();
            this.grbPayCount.ResumeLayout(false);
            this.grbPayCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGridPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typePayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tablePayBindingSource;
        private System.Windows.Forms.DateTimePicker datePickerDatePay;
        private System.Windows.Forms.DateTimePicker datePickerDateStart;
        private System.Windows.Forms.ComboBox cmbFIO;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.GroupBox grboxTypePay;
        private System.Windows.Forms.RadioButton rbtnToCard;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.RadioButton rbtnMoney;
        private System.Windows.Forms.Button btnPayAdd;
        private System.Windows.Forms.RadioButton rbtnWithoutSale;
        private System.Windows.Forms.RadioButton rbtnWithSale;
        private System.Windows.Forms.GroupBox grbPayCount;
        private System.Windows.Forms.Label LAllPay;
    }
}