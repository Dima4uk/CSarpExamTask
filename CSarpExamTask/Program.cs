﻿using CSarpExamTask.DB;
using CSarpExamTask.Entities;

Console.WriteLine("Hello, World!");

House house1 = new House() { Street = "Qwer", Number = 12 };
House house2 = new House() { Street = "Asdf", Number = 11 };
House house3 = new House() { Street = "Rtyu", Number = 7 };


Human human1 = new Human() { Name = "Test", Surname = "Tester", HouseId = house3.Id };
Human human2 = new Human() { Name = "Test", Surname = "Tester", HouseId = house1.Id };
Human human3 = new Human() { Name = "Test", Surname = "Tester", HouseId = house2.Id };

Console.WriteLine(human1.Id+"  "+human1.HouseId);
Console.WriteLine(human2.Id + "  " + human2.HouseId);
Console.WriteLine(human3.Id + "  " + human3.HouseId);

Car car1 = new Car() { HumanId = human3.Id, Model = Models.Skoda, EngineSize = 2.5 };
Car car2 = new Car() { HumanId = human2.Id, Model = Models.Mazda, EngineSize = 2.3 };
Car car3 = new Car() { HumanId = human1.Id, Model = Models.Tesla, EngineSize = 335 };

Console.WriteLine(car1.Id + "  " + car1.HumanId);
Console.WriteLine(car2.Id + "  " + car2.HumanId);
Console.WriteLine(car3.Id + "  " + car3.HumanId);

using (ApplicationContext db = new ApplicationContext())
{
    // Додавання
    db.Humans.Add(human1);
    db.Humans.Add(human2);
    db.Humans.Add(human3);
    db.Cars.Add(car1);
    db.Cars.Add(car2);
    db.Cars.Add(car3);
    db.Houses.Add(house1);
    db.Houses.Add(house2);
    db.Houses.Add(house3);
    db.SaveChanges();
}