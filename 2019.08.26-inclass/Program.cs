using System;
using _2019._08._26_inclass.Examples;

namespace _2019._08._26_inclass
{
    class Program
    {
        string FullName { get; set; } //property

        static void Main(string[] args)
        {
            Console.WriteLine("enter full name");
            //Console = class, .WriteLine() is method on the class
            var input = Console.ReadLine();

            var name = new Name
            {
                FullName = input,
                FirstName = "steve"
            };

            var anotherName = new Name
            {
                FullName = "bob",
                FirstName = "bobby"
            };

            var steve = new Person(input
                ,17,200);

            // var name = new Name {FullName = input};

            Console.WriteLine(input);

            Console.ReadLine();
        }
    }
}
