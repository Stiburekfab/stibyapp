using stibyapp.Shared;

namespace stibyapp.Client.Services.ArtiklService
{
    public class ArtiklService : IArtiklService
    {
        public List<Artikl> Artikli { get ; set; } = new List<Artikl>();

        public void LoadArtikli()
        {
            Artikli = new List<Artikl> {
            new Artikl
            {
                Id = 1,
                Naslov = "prednji branik",
                Opis = "rabljeni",
                Slika = "https://m.media-amazon.com/images/I/41POj+NKzpL._AC_SX466_PIbundle-3,TopRight,0,0_SH20_.jpg",
                KategorijaId =1,
                Cijena = 9.99m,

            },

        new Artikl
        {
            Id = 2,
            Naslov = "zadnji far za bmw 3",
            Opis = "nov nov nov",
            KategorijaId =1,
            Slika = "https://www.hids4u.co.uk/img/P/BMW%203%20Series%20Rear%20LED%20Units.jpg?s=small",
            Cijena = 9.99m,

        },

        new Artikl
        {
            Id = 3,
            Naslov = "set kvacila fiat punto",
            Opis = "novo",
            KategorijaId =2,
            Slika = "https://www.protoxide.eu/3570-large_default/kit-zamasnjak-celik-bakar-clutch-potisna-ploca-fiat-punto-gt.jpg",
            Cijena = 9.99m,

        },


        new Artikl
        {
            Id = 4,
            Naslov = "amortizer za touareg",
            Opis = "rabljen",
            KategorijaId =2,
            Slika = "https://static.silux.si/media/cache/za/zadnji-amortizer-19-189680-volkswagen-touareg-10-9709a0a1507bc15af0fde7a1c120d8c6.jpeg",
            Cijena = 9.99m,

        },
        new Artikl
        {
            Id = 5,
            Naslov = "blatobran za passat b7",
            Opis = "nov",
            KategorijaId =1,
            Slika = "https://static.silux.si/media/cache/bl/blatobran-vg0553003-volkswagen-passat-b7-10-14-premium-tuv-rheinland-certifikat-b7f85995e58502f6174f72dc0b3aa2ab.jpeg",
            Cijena = 9.99m,

        },


      };  

     }


  }
    
    
}
