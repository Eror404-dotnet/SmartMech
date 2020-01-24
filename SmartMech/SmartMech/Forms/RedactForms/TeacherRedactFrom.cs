using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMech.Forms.RedactForms
{
    public partial class TeacherRedactFrom : Form
    {
        void UpdateGrid()
        {
            using (DB.Context db = new DB.Context())
            {


                dbgridTeacher.DataSource = db.Teachers.ToList();

            }
        }

        void ClearAll()
        {
            txtFIO.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
        }

        public TeacherRedactFrom()
        {
            InitializeComponent();
            UpdateGrid();
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            DateTimer.Start();



        }

        private void TeacherRedactFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*
           Forms.RedactForm win = new RedactForm();
            win.Show();
            this.Close();
            */
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string FIOtemp = txtFIO.Text.ToString();
            string MobileTemp = txtMobile.Text.ToString();
            string EmailTemp = txtEmail.Text.ToString();

            if (txtFIO.Text == "" || txtMobile.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Вы не заполнили все поля!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (DB.Context db = new DB.Context())
                {
                    db.Teachers.Add(new DB.Teacher
                    {
                        FIO = FIOtemp,
                        MobilePhone = MobileTemp,
                        MailBox = EmailTemp
                    });


                    db.SaveChanges();

                    MessageBox.Show($"Вы успешно добавили {FIOtemp}!", "Внимание!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                    ClearAll();
                   

                }
            }
            
            
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dbgridTeacher[0, dbgridTeacher.CurrentRow.Index].Value;
            string FIOtemp = txtFIO.Text.ToString();
            string MobileTemp = txtMobile.Text.ToString();
            string EmailTemp = txtEmail.Text.ToString();

           
            
                using (DB.Context db = new DB.Context())
                {
                       DB.Teacher teach = db.Teachers.Where(t => t.IdTeacher == id).FirstOrDefault();

                       var result =MessageBox.Show($"Вы хотите удалить {teach.FIO}?","Внимание!",
                             MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                            if (DialogResult.Yes == result)
                            {
                                db.Teachers.Remove(teach);
                                MessageBox.Show($"Вы успешно удалили {teach.FIO}?", "Внимание!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                db.SaveChanges();
                                UpdateGrid();
                                ClearAll();
                            }
                }

            

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)dbgridTeacher[0, dbgridTeacher.CurrentRow.Index].Value;
            string FIOtemp = txtFIO.Text.ToString();
            string MobileTemp = txtMobile.Text.ToString();
            string EmailTemp = txtEmail.Text.ToString();

            if (txtFIO.Text == "" || txtMobile.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Вы не заполнили все поля!", "Ошибка!",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                using (DB.Context db = new DB.Context())
                {
                    DB.Teacher teach = db.Teachers.Where(t => t.IdTeacher == id).FirstOrDefault();

                    teach.FIO = FIOtemp;
                    teach.MobilePhone = MobileTemp;
                    teach.MailBox = EmailTemp;
                    MessageBox.Show($"Вы успешно изменили данные учителя на {FIOtemp} {MobileTemp} {EmailTemp}",
                  "Внимание!",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.SaveChanges();
                    UpdateGrid();
                    ClearAll();
                }
            }
        }

        private void DbgridTeacher_SelectionChanged(object sender, EventArgs e)
        {

            if (dbgridTeacher.SelectedRows.Count > 0)
            {
                Program.row = dbgridTeacher.SelectedRows[0].Index;

                txtFIO.Text = dbgridTeacher[1, Program.row].Value.ToString();
                txtMobile.Text = dbgridTeacher[2, Program.row].Value.ToString();
                txtEmail.Text = dbgridTeacher[3, Program.row].Value.ToString();

            }
            else
            {
                Program.row = -1;
            }
        }

        private void MbtnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            LStatusTime.Text = DateTime.Now.ToString("T");
        }
    }
}
