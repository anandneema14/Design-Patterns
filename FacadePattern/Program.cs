// See https://aka.ms/new-console-template for more information

using FacadePattern;
using FacadePattern.Interfaces;

Console.WriteLine("Hello, World!");

IInvoice invoice = new Invoice();
IInventory inventory = new Inventory();
ICalculations calculations = new Calculations();
IPayment payment = new Payment();
IValidate validate = new Validate();

OrderFacade facade = new OrderFacade(payment, validate, inventory, invoice, calculations);
facade.PlaceOrder();