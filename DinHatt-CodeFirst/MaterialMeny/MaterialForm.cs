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

namespace DinHatt_CodeFirst.MaterialMeny
{
    public partial class MaterialForm : Form
    {
        public MaterialForm()
        {
            InitializeComponent();
        }

        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            using (var db = new DinHatt())
            {

                MaterialModel nyttMaterial = new MaterialModel()
                {
                    MaterialNamn = txtMaterial.Text,
                    Langd = Convert.ToDouble(txtLangd.Text),
                    Bredd = Convert.ToDouble(txtBredd.Text),
                    Farg = txtFarg.Text,
                    
                };

                db.Material.Add(nyttMaterial);
                db.SaveChanges();

            }
        }

        private void btnMateriallista_Click(object sender, EventArgs e)
        {
            lvMaterial.BeginUpdate();
            lvMaterial.Items.Clear();

            using (var db = new DinHatt())
            {

                foreach (var item in db.Material)
                {
                    ListViewItem rad = new ListViewItem();

                    rad.SubItems.Add(item.Id.ToString());
                    rad.SubItems.Add(item.MaterialNamn);
                    rad.SubItems.Add(item.Langd.ToString());
                    rad.SubItems.Add(item.Bredd.ToString());
                    rad.SubItems.Add(item.Farg);
                    


                    lvMaterial.Items.Add(rad);
                }

                lvMaterial.EndUpdate();
                lvMaterial.Refresh();
            }
        }

        private void lvMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
