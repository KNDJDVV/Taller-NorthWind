using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddNorthWindServices();
Builder.Services.AddSingleton<IAppLogger>();
Builder.Services.AddSingleton<IProductService>();
using var AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();  

Service.Add("Demo", "Azucar refinada");




