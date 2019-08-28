using System;
using System.Collections.Generic;
using System.Text;

namespace _2019._08._26_inclass.Examples
{
    class Person
    {
        public string Name { get; set; } = "steve";
        public int Age { get; } // PROPERTY

        readonly int _speed1; // 'readonly' can set speed in the constructor, then never again
        int _speed2;
        const int MaxWalkingSpeed = 10;

        List<string> _foodInMyBelly = new List<string>();
        int _caloricIntake;

        public Person(string name, int age, int speed)
        {
            Name = name;
            Age = age;
            _speed1 = speed;
        }

        // 3 parts to a method signature:
        // access modifier = public or private
        // return type (i.e. void)
        // method name

        internal void Walk()
        {
            if (_speed1 <= MaxWalkingSpeed)
            {
                Console.WriteLine($"{Name} is walking at {_speed1} feet per second.");
                _speed2 += 7;
            }
            else
            {
                Console.WriteLine($"Slow Down");

            }
        }

        public void Eat(string name, int calories)
        {
            if (_caloricIntake > 2500)
            {
                Console.WriteLine("You may not eat");
                return;
            }

            _foodInMyBelly.Add(name); //overloading
            _caloricIntake += calories; 
        }

        public void Eat(Food stuffToEat)
        {
            Eat(stuffToEat.Name, stuffToEat.Calories);
        }
    }
}
