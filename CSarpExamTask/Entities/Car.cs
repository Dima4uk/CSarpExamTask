using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.Entities;
public enum Models
{
    BMW,
    Mercedes,
    Mitsubishi,
    Mazda,
    Audi,
    Volkswagen,
    Tesla,
    Skoda,
    Dodge,
    Jeep
}
public class Car
{
    private static int _idCounter = 1;

    public int Id { get; }
    public int HumanId { get; set; }
    public Models Model { get; set; }
    public double EngineSize {  get; set; }


   public Car()
    {
        Id = _idCounter++;
    }
}
