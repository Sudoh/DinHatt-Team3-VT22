using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    public partial class StatistikForm : Form
    {
        public StatistikForm()
        {
            InitializeComponent();
        }

        private void StatistikForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click_1(object sender, System.EventArgs e)
        {

        }

        private void btnVisaStatistik_Click(object sender, System.EventArgs e)
        {
            
            listViewOrder.BeginUpdate();
            listViewOrder.Items.Clear();

            using (var db = new DinHatt())
            {
                double summa = 0;
                double moms = 0;

                foreach (var item in db.Ordrar)
                {
                    ListViewItem rad = new ListViewItem();
                    
                    if (item.OrderDate >= dateTimeStart.Value.Date && item.OrderDate <= dateTimeSlut.Value.Date && item.Delivered == true && item.Payed == true)
                    {

                        rad.SubItems.Add(item.Id.ToString());
                        rad.SubItems.Add(item.PrelimPrice.ToString());
                        rad.SubItems.Add(item.OrderDate.ToShortDateString());

                        summa = summa + item.PrelimPrice;
                        moms = moms + (item.Moms * 0.2);





                        listViewOrder.Items.Add(rad);
                    }
                }
                txtboxMoms.Text = moms.ToString();
                txtboxTotalBetal.Text = summa.ToString();
                listViewOrder.EndUpdate();
                listViewOrder.Refresh();
            }
        }
    }
}