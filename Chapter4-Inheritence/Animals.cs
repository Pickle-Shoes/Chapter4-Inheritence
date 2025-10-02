using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    internal class Animals
    {
        //fields/attributes
        public int NumberOfLegs;
        public int PairsOfEyes;

        //property
        public int Age { get; set; }

        //constructor
           public Animals(int age)
        {
            this.Age = age;
            Console.WriteLine("Animal Created");
        }

        //Methods
        public void PrintLegsAndEyes()
        {
            Console.WriteLine($"Legs: {this.NumberOfLegs} Eyes: {this.PairsOfEyes * 2}");

        }
        
        public void PrintAge()
        {
            Console.WriteLine("Age: " + Age);
        }

    }
}
