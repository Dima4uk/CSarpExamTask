﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarpExamTask.Entities;

public class Human
{
    private static int _idCounter = 1;

    public int Id { get; }
    public int HouseId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public Human()
    {
        Id = _idCounter++;
    }

}