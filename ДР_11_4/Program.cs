using System.Collections;
using System;

namespace ДР_11_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(42);
            myArrayList.Add("Hello");
            myArrayList.Add(new Person("John", 30));

            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}