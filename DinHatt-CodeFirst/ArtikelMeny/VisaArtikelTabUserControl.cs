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
            using (var db = new DinHatt())
            {
                int artikelID = int.Parse(txtSokArtikelId.Text);
                var artikel = (from a in db.Artiklar
                               where a.Id == artikelID
                               select a).ToList();

                foreach (var item in artikel)
                {
                    item.Name = txtNyArtikelNamn.Text;
                    item.Pris = Convert.ToDouble(txtNyPris.Text);
                    item.BildNamn = txtNyBildNamn.Text;
                    item.AntalILager = int.Parse(txtNyAntalILager.Text);
                    item.Begagnad = chkNyBegagnad.Checked;
                    item.Description = txtNyBeskrivning.Text;
                    //tabortstorlektxt.Text = Convert.ToString(item.HeadSize);

                }

                txtSokArtikelId.Clear();
                txtNyArtikelNamn.Clear();
                txtNyBeskrivning.Clear();
                txtNyPris.Clear();
                txtNyAntalILager.Clear();
                chkNyBegagnad.Checked = false;
                txtNyBildNamn.Clear();
                picboxNyArtikelbild.Image = null;
                MessageBox.Show("Vald artikel är nu uppdaterad!");

                db.SaveChanges();
            }
        }

        private void btnNyLaddaInBild_Click(object sender, EventArgs e)
        {

        }

        private void btnTaBortArtikel_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {
                int ArtikelID = int.Parse(txtSokArtikelId.Text);
                var artikel = db.Artiklar.FirstOrDefault(a => a.Id == ArtikelID);

                if (artikel != null)
                {
                    db.Artiklar.Remove(artikel);
                    db.SaveChanges();
                }

                txtSokArtikelId.Clear();
                txtNyArtikelNamn.Clear();
                txtNyBeskrivning.Clear();
                txtNyPris.Clear();
                txtNyAntalILager.Clear();
                chkNyBegagnad.Checked = false;
                txtNyBildNamn.Clear();
                picboxNyArtikelbild.Image = null;
                MessageBox.Show("Vald artikel är nu bortagen!");

            }
        }
    }
}
