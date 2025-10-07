using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public abstract class DomesticMammal :Mammal
    {
        //fields

        //properties
        public string Name { get; private set; }
        public string FavoriteToy { get; set; }

        //constructor
        public DomesticMammal(string name, int age, string favoriteToy) : base(age)
        {
            Name = name;
            FavoriteToy = favoriteToy;
            Console.WriteLine("Domestic mammal created");
        }

        public DomesticMammal(string name, int age, string favoriteToy, bool isPregnant) : base(age, isPregnant)
        {
            Name = name;
            FavoriteToy = favoriteToy;
            Console.WriteLine("Domestic mammal created");
        }

        //methods

        public virtual void Talk()
        {
            Console.WriteLine($"{Name}: talks");
        }


    }
}
