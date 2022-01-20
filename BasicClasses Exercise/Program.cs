using System;

namespace BasicClasses_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car muscle = new Car();
            muscle.Make = "Ford";
            muscle.Model = "Mustang";
            muscle.Year = 2013;
            Console.WriteLine($"{muscle.Year} {muscle.Make} {muscle.Model}");

        }
    }
}
