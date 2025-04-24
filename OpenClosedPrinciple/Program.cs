// See https://aka.ms/new-console-template for more information

using OpenClosedPrinciple;
using OpenClosedPrinciple.Strategies;

var regularCustomer = new Customer("John", new RegularDiscount());
var silverCustomer = new Customer("Alice", new SilverDiscount());
var goldCustomer = new Customer("Bob", new GoldDiscount());

decimal total = 1000;

Console.WriteLine($"Regular: {regularCustomer.GetDiscountedAmount(total)}");
Console.WriteLine($"Silver: {silverCustomer.GetDiscountedAmount(total)}");
Console.WriteLine($"Gold: {goldCustomer.GetDiscountedAmount(total)}");