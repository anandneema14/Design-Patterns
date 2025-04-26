using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple;

public class TextDocument : IDocument, IPrintableDocument
{
    public string ReadDocument()
    { 
        return "Reading document";
    }

    public void Print()
    {
        Console.WriteLine("Printing document");
    }
}