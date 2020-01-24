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
    public partial class GroupRedactForm : Form
    {
        void UpdateGrid()
        {
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            DateTimer.Start();
            using (DB.Context db = new DB.Context())
            {

                gridGroup.DataSource =
                  db.Groups.ToList();
                cmbTeacher.DataSource =
                    db.Teachers.ToList();
            }
        }

        void ClearAll()
        {
            txtGroupName.Text = "";
            rbtnEV3.Checked = false;
            rbtnWeDo.Checked = false;
            PickerDay.Value = DateTime.Now ;
            cmbTeacher.SelectedValue = -1;
        }
        public int id;
        public string GroupNameTemp;
        public DateTime daystart;
        public int teacherid;
        public string setNameTemp;
        public GroupRedactForm()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            GroupNameTemp = txtGroupName.Text.ToString();
            daystart = PickerDay.Value;
            teacherid = (int)cmbTeacher.SelectedValue;
            
            if (rbtnEV3.Checked)
            {
                
                setNameTemp = "EV3";
               
            }
            else
            {
               
                setNameTemp = "WeDo";
                
            }

            if (GroupNameTemp == "" || teacherid < 0)
            {
                MessageBox.Show("Вы не заполнили все поля!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (DB.Context db = new DB.Context())
                {
                    db.Groups.Add(new DB.Group
                    {
                        GroupName = GroupNameTemp,
                        Day = daystart,
                        IdTeacher = teacherid,
                        SetName = setNameTemp
                    });
                    db.SaveChanges();
                    MessageBox.Show($"Группа {GroupNameTemp} успешно добавлена!", "Внимание!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();

                  
                }
                }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            id = (int)gridGroup[0, gridGroup.CurrentRow.Index].Value;
            GroupNameTemp = txtGroupName.Text.ToString();
            daystart = PickerDay.Value;
            teacherid = (int)cmbTeacher.SelectedValue;
            
            if (rbtnEV3.Checked)
            {
               
                setNameTemp = "EV3";
                
            }
            else
            {
              
                setNameTemp = "WeDo";

            }


            if (GroupNameTemp == "" || teacherid < 0 )
            {
                MessageBox.Show("Вы не заполнили все поля!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (DB.Context db = new DB.Context())
                {
                    DB.Group group = 
                        db.Groups.Where(i => i.IdGroup == id).FirstOrDefault();

                    group.GroupName = GroupNameTemp;
                    group.Day = daystart;
                    group.IdTeacher = teacherid;
                    group.SetName = setNameTemp;

                    db.SaveChanges();
                    MessageBox.Show($"Группа {GroupNameTemp} успешно обновлена!", "Внимание!",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                }
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            id = (int)gridGroup[0, gridGroup.CurrentRow.Index].Value;
            using (DB.Context db = new DB.Context())
            {
                DB.Group gr = db.Groups.Where(i => i.IdGroup == id).FirstOrDefault();

                db.Groups.Remove(gr);

                try
                {
                    db.SaveChanges();

                }
                catch(Exception)
                {
                    var result = MessageBox.Show($"В группе {GroupNameTemp} присутсвуют ученики! Удалить учеников из школы?", 
                        "Внимание!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == result)
                    {
                       
                        var stud = db.Students.Where(i => i.IdGroup == id);
                        foreach (DB.Student students in stud)
                        {
                            db.Students.Remove(students);
                        }

                        
                        
                        
                        db.SaveChanges();
                        MessageBox.Show($"Группа {gr.GroupName} успешно удалена и студенты удалены!", "Внимание!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
                UpdateGrid();
            }

        }

        private void GridGroup_SelectionChanged(object sender, EventArgs e)
        {

            if (gridGroup.SelectedRows.Count > 0)
            {
                Program.row = gridGroup.SelectedRows[0].Index;

                txtGroupName.Text = gridGroup[1, Program.row].Value.ToString();
                if (gridGroup[2, Program.row].Value.ToString() == "EV3")
                {
                    rbtnEV3.Checked = true;
                }
                else
                {
                    rbtnWeDo.Checked = true;
                }
                PickerDay.Value = (DateTime)gridGroup[3, Program.row].Value;
                cmbTeacher.SelectedValue = gridGroup[4, Program.row].Value;
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
