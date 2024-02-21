using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using stibyapp.Client;
using stibyapp.Client.Services.ArtiklService;
using stibyapp.Client.Services.KategorijaService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IArtiklService, ArtiklService>();
builder.Services.AddScoped<IKategorijaService, KategorijaService>();
await builder.Build().RunAsync();
