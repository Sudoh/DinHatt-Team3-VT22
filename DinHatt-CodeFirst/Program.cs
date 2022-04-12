using Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace DinHatt_CodeFirst
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenyForm());
        }
    }


    public class DinHatt : DbContext
    {
        //Här initialiseras alla tabeller i databasen när program körs. 
        //Finns det något här så skapas det en tabell.
        public DbSet<Artikel> Artiklar { get; set; }
        public DbSet<Order> Ordrar { get; set; }
        public DbSet<Kund> Kunder { get; set; }

    }
}
