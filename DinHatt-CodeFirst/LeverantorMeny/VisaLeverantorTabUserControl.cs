using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinHatt_CodeFirst.LeverantorMeny
{
    public partial class VisaLeverantorTabUserControl : UserControl
    {
        public VisaLeverantorTabUserControl()
        {
            InitializeComponent();
        }

        private void sokForebtn_Click(object sender, EventArgs e)
        {
            /*äusing (var db = new DinHatt())
            {
                int ForetagsID = int.Parse(leverantorIdtxt.Text);
                var Foretag = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();

                foreach (var item in Kund)
                {
                    txtFnamn.Text = item.FNamn;
                    txtEnamn.Text = item.ENamn;
                    txtAdress.Text = item.Adress;
                    txtPostnr.Text = Convert.ToString(item.PostalCode);
                    txtOrt.Text = item.City;
                    txtTele.Text = item.TelephoneNumber;
                    //txtLand.Text = item.Land;
                    txtEpost.Text = item.ePost;

                }

            }*/
        }
    }
}
