using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using portfolio.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

// Component Services
builder.Services.AddScoped<JsonProjectService>();

builder.Services.AddMudServices();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
