using System;
using System.Collections.Generic;
using System.Text;

namespace _2019._08._26_inclass.Examples
{
    class Person
    {
        public string Name { get; set; } = "steve";
        public int Age { get; set; }

        private int _speed;

        public Person(string name, int age, int speed)
        {
            Name = name;
            Age = age;
            _speed = speed;
        }

        // 3 parts to a method signature:
        // access modifier = public or private
        // return type (i.e. void)
        // method name

        private void Walk()
        {

        }

    }
}
