using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public abstract class Animals
    {
        //fields/attributes
        protected virtual int _numberOfLegs { get { return 0; } }
        protected virtual int _pairsOfEyes { get { return 0; } }

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
            Console.WriteLine($"Legs: {this._numberOfLegs} Eyes: {this._pairsOfEyes * 2}");

        }
        
        public void PrintAge()
        {
            Console.WriteLine("Age: " + Age);
        }

    }
}
