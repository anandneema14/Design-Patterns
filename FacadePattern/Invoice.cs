using FacadePattern.Interfaces;

namespace FacadePattern;

public class Invoice : IInvoice
{
    public void GenerateInvoice()
    {
        Console.WriteLine("Generating invoice...");
    }
}