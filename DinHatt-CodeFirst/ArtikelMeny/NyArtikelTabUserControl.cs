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
    public partial class NyArtikelTabUserControl : UserControl
    {
        public NyArtikelTabUserControl()
        {
            InitializeComponent();
        }


        private void btnSparaNyArtikel_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {

                Artikel nyArtikel = new Artikel()
                {
                    Name = txtArtikelNamn.Text,
                    Description = txtBeskrivning.Text,
                    AntalILager = int.Parse(txtAntalILager.Text),
                    Begagnad = chkBegagnad.Checked,
                    Pris = double.Parse(txtPris.Text)

                };

                db.Artiklar.Add(nyArtikel);
                db.SaveChanges();

            }
        }
    }
}
