using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
}

public class Employee : Person { }

class Program
{
    public static void PrintFullName(IEnumerable<Person> persons)
    {
        foreach (Person person in persons)
        {
            Console.WriteLine($"Name: {person.Name}");
        }
    }

    public static void Main()
    {
        IEnumerable<Employee> employees = new List<Employee>();

        PrintFullName(employees);
    }
}