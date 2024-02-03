using CSarpExamTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CSarpExamTask.DB;

public class DbManager //<T> where T : class
{
    private ApplicationContext _context;

    public DbManager(ApplicationContext context)
    {
        _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        //перевірка чи вже додано

            _context.Set<T>().Add(entity);
            _context.SaveChanges();


    }
    public T? Read<T>(int Id) where T : class
    {
        
        return _context.Find<T>(Id);
    }

    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
    public void Remove<T>(int Id) where T : class
    {
        var entity = _context.Find<T>(Id);
        if (entity != null) 
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

    }
    
    //Повернути Human за id House
    public IEnumerable<Human> GetHummanByHouseId(int id)
    {
        return _context.Humans.Where(h => h.HouseId == id);
    }
    //Повернути Human за адресою
    public IEnumerable<Human> GetHumansByAddress(string street, int number)
    {
        var house = _context.Houses.FirstOrDefault(h => h.Street == street && h.Number == number);
        if (house != null)
            throw new ArgumentException("Address not found");

        return GetHummanByHouseId(house.Id);
    }
    //Повернути Human за моделю Car
    public IEnumerable<Human> GetHumansByCar(Models model)
    {
        var car = _context.Cars.Where(c => c.Model == model);
        if (car != null)
            throw new ArgumentException("Model car not found");

        Func<Human, bool> f = () => { };
        return _context.Humans.Where(f);
    }
    //Повернути Hous за Name Human
    //Повернути Car за Name Human
    //Повернути Hous та Car за id Human
    public void PrintAllHummanHouse()
    {
        var q = from human in _context.Humans
                join house in _context.Houses on human.HouseId equals house.Id
                select new
                {
                    Name = human.Name,
                    Surname = human.Surname,
                    Street = house.Street,
                    Num = house.Number,
                };

        foreach (var e in q)
        {
            Console.WriteLine($"Name: {e.Name} {e.Surname} Street: {e.Street} {e.Num}");
        }
    }
    public void PrintAllHummanCar()
    {
        var q = from human in _context.Humans
                join car in _context.Cars on human.Id equals car.HumanId
                select new {
                    Name = human.Name,
                    Surname = human.Surname,
                    Model = car.Model,
                    Engine = car.EngineSize
                };

        foreach (var e in q)
        {
            Console.WriteLine($"Name: {e.Name} {e.Surname} Car: {e.Model} {e.Engine}");
        }
    }

}
