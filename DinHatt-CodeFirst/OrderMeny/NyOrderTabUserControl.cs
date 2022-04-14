using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinHatt_CodeFirst.OrderMeny
{
    public partial class NyOrderTabUserControl : UserControl
    {

        public NyOrderTabUserControl()
        {
            InitializeComponent();
        }

        private void btnNyOrder_Click(object sender, EventArgs e)
        {
            string radionamn = FindOrderHandler();
            using (var db = new DinHatt())
            {


                Order nyOrder = new Order()
                {

                    Description = tbxDescription.Text,

                    PrelimPrice = double.Parse(tbxPrice.Text),

                    Payed = cbxPayed.Checked,

                    Delivered = cbxDelivered.Checked,

                    OrderDate = dateTimePicker1.Value.Date,

                    Orderbeställare = radionamn,

                };
               
                db.Ordrar.Add(nyOrder);
                db.SaveChanges();
            }
        }

        private string FindOrderHandler()
        {
            string radionamn = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            switch (radionamn)
            {
                case "rdBtnJudith":
                    radionamn = "Judith";
                    break;
                case "rdBtnOtto":
                    radionamn = "Otto";
                    break;
                default:
                    MessageBox.Show("Var vänlig och fyll in vem som skapar ordern.");
                    break;
            }

            return radionamn;
        }

        private void btnSökKund_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(tbKundID.Text);
                var Kund = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();
            }

            }
    }
}
