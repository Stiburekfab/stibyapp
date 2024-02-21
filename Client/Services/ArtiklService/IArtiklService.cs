using stibyapp.Shared;
namespace stibyapp.Client.Services.ArtiklService
{
    public interface IArtiklService
    {
        List<Artikl> Artikli { get; set;}
        void LoadArtikli();
    }
}
