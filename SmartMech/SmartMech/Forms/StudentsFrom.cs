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
    public partial class StudentsFrom : Form
    {
        public StudentsFrom()
        {
            InitializeComponent();
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            DateTimer.Start();
            using (DB.Context db = new DB.Context())
            {
                gridStudent.DataSource = 
                    db.Students.ToList();

                
            }
        }

        private void StudentsFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.winm.Show();
        }

        private void GridFather_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void GridStudent_SelectionChanged(object sender, EventArgs e)
        {
            using (DB.Context db = new DB.Context())
            {
                int id = (int)gridStudent[0, gridStudent.CurrentRow.Index].Value;
                gridFather.DataSource = 
                gridMother.DataSource =
                                          db.Students.Where(s => s.IdStudent == id).ToList();
                
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string FIOsearch = txtFIOSearch.Text.ToString();

            using (DB.Context db = new DB.Context())
            {

                int id = (int)gridStudent[0, gridStudent.CurrentRow.Index].Value;
                gridStudent.DataSource = 
                    db.Students.Where(f => f.FIO == FIOsearch).ToList();

               gridFather.DataSource =
               gridMother.DataSource =
                                         db.Students.Where(s => s.IdStudent == id).ToList();
            }
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            LStatusTime.Text = DateTime.Now.ToString("T");
        }
    }
}
