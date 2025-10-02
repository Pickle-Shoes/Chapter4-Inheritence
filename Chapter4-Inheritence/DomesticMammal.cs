using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public class DomesticMammal :Mammal
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

        //methods
    }
}
