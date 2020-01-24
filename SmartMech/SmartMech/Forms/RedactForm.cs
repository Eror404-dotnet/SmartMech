using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMech.Forms
{
    public partial class RedactForm : Form
    {
        
        public RedactForm()
        {
            InitializeComponent();
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            DateTimer.Start();
        }

        private void RedactForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.winm.Show();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            Forms.RedactForms.TeacherRedactFrom win =
                new RedactForms.TeacherRedactFrom();
            win.Show();
            
        }

        private void btnStudentRedact_Click(object sender, EventArgs e)
        {
            FormRedactSudents win = new FormRedactSudents();
            win.Show();
        }

        private void btnGroupRedact_Click(object sender, EventArgs e)
        {
            Forms.RedactForms.GroupRedactForm win = new Forms.RedactForms.GroupRedactForm();
            win.Show();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            LStatusTime.Text = DateTime.Now.ToString("T");
        }
    }
}
