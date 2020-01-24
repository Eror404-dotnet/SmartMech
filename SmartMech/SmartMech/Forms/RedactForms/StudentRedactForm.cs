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
    public partial class FormRedactSudents : Form
    {
        public int idgrouptemp;

        public string FIOstudentTemp;
        public int AgeTemp;

        public string FIOMotherTemp;
        public string MobileMomTemp;

        public string FIOFatherTemp;
        public string MobileFatherTemp;

        public int countMobileMom;
        public int countMobileFather;

        public int studId;
        void UpdateGrid()
        {
            using (DB.Context db = new DB.Context())
            {

                gridStudent.DataSource =
                  db.Students.ToList();
                cmbGroups.DataSource =
                    db.Groups.ToList();

            }
        }


        void ClearAll()
        {
                txtFIOStudent.Text = "";
                txtAgeStudent.Text = "";
                txtFIOMom.Text = "";
                txtMobileMom.Text = "";
                txtFIOFather.Text = "";
                txtMobileFather.Text = "";
                cmbGroups.SelectedValue = -1;

        }
        public FormRedactSudents()
        {
            InitializeComponent();
            UpdateGrid();
            LStatusDate.Text = GetDate.DateNow();
            LStatusDayWeek.Text = GetDate.DayWeekNow();
            DateTimer.Start();
        }

        private void GridStudent_SelectionChanged(object sender, EventArgs e)
        {

            int id = (int)gridStudent[0, gridStudent.CurrentRow.Index].Value;

            if (gridStudent.SelectedRows.Count > 0)
            {
                Program.row = gridStudent.SelectedRows[0].Index;

                txtFIOStudent.Text = gridStudent[1, Program.row].Value.ToString();
                txtAgeStudent.Text = gridStudent[2, Program.row].Value.ToString();
                txtFIOMom.Text = gridStudent[3, Program.row].Value.ToString();
                txtMobileMom.Text = gridStudent[4, Program.row].Value.ToString();
                txtFIOFather.Text = gridStudent[6, Program.row].Value.ToString();
                txtMobileFather.Text = gridStudent[7, Program.row].Value.ToString();
                cmbGroups.SelectedValue = gridStudent[5, Program.row].Value;
                using (DB.Context db = new DB.Context())
                {
                    gridFather.DataSource =
                gridMother.DataSource =
                                          db.Students.Where(s => s.IdStudent == id).ToList();
                }
            }
            else
            {
                Program.row = -1;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FIOstudentTemp = txtFIOStudent.Text.ToString();
            AgeTemp = Int32.Parse(txtAgeStudent.Text);

            FIOMotherTemp = txtFIOMom.Text.ToString();
            MobileMomTemp = txtMobileMom.Text.ToString();

            FIOFatherTemp = txtFIOFather.Text.ToString();
            MobileFatherTemp = txtMobileFather.Text.ToString();

            idgrouptemp = (int)cmbGroups.SelectedValue;

            countMobileFather = txtMobileFather.Text.Count();
            countMobileMom = txtMobileMom.Text.Count();

            if (txtMobileFather.Text != "" || txtMobileFather.Text != "")
                if (txtMobileFather.Text.Length != 10 || txtMobileMom.Text.Length != 10)
                    MessageBox.Show("Номер должен состояить из 10 цифр. Без разделителей и кода страны", "Ошибка"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    using (DB.Context db = new DB.Context())
                    {
                        db.Students.Add(new DB.Student
                        {
                            FIO = FIOstudentTemp,
                            Age = AgeTemp,
                            FIOMother = FIOMotherTemp,
                            NumberMother = MobileMomTemp,
                            FIOFather = FIOFatherTemp,
                            NumberFather = MobileFatherTemp,
                            IdGroup = idgrouptemp
                        });

                        db.SaveChanges();
                        MessageBox.Show($"Вы успешно добавили {FIOstudentTemp}!", "Внимание!",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateGrid();
                        ClearAll();
                    }
                }
            


        
    }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            studId = (int)gridStudent[0, gridStudent.CurrentRow.Index].Value;

            
           
            using (DB.Context db = new DB.Context())
            {
                DB.Student stud = 
                    db.Students.Where(i => i.IdStudent == studId).FirstOrDefault();

                var result = MessageBox.Show($"Вы хотите удалить студента {stud.FIO}?", "Внимание!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult.Yes == result)
                {
                    db.Students.Remove(stud);

                    db.SaveChanges();
                    MessageBox.Show($"Вы успешно удалили студента {stud.FIO}!", "Внимание!",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Удаление отменено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                
                
            }
            UpdateGrid();
            ClearAll();
            }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           studId = (int)gridStudent[0, gridStudent.CurrentRow.Index].Value;


            FIOstudentTemp = txtFIOStudent.Text.ToString();
            AgeTemp = Int32.Parse(txtAgeStudent.Text);

            FIOMotherTemp = txtFIOMom.Text.ToString();
            MobileMomTemp = txtMobileMom.Text.ToString();

            FIOFatherTemp = txtFIOFather.Text.ToString();
            MobileFatherTemp = txtMobileFather.Text.ToString();

            idgrouptemp = (int)cmbGroups.SelectedValue;

            countMobileFather = txtMobileFather.Text.Count();
            countMobileMom = txtMobileMom.Text.Count();



            if (MobileMomTemp != "")
            {
                if (countMobileMom > 10)
                {
                    MessageBox.Show("Вы должны ввести телефон без +7 и разделителей", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (DB.Context db = new DB.Context())
                    {

                        DB.Student stud =
                            db.Students.Where(i => i.IdStudent == studId).FirstOrDefault();
                        stud.FIO = FIOstudentTemp;
                        stud.Age = AgeTemp;
                        stud.IdGroup = idgrouptemp;
                        stud.NumberMother = MobileMomTemp;
                        stud.FIOMother = FIOMotherTemp;
                        db.SaveChanges();
                        MessageBox.Show($"Вы успешно изменили данные о студенте {stud.FIO}!", "Внимание!",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }

            }
            if (MobileFatherTemp != "")
            {
                if (countMobileMom > 10)
                {
                    MessageBox.Show("Вы должны ввести телефон без +7 и разделителей", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (DB.Context db = new DB.Context())
                    {

                        DB.Student stud =
                            db.Students.Where(i => i.IdStudent == studId).FirstOrDefault();
                        stud.FIO = FIOstudentTemp;
                        stud.Age = AgeTemp;
                        stud.IdGroup = idgrouptemp;
                        stud.NumberFather = MobileFatherTemp;
                        stud.FIOFather = FIOFatherTemp;
                        stud.NumberMother = MobileMomTemp;
                        stud.FIOMother = FIOMotherTemp;
                        db.SaveChanges();
                        MessageBox.Show($"Вы успешно изменили данные о студенте {stud.FIO}!", "Внимание!",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                using (DB.Context db = new DB.Context())
                {
                    DB.Student stud =
                        db.Students.Where(i => i.IdStudent == studId).FirstOrDefault();

                    stud.FIO = FIOstudentTemp;
                    stud.Age = AgeTemp;
                    stud.IdGroup = idgrouptemp;
                    db.SaveChanges();
                }
            }
            UpdateGrid();
            ClearAll();
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
