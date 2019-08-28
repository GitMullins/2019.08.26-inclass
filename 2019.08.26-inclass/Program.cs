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

            var originalPerson = new Person(input,17,200);

            var anotherOriginalPerson = new Person("Someone else", 17, 200);

            var stuffToEat = new Food { Name = "Pizza", Calories = 1100 };

            originalPerson.Eat(stuffToEat);
            originalPerson.Eat("taco", 300);

            originalPerson.Walk();

            // var name = new Name {FullName = input};

            Console.WriteLine(name.FullName);

            var myCar = new Car(5);

            myCar.Start(originalPerson);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);
            myCar.Accelerate(40);

            Console.ReadLine();

        }
    }
}
