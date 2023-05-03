// See https://aka.ms/new-console-template for more information
using CsvDataTransfer.Interfaces;
using CsvDataTransfer.Processing;
using CsvDataTransfer.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

using IHost host = Host.CreateDefaultBuilder()
            .ConfigureServices((_, services) =>
            {
                services.AddScoped<ICsvLoadable, LoaderCsv>();
                services.AddSingleton<ICsvParsable, ParserCsv>();
                services.AddScoped<ICsvModelRepository, CsvModelsRepository>();
                services.AddScoped<IService, ProcessData>();
            })
            .Build();

using IServiceScope serviceScope = host.Services.CreateScope();
IServiceProvider serviceProvider = serviceScope.ServiceProvider;

IService service = serviceProvider.GetRequiredService<IService>();

string assemblyPath = Assembly.GetExecutingAssembly().Location;
string assemblyDirectory = Path.GetDirectoryName(assemblyPath);

var csvpath = Path.Combine(assemblyDirectory, "offers.csv");
service.TransferCsvFileToDb(csvpath);
