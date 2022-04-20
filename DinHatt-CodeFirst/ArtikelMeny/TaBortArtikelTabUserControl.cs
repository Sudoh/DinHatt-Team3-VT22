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

namespace DinHatt_CodeFirst.ArtikelMeny
{
    public partial class TaBortArtikelTabUserControl : UserControl
    {
        public TaBortArtikelTabUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabortbtn_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                Artikel nyArtikel = new Artikel()
                {
                    Name = tabortnamntxt.Text

                };

                db.Artiklar.Remove(nyArtikel);
                db.SaveChanges();

            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void TaBortArtikelTabUserControl_Load(object sender, EventArgs e)
        {

        }

        private void visatabortbtn_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int Id = int.Parse(visatabortarttxt.Text);
                var artikel = (from a in db.Artiklar
                            where a.Id == Id
                            select a).ToList();

                foreach (var item in artikel)
                {
                    tabortnamntxt.Text = item.Name;
                    /*Int Pris = double.Parse(tabortpristxt.Text);
                    tabortbildtxt.Text = item.BildNamn;
                    item.AntalILager = int.Parse(tabortantaltxt.Text);
                    tabortbegtxt.Text = item.Begagnad;*/

                }

            }
        }
    }
}
