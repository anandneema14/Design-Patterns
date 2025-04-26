// See https://aka.ms/new-console-template for more information

using Decorator;

Console.WriteLine("Hello, World!");

ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} : ₹{coffee.GetCost()}");

coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ₹{coffee.GetCost()}");

coffee = new WhippedCreamDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} : ₹{coffee.GetCost()}");