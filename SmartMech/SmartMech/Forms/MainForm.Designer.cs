namespace SmartMech
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRedact = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusDayWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.LStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPay = new System.Windows.Forms.Button();
            this.btnJournal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(125, 71);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(191, 36);
            this.btnTeachers.TabIndex = 0;
            this.btnTeachers.Text = "Учителя";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.BtnTeachers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(125, 137);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(191, 36);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = "Студенты";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 408);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRedact
            // 
            this.btnRedact.Location = new System.Drawing.Point(125, 207);
            this.btnRedact.Name = "btnRedact";
            this.btnRedact.Size = new System.Drawing.Size(191, 36);
            this.btnRedact.TabIndex = 3;
            this.btnRedact.Text = "Редактирование";
            this.btnRedact.UseVisualStyleBackColor = true;
            this.btnRedact.Click += new System.EventHandler(this.BtnRedact_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LStatusDate,
            this.LStatusDayWeek,
            this.LStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 684);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 26);
            this.statusStrip1.TabIndex = 4;
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
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(125, 276);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(191, 36);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Оплаты";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // btnJournal
            // 
            this.btnJournal.Location = new System.Drawing.Point(125, 341);
            this.btnJournal.Name = "btnJournal";
            this.btnJournal.Size = new System.Drawing.Size(191, 36);
            this.btnJournal.TabIndex = 6;
            this.btnJournal.Text = "Журнал";
            this.btnJournal.UseVisualStyleBackColor = true;
            this.btnJournal.Click += new System.EventHandler(this.BtnJournal_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 710);
            this.Controls.Add(this.btnJournal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRedact);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnTeachers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начало";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRedact;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel LStatusDayWeek;
        private System.Windows.Forms.ToolStripStatusLabel LStatusTime;
        private System.Windows.Forms.Timer DateTimer;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnJournal;
    }
}

