using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

Console.Clear();
var collection=new ServiceCollection();
collection.AddScoped<Scoped>();
collection.AddTransient<Transient>();

var provider = collection.BuildServiceProvider();
Parallel.For(1, 10, i =>
{
    var scopedObject = provider.GetService<Scoped>();
    var transientObject = provider.GetService<Transient>();

    Console.WriteLine($"ScopeId:" + scopedObject.GetHashCode());
    Console.WriteLine($"TransientId:" + transientObject.GetHashCode());
});

Console.Write("Press Key");
Console.ReadKey();

public class Scoped
{

}

public class Transient
{

}
