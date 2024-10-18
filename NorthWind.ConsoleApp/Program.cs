using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddConsoleWriter();
Builder.Services.AddDebugWriter();
Builder.Services.AddFileWriter();
Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using var AppHost = Builder.Build();

AppLogger Logger = AppHost.Services.GetRequiredService<AppLogger>();
Logger.WriteLog("Application started");

ProductService Service = AppHost.Services.GetRequiredService<ProductService>();  

Service.Add("Demo", "Azucar refinada");




