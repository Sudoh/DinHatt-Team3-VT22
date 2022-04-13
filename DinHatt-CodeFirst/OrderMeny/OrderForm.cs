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
        }
}
