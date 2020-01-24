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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
            using (DB.Context db = new DB.Context())
            {
                cmbGroup.DataSource = db.Groups.ToList();
                cmbGroup.SelectedIndex = 0;
                dbGridPay.DataSource = db.TablePays.ToList();
              
            }
        }

        private void BtnPayAdd_Click(object sender, EventArgs e)
        {
            DateTime DatePay = datePickerDatePay.Value;
            DateTime DateStart = datePickerDateStart.Value;
           
            int IdStudent = (int)cmbFIO.SelectedValue;
            string TypePay = "Наличные";
            string CountPay = "3000";
            
           
            
            
                if (rbtnWithoutSale.Checked)
                    CountPay = "3000";
                else if (rbtnWithSale.Checked)
                    CountPay = "2700";

                if (rbtnCard.Checked)
                    TypePay = "Картой";
                else if (rbtnToCard.Checked)
                    TypePay = "Перевод на карту";
                else if (rbtnMoney.Checked)
                    TypePay = "Наличные";

                using (DB.Context db = new DB.Context())
                {
                    string FIO = db.Students.Where(f => f.IdStudent == IdStudent).FirstOrDefault().FIO;
                    db.TablePays.Add(new DB.TablePay
                    {
                        TypePay = TypePay,
                        CountPay = CountPay,
                        DatePay = DatePay,
                        DateStart = DateStart,
                        FIO = FIO,
                        IdStudent = IdStudent 
                      
                    });
                db.SaveChanges();
                MessageBox.Show($"Вы успешно добавили оплату для: {FIO}!", "Успешно!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbGridPay.DataSource = db.TablePays.ToList();
            }
            

        }

        private void PayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.winm.Show();
        }

        private void CmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            using (DB.Context db = new DB.Context())
            {

                cmbFIO.DataSource = db.Students.Where(i => i.IdGroup == (int)cmbGroup.SelectedValue ).ToList();
            }
        }
    }
}
