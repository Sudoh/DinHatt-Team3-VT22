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
                int ArtikelID = int.Parse(visatabortarttxt.Text);
                var artikel = db.Artiklar.FirstOrDefault(a => a.Id == ArtikelID);

                if (artikel != null)
                {
                    db.Artiklar.Remove(artikel);
                    db.SaveChanges();
                }

                visatabortarttxt.Clear();
                tabortnamntxt.Clear();
                tabortstorlektxt.Clear();
                tabortpristxt.Clear();
                tabortbildtxt.Clear();
                tabortantaltxt.Clear();
                tabortbegtxt.Clear();
                MessageBox.Show("Vald artikel är nu bortagen!");

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
                    tabortpristxt.Text = Convert.ToString(item.Pris);
                    tabortbildtxt.Text = item.BildNamn;
                    tabortantaltxt.Text = Convert.ToString(item.AntalILager);
                    tabortbegtxt.Text = Convert.ToString(item.Begagnad);
                    tabortstorlektxt.Text = Convert.ToString(item.HeadSize);
                    if
                        (item.Begagnad == true)
                    {
                        tabortbegtxt.Text = "Ja";
                    }
                    else
                    {
                        tabortbegtxt.Text = "Nej";
                    };
                    //Hur fixar man storleken?

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
