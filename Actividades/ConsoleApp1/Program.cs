// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

Persona p = new Persona("Juan", "Gomez");
Animal a = new Animal("Perro", "Can");
Console.WriteLine($"persona: {p.Name} {p.FirstName}");
Console.WriteLine($"animal: {a.Name} {a.FirstName}");
