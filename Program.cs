// See https://aka.ms/new-console-template for more information
using ContactDetails;

Console.WriteLine("Hello, World!");

Adddetails customerdetails1 = new Adddetails();
customerdetails1.Addingdetails();
Console.WriteLine("check your details");
customerdetails1.display();

customerdetails1.edit();
customerdetails1.display();
customerdetails1.detele();
