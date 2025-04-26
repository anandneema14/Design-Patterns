// See https://aka.ms/new-console-template for more information

using LiskovSubstitutionPrinciple;
using LiskovSubstitutionPrinciple.Interfaces;

var processor = new DocumentProcessor();
IDocument textDoc = new TextDocument();
IDocument encryptDoc = new EncryptDocument();
IDocument readOnlyDoc = new ReadOnlyDocument();

processor.ProcessDocument(textDoc);
processor.ProcessDocument(encryptDoc);
processor.ProcessDocument(readOnlyDoc);