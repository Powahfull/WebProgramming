using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabW3Solutions
{
    public class Student
        {
            public void Study()
            {
                Console.WriteLine("I'm studying");
            }

            public void ShowAge(int ageS)
            {
                Console.WriteLine("My age is " + ageS + " years old");
            }
        }

        public class Person
        {
            public int Age { get; set; }
            public void Greet()
            {
                Console.WriteLine("Hello there!");
            }

            public void SetAge(int age)
            {
                Age = age;
            }
        }

        public class Teacher
        {
        public int Age { get; set; }
        public void Explain()
            {
                Console.WriteLine("I'm explaining");
            }
        public void SetAge(int age)
        {
            Age = age;
        }
    }

}
    

