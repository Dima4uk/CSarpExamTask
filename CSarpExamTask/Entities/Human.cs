using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.Entities;

public class Human
{
    private static int idCounter = 1;

    public int Id { get; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public Human()
    {
        Id = idCounter++;
    }

}