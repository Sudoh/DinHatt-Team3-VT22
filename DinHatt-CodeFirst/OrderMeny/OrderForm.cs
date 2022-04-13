using DinHatt_CodeFirst.OrderMeny;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void tabOrder_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                //Alla Kunder Tabben
                case 0:

                    break;

                //Ny Kund Tabb
                case 1:

                    NyOrderTabUserControl nyOrderTabUserControl = new NyOrderTabUserControl();
                    tabNyOrder.Controls.Add(nyOrderTabUserControl);

                    break;
                
            }

        }

        private void btnLadda_Click(object sender, System.EventArgs e)
        {
             listViewOrder.BeginUpdate();
            listViewOrder.Items.Clear();

            using (var db = new DinHatt())
            {

                foreach (var item in db.Ordrar)
                {
                    ListViewItem rad = new ListViewItem();

                    rad.SubItems.Add(item.Id.ToString());
                   // rad.SubItems.Add(item.Kund.ToString());
                    rad.SubItems.Add(item.OrderDate.ToShortDateString());
                    rad.SubItems.Add(item.PrelimPrice.ToString());
                    rad.SubItems.Add(item.Payed.ToString());
                    rad.SubItems.Add(item.Canceled.ToString());
                    rad.SubItems.Add(item.Delivered.ToString());


                    listViewOrder.Items.Add(rad);
                }

                listViewOrder.EndUpdate();
                listViewOrder.Refresh();
            }
        }
    }
}
