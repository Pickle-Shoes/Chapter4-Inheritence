using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public abstract class Mammal : Animals
    {
        //Fields
        //overriding specifically for a mammal that is created to have 1 pair of eyes
        protected override int _pairsOfEyes { get { return 1; } } 

        //Property
        public bool IsPregnant { get; set; }

        //Constructors
        public Mammal(int age) : base(age)
        {
            this.IsPregnant = false;
            Console.WriteLine("Mammal Created");
        }

        public Mammal(int age, bool isPregnant) : base(age)
        {
            IsPregnant = isPregnant;
            Console.WriteLine("Mammal Created");

        }

           


    }


}
