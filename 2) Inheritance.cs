using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAP_2._2;

class Person
{
    public required string Name { get; init; }

    public void Walk()
    {
        Console.WriteLine($"{Name} is walking");
    }
}

// уточнение класса Person
class Employee : Person
{
    public required string Profession { get; init; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working as {Profession}");
    }
}