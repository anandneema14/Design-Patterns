using MassTransit;
using Contracts;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Consumer;

internal class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddMassTransit(x =>
        {
            x.AddConsumer<ItemCreatedMessageConsumer>();

            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("localhost", "/", h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                cfg.ConfigureEndpoints(context);
            });
        });

        var serviceProvider = services.BuildServiceProvider();
        var bus = serviceProvider.GetRequiredService<IBusControl>();
        await bus.StartAsync();

        Console.WriteLine("Waiting for messages...");
        Console.ReadLine();
    }
}

