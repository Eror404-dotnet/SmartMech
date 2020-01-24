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
    public partial class PrisutForm : Form
    {
        void UpdateGrid()
        {


            using (DB.Context db = new DB.Context())
            {
                
                cmbFIOSearch.DataSource = db.Students.Where(s => s.IdGroup == (int)cmbGroup.SelectedValue).ToList();
                cmbFIO.DataSource = db.Students.Where(s => s.IdGroup == (int)cmbGroup.SelectedValue).ToList();
                dbgridPrisut.DataSource = db.TablePrisuts.Where(g => g.IdGroup == (int)cmbGroup.SelectedValue).ToList();
            }
        }
        

        public PrisutForm()
        {
            InitializeComponent();

            int idgroup = cmbGroup.SelectedIndex;
                LStatusDate.Text = GetDate.DateNow();
                LStatusDayWeek.Text = GetDate.DayWeekNow();
                DateTimer.Start();
            using (DB.Context db = new DB.Context())
            {
                cmbGroup.DataSource = db.Groups.ToList();
            }
                UpdateGrid();   
            
        }

        private void PrisutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.winm.Show();
        }

        private void CmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (DB.Context db = new DB.Context())
            {
                cmbFIOSearch.DataSource = db.Students.Where(s => s.IdGroup == 
                (int)cmbGroup.SelectedValue).ToList();
                cmbFIO.DataSource = db.Students.Where(s => s.IdGroup ==
               (int)cmbGroup.SelectedValue).ToList();
                dbgridPrisut.DataSource = db.TablePrisuts.Where(g => g.IdGroup == (
                int)cmbGroup.SelectedValue).ToList();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DateTime DatePrisut = datePickerToday.Value;
            int IdStudent = (int)cmbFIO.SelectedValue;
            string prisut = "Да";
            int idgroup = (int)cmbGroup.SelectedValue;

            if (rbtnNo.Checked)
                prisut = "Нет";
            else if (rbtnYes.Checked)
                prisut = "Да";
            else if (rbtnOfficial.Checked)
                prisut = "Предупредил";

            using (DB.Context db = new DB.Context())
            {
                
                string FIO = db.Students.Where(f => f.IdStudent == IdStudent).FirstOrDefault().FIO;
                string groupname = db.Groups.Where(g => g.IdGroup == idgroup).FirstOrDefault().GroupName;
                
                db.TablePrisuts.Add(new DB.TablePrisut
                {
                    FIO = FIO,
                    GroupName = groupname,
                    Date = DatePrisut,
                    IdGroup= idgroup,
                    IdStudent= IdStudent,
                    Prisut = prisut
                });
                db.SaveChanges();
                UpdateGrid();
            }
        }

        private void DatePickerToday_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void BtnDateSearch_Click(object sender, EventArgs e)
        {
            int idgroup = (int)cmbGroup.SelectedValue;
            
            using (DB.Context db = new DB.Context())
            {
                dbgridPrisut.DataSource = db.TablePrisuts.Where
                   (i =>  (i.Date == TimePickerDateSearch.Value.Date) && (i.IdGroup == idgroup)).ToList();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            int prisutidId = (int)dbgridPrisut[0, dbgridPrisut.CurrentRow.Index].Value;
            DateTime DatePrisut = datePickerToday.Value;
            string prisut = "Да";
            if (rbtnNo.Checked)
                prisut = "Нет";
            else if (rbtnYes.Checked)
                prisut = "Да";
            else if (rbtnOfficial.Checked)
                prisut = "Предупредил";
            using (DB.Context db = new DB.Context())
            {
                DB.TablePrisut prisup = db.TablePrisuts.Where(i => i.IdPrisut == prisutidId).FirstOrDefault();

                prisup.Prisut = prisut;
                prisup.Date = DatePrisut;
                db.SaveChanges();
                UpdateGrid();
            }

        }

      /*  private void DbgridPrisut_SelectionChanged(object sender, EventArgs e)
        {
            int prisutidId = (int)dbgridPrisut[0, dbgridPrisut.CurrentRow.Index].Value;
            if (dbgridPrisut.SelectedRows.Count > 0)
            {
                Program.row = dbgridPrisut.SelectedRows[0].Index;
                datePickerToday.Value = (DateTime)dbgridPrisut[5, Program.row].Value;
                cmbFIO.SelectedValue = (int)dbgridPrisut[1, Program.row].Value;
                cmbGroup.SelectedValue = (int)dbgridPrisut[2, Program.row].Value;

                if (dbgridPrisut[6, Program.row].Value.ToString() == "Да")
                {
                    rbtnYes.Checked = true;
                }
                else if (dbgridPrisut[6, Program.row].Value.ToString() == "Нет")
                {
                    rbtnNo.Checked = true;
                }
                else
                {
                    rbtnOfficial.Checked = true;
                }
            }
            */
        

        private void BtnFIOSearch_Click(object sender, EventArgs e)
        {
            int IdStudent = (int)cmbFIOSearch.SelectedValue;
            using (DB.Context db = new DB.Context())
            {
                dbgridPrisut.DataSource = db.TablePrisuts.Where(i => i.IdStudent == IdStudent).ToList();
            }
        }

        private void MbtnClear_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            LStatusTime.Text = DateTime.Now.ToString("T");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int prisutidId = (int)dbgridPrisut[0, dbgridPrisut.CurrentRow.Index].Value;
            using (DB.Context db = new DB.Context())
            {
                DB.TablePrisut prisdel = db.TablePrisuts.Where(i => i.IdPrisut == prisutidId).FirstOrDefault();

                db.TablePrisuts.Remove(prisdel);
                db.SaveChanges();
                UpdateGrid();
            }
        }
    }
}
