using BlazorDotNet8Crud.Shared.Services;
using BlazorDotNet8Crud.Shared.Services.Contracts;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<IGameService, ClientGameService>();

await builder.Build().RunAsync();
