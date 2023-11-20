

using DemoLibrary.Models;

PersonModel person = new PersonModel();

person.LastName = "Spencer";
person.FirstName = "Justin";

Console.WriteLine($"Hello {person.FirstName} {person.LastName}");

Console.ReadLine();