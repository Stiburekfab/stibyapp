using stibyapp.Shared;
namespace stibyapp.Client.Services.KategorijaService
{
    public interface IKategorijaService
    {
        public List<Kategorija> Kategorija { get; set; }
        void LoadKategorija();
    }
}
