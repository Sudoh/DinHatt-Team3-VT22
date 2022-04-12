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
                //Alla Artiklar Tabben
                case 0:

                    break;

                    //Ny Artikel Tabb
                    case 1:

                    NyArtikelUserControl nyArtikelUserControl = new NyArtikelUserControl();
                    
                    tabNyArtikel.Controls.Add(nyArtikelUserControl);

                    break;


            }
        }
    }
}
