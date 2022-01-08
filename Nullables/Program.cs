using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            //// typ referencyjny
            //string someText = null;
            //// typy wartościowe
            //DateTime someDateTime;
            //int a = 5;

            // Wykorzystanie specjalnej wartości jako oznaczenia "nieznanego".
            //Person person = new Person
            //{
            //    FirstName = "Jan",
            //    LastName = "Kowalski",
            //    Age = -1 // <- to specjalny sposób reprezentowania "nieznanego", tak się nie da -> null
            //};

            //person.Age = 5;

            //Person person = new Person
            //{
            //    FirstName = "Jan",
            //    LastName = "Kowalski"
            //};

            //person.Age = null;
            //person.Age = 5;

            //PrintPersonGreeting(person);
            //Person anotherPerson = null;
            ////PrintPersonGreeting(null);
            //PrintPersonGreeting(anotherPerson);

            //Person person = new Person(null, null);

            //int? a = null;
            //a = 5;
            //int b = 10;
            //a = b;
            //b = (int)a;

            //// ?? null coalescing operator
            //a = null;

            //b = a ?? 5;

            ////if (a.HasValue)
            //if (a is not null)
            //{
            //    Console.WriteLine(a.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Wartość nieznana!");
            //}
            //string someText = null;
            //Console.WriteLine(someText ?? "To co podałeś jest null-em");
            //Person person = new Person();
            //PrintPersonGreeting(person);
            //PrintPersonGreeting(null);
            // null-forgiving operator

            string text = null!;

            // null-coalescing assignment
            List<int> numbers = null!;
            int? a = null!;

            //numbers.Add(5);
            (numbers ??= new List<int>()).Add(5);

            Person person = new Person(null!, null!)
            {
                Age = 5
            };

        }

        private static void PrintPersonGreeting(Person person)
        {
            // wykorzystanie specjalnej wartości jako znacznik
            //string ageString = "";
            //if (person.Age == -1)
            //{
            //    ageString = "Nie wiem ile masz lat.";
            //}
            //else
            //{
            //    ageString = $"Masz {person.Age} lat.";
            //}
            //Console.WriteLine($"Witaj {person.FirstName} {person.LastName}. {ageString}");
            string ageString;
            if (person?.Age == null)
            {
                ageString = "Nie wiem ile masz lat.";
            }
            else
            {
                ageString = $"Masz {person.Age} lat.";
            }
            // ?? null coalescing operator
            // ?. ?[] null-conditional operator
            Console.WriteLine($"Witaj {person?.FirstName?.ToUpper() ?? "NIEZNANE"} {person?.LastName?.ToUpper() ?? "NIEZNANE"}. {ageString}");
        }
    }
}
