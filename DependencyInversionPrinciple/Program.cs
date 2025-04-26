// See https://aka.ms/new-console-template for more information

using DependencyInversionPrinciple;
using DependencyInversionPrinciple.Interfaces;

Console.WriteLine("Hello, World!");

ISender emailSender = new EmailSender();
NotificationManager manager = new NotificationManager(emailSender);
manager.SendMessage("test");