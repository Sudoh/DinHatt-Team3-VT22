using System;
using System.Windows.Forms;
using Models;
using System.Linq;
using DinHatt_CodeFirst.KundMeny;

namespace DinHatt_CodeFirst.KundMeny
{
    public partial class VisaKundTabUserControl : UserControl
    {
        public VisaKundTabUserControl()
        {
            InitializeComponent();
        }


        //collection.Where(t => t.Contains(searchString)).ToList()
        private void btnSok_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int KundID = int.Parse(txtKundID.Text);
                var Kund = (from k in db.Kunder
                            where k.Id == KundID
                            select k).ToList();

                foreach(var item in Kund)
                {
                    txtFnamn.Text = item.FNamn;
                    txtEnamn.Text = item.ENamn;
                    txtAdress.Text = item.Adress;
                    txtPostnr.Text = Convert.ToString(item.PostalCode);
                    txtOrt.Text = item.City;
                    txtTele.Text = Convert.ToString(item.TelephoneNumber);
                    //txtLand.Text = item.Land;
                    txtEpost.Text = item.ePost;
                    
                }
                
            }

        }

        private void btnAndra_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {

        }

        private void txtFnamn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
