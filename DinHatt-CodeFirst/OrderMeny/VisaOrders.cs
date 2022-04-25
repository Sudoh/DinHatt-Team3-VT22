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
                    tbxOrderId.Text = item.Id.ToString();

                    foreach (int i in ArtikelList.SelectedIndices)
                    {
                        ArtikelList.Items[i].ToString();
                    }

                    tbxOrderDes.Text = item.Description;

                    tbxTotalPrice.Text= item.PrelimPrice.ToString();








                }
            }
        }
    }
}
