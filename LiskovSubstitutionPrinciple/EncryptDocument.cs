using System.Security.Cryptography;
using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple;

public class EncryptDocument : IDocument, IPrintableDocument
{
    public string ReadDocument()
    {
        string content = Decrypt();
        return content;
    }

    public void Print()
    {
        Console.WriteLine("Printing document");
    }
    
    private string Decrypt() => "Decrypted Content";
}