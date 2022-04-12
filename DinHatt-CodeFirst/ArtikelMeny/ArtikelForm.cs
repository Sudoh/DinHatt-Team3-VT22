using DinHatt_CodeFirst.ArtikelMeny;
using System;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class Artikelform : Form
    {


        public Artikelform()
        {
            InitializeComponent();

        }

        private void Artikelform_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Artikelform_Load(object sender, EventArgs e)
        {

        }

        private void tabNyArtikel_Click(object sender, EventArgs e)
        {

        }

        private void Artikelform_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVisaArtiklar_Click(object sender, EventArgs e)
        {

        }

        private void tabArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
			switch ((sender as TabControl).SelectedIndex)
			{
				//Alla Artiklar Tab
				case 0:
                    //Gör inget eftersom det är default tab som öppnas just nu.
					break;

				//Ny Artikel Tab
				case 1:

					NyArtikelTabUserControl nyArtikelUserControl = new NyArtikelTabUserControl();
					tabNyArtikel.Controls.Add(nyArtikelUserControl);

					break;


				//Visa Artikel tab
				case 2:

					VisaArtikelTabUserControl visaArtikelTabUserControl = new VisaArtikelTabUserControl();
					tabVisaArtikel.Controls.Add(visaArtikelTabUserControl);

					break;


            }
        }
    }
}
