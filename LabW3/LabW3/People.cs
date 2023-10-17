using System;
namespace LabW3
{

    internal class People
    {
        static void main(String[] args)
        {
            Person person = new Person();
            person.greet();
        }
    }

    }
    class Person
    {
        public int Age { get; set; }

        public void greet()
        {

        }
    }

    class Student: Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }

        public void showAge()
        {
            Console.WriteLine("My age is: " + Age);
        }
    }

    class Teacher
    {
        public void explain()
        {
            Console.WriteLine("Explain");
        }
    }



