using System;
using System.Collections.Generic;

namespace Models
{
    public class Order
    {
        //Attribut i databasen
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        public double PrelimPrice { get; set; }
        public bool Delivered { get; set; }
        public bool Payed { get; set; }
        public bool Canceled { get; set; }
        public string Description { get; set; }

        public string Orderbeställare { get; set; }   

        //1-till-många samband. Varje order måste ha en kund.
        public Kund KundId { get; set; }

        //Säger till databasen att det ska vara FK
        public ICollection<Artikel> Artikel { get; set; }

        //Kod för att Entityframwork ska förstå många-till-många samband
        public Order()
        {
            Artikel = new HashSet<Artikel>();
        }

    }
}
