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
    public partial class VisaOrders : UserControl
    {
        public VisaOrders()
        {
            InitializeComponent();
        }

        private void btnDeletOrder_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbxOrderId.Text);
                var Order = (from k in db.Ordrar
                               where k.Id == OrderId
                               select k).ToList();

                foreach (var item in Order)
                {
                    item.Aktiv = false;

                }

                db.SaveChanges();

                tbSökOrderId.Clear();
                tbxOrderDes.Clear();
                tbxOrderId.Clear();
                tbxTotalPrice.Clear();
                ArtikelList.Items.Clear();
                cbxSkickad.Checked=false;
                cbxBetalad.Checked = false;

                MessageBox.Show("Du har tagit bort order!");


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSökOrderId_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbSökOrderId.Text);
                var Order = (from k in db.Ordrar
                             where k.Id == OrderId
                             select k).ToList();

                foreach (var item in Order)
                {
                    if (item.Aktiv == true)
                    {
                        tbxOrderId.Text = item.Id.ToString();

                        ArtikelList.Items.AddRange(item.ArtikelTitle.ToString().Split(','));

                        tbxOrderDes.Text = item.Description;

                        tbxTotalPrice.Text = item.PrelimPrice.ToString();

                        cbxBetalad.Checked = item.Payed;

                        cbxSkickad.Checked = item.Delivered;
                    }
                    else
                    {
                        MessageBox.Show("Thier is no order to show!");
                    }







                }
            }
        }

        private void btnÄndraOrder_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int OrderId = int.Parse(tbSökOrderId.Text);
                var Order = (from k in db.Ordrar
                             where k.Id == OrderId
                             select k).ToList();



                foreach (var item in Order)
                {

                    item.Description = tbxOrderDes.Text;
                    item.Payed = cbxBetalad.Checked;
                    item.Delivered = cbxSkickad.Checked;
                    item.PrelimPrice = int.Parse(tbxTotalPrice.Text);
                  

                }

                db.SaveChanges();
            }

            
        }
            }
}
