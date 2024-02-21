using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stibyapp.Shared
{
    public class Kategorija
    {
        public int Id { get; set; }

        public string Ime { get; set; }  

        public string Url { get; set; }  

        public string Ikona { get; set; } 

        public List<Artikl> Artikli { get; set; }
    }
}
