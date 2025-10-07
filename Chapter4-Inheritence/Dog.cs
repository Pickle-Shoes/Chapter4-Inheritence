using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public class Dog : DomesticMammal
    {
        //fields/attributes
        protected override int _numberOfLegs { get { return 4; } }
        public virtual string Breed { get { return "just a dog."; } }
        public virtual string BreedFamily { get { return "dog"; } }


        //properties

        //constructor
        public Dog(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
        {
            Console.WriteLine("Dog created");
        }


        public Dog(string name, int age, string favoriteToy, bool isPregnant) : base (name, age, favoriteToy, isPregnant)
        {
            Console.WriteLine("Dog created");
        }




        //methods
        public void PrintBreed()
        {
            Console.WriteLine($"Breed: {Breed}");
        }
        public void PrintBreedFamily()
        {
            Console.WriteLine($"BreedFamily: {BreedFamily}");
        }

        public override void Talk()
        {
            Console.WriteLine($"{Name}: barks");
        }

    }
}
