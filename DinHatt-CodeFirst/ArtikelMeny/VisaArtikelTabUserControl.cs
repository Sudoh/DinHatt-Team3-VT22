using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinHatt_CodeFirst.ArtikelMeny
{
    public partial class VisaArtikelTabUserControl : UserControl
    {
        public VisaArtikelTabUserControl()
        {
            InitializeComponent();
        }

        private void txtBeskrivning_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSokArtikelId_Click(object sender, EventArgs e)
        {
            string bildMapp = "..\\..\\Bilder";
            using (var db = new DinHatt())
            {
                int artikelId = int.Parse(txtSokArtikelId.Text);
                var artikel = (from k in db.Artiklar
                            where k.Id == artikelId
                            select k).ToList();

                foreach (var item in artikel)
                {
                    txtNyArtikelNamn.Text = item.Name;
                    txtNyAntalILager.Text = item.AntalILager.ToString();
                    txtNyBeskrivning.Text = item.Description;
                    txtNyPris.Text = item.Pris.ToString();
                    chkNyBegagnad.Checked = item.Begagnad;
             
                    picboxNyArtikelbild.ImageLocation = Path.Combine(bildMapp, item.BildNamn);
                }

            }
        }

        private void btnNySparaNyArtikel_Click(object sender, EventArgs e)
        {

        }

        private void btnNyLaddaInBild_Click(object sender, EventArgs e)
        {

        }
    }
}
