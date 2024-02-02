using CSarpExamTask.Entities;

Console.WriteLine("Hello, World!");

Human human1 = new Human() { Name = "Test", Surname = "Tester" };
Human human2 = new Human() { Name = "Test", Surname = "Tester" };
Human human3 = new Human() { Name = "Test", Surname = "Tester" };

Console.WriteLine(human1.Id);
Console.WriteLine(human2.Id);
Console.WriteLine(human3.Id);

Car car1 = new Car() { HumanId = human3.Id, Model = Models.Skoda, EngineSize = 2.5 };
Car car2 = new Car() { HumanId = human2.Id, Model = Models.Mazda, EngineSize = 2.3 };
Car car3 = new Car() { HumanId = human1.Id, Model = Models.Tesla, EngineSize = 335 };

Console.WriteLine(car1.Id);
Console.WriteLine(car2.Id);
Console.WriteLine(car3.Id);