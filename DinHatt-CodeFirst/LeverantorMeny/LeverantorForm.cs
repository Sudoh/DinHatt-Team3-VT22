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
    public partial class LeverantorForm : Form
    {
        public LeverantorForm()
        {
            InitializeComponent();
        }

        private void btnVisaLeverantorer_Click(object sender, EventArgs e)
        {
            listLeverantor.BeginUpdate();
            listLeverantor.Items.Clear();

            using (var db = new DinHatt())
            {

                foreach (var item in db.Leverantorer)
                {
                    ListViewItem rad = new ListViewItem();

                    rad.SubItems.Add(item.foretagsId.ToString());
                    rad.SubItems.Add(item.foretagsNamn);
                    rad.SubItems.Add(item.foretagsAdress);
                    rad.SubItems.Add(item.foretagsPostNr.ToString());
                    rad.SubItems.Add(item.foretagsOrt);
                    rad.SubItems.Add(item.foretagsLand);
                    rad.SubItems.Add(item.foretagsTele);
                    rad.SubItems.Add(item.foretagsEpost);

                    listLeverantor.Items.Add(rad);
                }

                listLeverantor.EndUpdate();
                listLeverantor.Refresh();
            }
        }
    }
}
