using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stibyapp.Shared
{
    public class Artikl
    {
        public int Id { get; set; }

        public string Opis { get; set; } 

        public string Naslov { get; set; }

        public string Slika { get; set; } = "https://via.placeholder.com/300x300";

        public decimal Cijena { get; set; }

        public bool Ispublic { get; set; }
        public bool Isdeleted { get; set; }

        public Kategorija Kategorija { get; set; }

        public int KategorijaId { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public DateTime Dateupdated { get; set; }



        

    }
}
