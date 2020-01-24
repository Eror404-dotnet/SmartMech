using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            
        }

        private void BtnTeachers_Click(object sender, EventArgs e)
        {
            Forms.TeacherForm win = new Forms.TeacherForm();
            win.Show();
            this.Hide();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Forms.StudentsFrom win = new Forms.StudentsFrom();
            win.Show();
            this.Hide();
        }

        private void BtnRedact_Click(object sender, EventArgs e)
        {
                   
            
          Forms.RedactForm win = new Forms.RedactForm();
          win.Show();
           this.Hide();
      
           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            LStatusTime.Text = DateTime.Now.ToString("T");
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            Forms.PayForm win = new Forms.PayForm();
            win.Show();
            this.Hide();
        }

        private void BtnJournal_Click(object sender, EventArgs e)
        {
            Forms.PrisutForm win = new Forms.PrisutForm();
            win.Show();
            this.Hide();
        }
    }
}
