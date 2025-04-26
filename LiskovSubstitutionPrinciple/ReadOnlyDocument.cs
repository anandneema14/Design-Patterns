using LiskovSubstitutionPrinciple.Interfaces;

namespace LiskovSubstitutionPrinciple;

public class ReadOnlyDocument : IDocument
{
    public string ReadDocument()
    {
        return "Read Only document";
    }
}