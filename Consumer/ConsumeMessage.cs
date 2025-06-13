using Contracts;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    public record ItemCreatedMessageConsumer : IConsumer<ItemCreatedMessage>
    {
        public Task Consume(ConsumeContext<ItemCreatedMessage> context)
        {
            Console.WriteLine($"Received message: ItemCreatedMessage(Name: '{context.Message.Name}', Price: {context.Message.Price})");
            return Task.CompletedTask;
        }
    }
}
