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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            DateTimer.Start();

            using (DB.Context db = new DB.Context())
            {

                gridTeachers.DataSource=
                    db.Teachers.ToList();
            }
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.winm.Show();
        }

    

        private void GridTeachers_SelectionChanged(object sender, EventArgs e)
        {
            int idteacher =
            (int)gridTeachers[0, gridTeachers.CurrentRow.Index].Value;
            using (DB.Context db = new DB.Context())
            {
                gridGroups.DataSource =
                    db.Groups.Where(i => i.IdTeacher == idteacher).ToList();
               
                
            }
        }

        private void BtnSearchFIO_Click(object sender, EventArgs e)
        {
            string FIOSearch = txtFIOSearch.Text.ToString();

            int idteacher =
           (int)gridTeachers[0, gridTeachers.CurrentRow.Index].Value;

            using (DB.Context db = new DB.Context())
            {
                gridTeachers.DataSource =
                                        db.Teachers.
                                        Where(f => f.FIO == FIOSearch).ToList();


                gridGroups.DataSource =
                    db.Groups.Where(i => i.IdTeacher == idteacher).ToList();
            }
        }

        

        private void GridGroups_SelectionChanged(object sender, EventArgs e)
        {
            int idgroup =
           (int)gridGroups[0, gridGroups.CurrentRow.Index].Value;
            string message = "Всего студентов в группе: ";
            using (DB.Context db = new DB.Context())
            {
                gridStudents.DataSource = 
                    db.Students.Where(i => i.IdGroup == idgroup).ToList();

                LStudentsCount.Text = message += db.Students.Where(i => i.IdGroup == idgroup).ToList().Count().ToString();
            }
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            LStatusTime.Text = DateTime.Now.ToString("T");
        }
    }
}
