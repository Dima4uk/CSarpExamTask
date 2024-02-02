using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.Entities;

public class House
{
    private static int _idCounter = 1;

    public int Id { get; }
    public string Street {  get; set; }
    public uint Number { get; set; }

    public House()
    {
        Id = _idCounter++;
    }
}
