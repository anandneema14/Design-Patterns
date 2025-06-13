using Contracts;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer;

internal interface IConsumer
{
    Task Consume(ConsumeContext<ItemCreatedMessage> context);
}
