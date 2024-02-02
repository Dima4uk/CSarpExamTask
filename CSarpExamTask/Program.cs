// See https://aka.ms/new-console-template for more information
using CSarpExamTask.Entities;

Console.WriteLine("Hello, World!");

Human human1 = new Human() { Name = "Test", Surname = "Tester" };
Human human2 = new Human() { Name = "Test", Surname = "Tester" };
Human human3 = new Human() { Name = "Test", Surname = "Tester" };

Console.WriteLine(human1.Id);
Console.WriteLine(human2.Id);
Console.WriteLine(human3.Id);