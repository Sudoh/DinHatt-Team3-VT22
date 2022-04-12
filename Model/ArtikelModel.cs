using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Artikel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public double HeadSize { get; set; }

        public double Pris { get; set; }

        //Kod för många-till-många i databsen.
        public virtual ICollection<Order> Order { get; set; }

        //lite omvänt tycker jag, men här behöver skrivas för att i Ordertabellen ska finnas en FK till artikel.
        //Skapar ett måste att varje order måste ha en artikel.
        public Artikel()
        {
            Order = new HashSet<Order>();
        }
    }
}
