using Contracts;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;

namespace Producer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddMassTransit(x =>
            {
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

            Console.WriteLine("Press any key to send a message...");
            while (true)
            {
                Console.ReadKey(true);
                await bus.Publish(new ItemCreatedMessage(Name: "Pencil", Price: 3.4));
                Console.WriteLine("Message sent: ItemCreatedMessage(Name: 'Pencil', Price: 3.4)");
            }
        }
    }
}
