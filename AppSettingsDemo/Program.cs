// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json")
    .Build();

Console.WriteLine("Hello, World!");
Console.WriteLine("The Config data from appSettings is:" + configuration["Connection"]);
Console.ReadLine();


