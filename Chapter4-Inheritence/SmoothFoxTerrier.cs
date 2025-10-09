using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public class SmoothFoxTerrier : TerrierDog
    {
        //fields
        public override string Breed => "Smooth Fox Terrier";

        //Constructor
        public SmoothFoxTerrier(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
        {
            Console.WriteLine("Smooth Fox Terrier created");
        }


        public SmoothFoxTerrier(string name, int age, string favoriteToy, bool isPregnant) : base(name, age, favoriteToy, isPregnant)
        {
            Console.WriteLine("Smooth Fox Terrier created");
        }

    }
}
