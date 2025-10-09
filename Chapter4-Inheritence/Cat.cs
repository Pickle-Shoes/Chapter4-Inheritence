using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public class Cat : DomesticMammal
    {
        //fields/attributes
        protected override int _numberOfLegs { get { return 4; } }
        protected int _lives = 9;

        public virtual string Breed { get { return "just a cat"; } }
        //properties

        //constructor

        public Cat(string name, int age, string favoriteToy, bool isPregnant) : base (name, age, favoriteToy, isPregnant)
        {
            Console.WriteLine("Cat created.");
        }

        //methods

        public void PrintBreed()
        {
            Console.WriteLine($"Breed: {this.Breed}");
        }

        public override void Talk()
        {
            Console.WriteLine($"{Name}: meows");
        }

        public void PrintLives()
        {
            Console.WriteLine($"Number of lives: {this._lives}");
        }

        public void DeductLife() 
        {
            this._lives--;
        }


    }
}
