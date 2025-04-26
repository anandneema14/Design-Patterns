using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple;

public class DocumentProcessor
{
    public void ProcessDocument(IDocument document)
    {
        Console.WriteLine("Reading" + document.ReadDocument());
        if (document is IPrintableDocument printableDocument)
        {
            printableDocument.Print();
        }
        else
        {
            Console.WriteLine("Document is not printable");
        }
    }
}