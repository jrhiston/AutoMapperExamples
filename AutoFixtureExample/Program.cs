using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;

namespace AutoFixtureExample
{
    public static class Program
    {
        public static void Main()
        {
            var fixture = new Fixture();

            // Creating strings
            var str = fixture.Create<string>();

            Console.WriteLine(str);

            // Creating numbers
            var num = fixture.Create<decimal>();

            Console.WriteLine(num);

            // Creating complex types
            var person = fixture.Create<Person>();

            Console.WriteLine(person);

            // Manipulating lists
            var list = new List<Person>();
            fixture.AddManyTo(list);

            Console.WriteLine(string.Join($"PERSON: {Environment.NewLine}", list));
        }
    }
}
