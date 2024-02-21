using stibyapp.Shared;

namespace stibyapp.Client.Services.KategorijaService
{
    public class KategorijaService : IKategorijaService
    {
        public List<Kategorija> Kategorija { get ; set ; }= new List<Kategorija>();

        public void LoadKategorija()
        {
            Kategorija = new List<Kategorija>
            {
                new Kategorija{Id=1,Ime="Karoserija",Url="karoserija",Ikona="karoserija"},
                new Kategorija{Id=2,Ime="Ovijes",Url="ovijes",Ikona="ovijes"}
            };
        }
    }
}
