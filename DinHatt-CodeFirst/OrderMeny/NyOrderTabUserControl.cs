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

            if(!rdBtnJudith.Checked && !rdBtnOtto.Checked)
            {
                MessageBox.Show("Var vänlig och fyll in vem som skapar ordern.");
            }

            else
            {

                string radionamn = FindOrderHandler();

                float momssats = FindMomsSats();

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

                        KundId = Convert.ToInt32(txSökKund.Text),

                        Moms = momssats,

                    };

                    db.Ordrar.Add(nyOrder);
                    db.SaveChanges();

                }

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

        private float FindMomsSats()
        {
            float prePris = 0;
            prePris = float.Parse(tbxPrice.Text);
            float momssats = (prePris * 1.25F);

            return momssats;

        }

        private void btnSökKund_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(txSökKund.Text);
                var Kund = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();

                foreach (var item in Kund)
                {
                    tbKundNamn.Text = item.FNamn + item.ENamn;
                  
                }
            }

        }

        private void NyOrderTabUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
