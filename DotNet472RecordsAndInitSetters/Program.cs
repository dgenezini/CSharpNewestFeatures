#nullable enable

using System;

var person = new Person() { FirstName= "Sherlock", LastName = "Holmes" };

var address = new Address("Baker Street 221b", "London");

Console.WriteLine($"Person: {person.FirstName} {person.LastName}");
Console.WriteLine($"Address: {address}");

Console.ReadKey();

record Address (string StreetName, string City);

class Person
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
}