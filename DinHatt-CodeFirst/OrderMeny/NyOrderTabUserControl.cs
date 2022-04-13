﻿using Models;
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
            using (var db = new DinHatt())
            {

                Order nyOrder = new Order()
                {
                    Description = tbxDescription.Text,

                    PrelimPrice = int.Parse(tbxPrice.Text),

                    Payed = cbxPayed.Checked,

                    Delivered = cbxDelivered.Checked,

                };

                //if (rdBtnJudith.Checked)
                //{

                //    rdBtnJudith.Text;

                //}




                db.Ordrar.Add(nyOrder);
                db.SaveChanges();
            }
        }
    }
}
