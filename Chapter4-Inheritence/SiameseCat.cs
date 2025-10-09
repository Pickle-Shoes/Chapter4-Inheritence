using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public class SiameseCat : Cat
    {
        //fields
        public override string Breed => "Siamese";

        //constructors
        public SiameseCat(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
        {
            Console.WriteLine("SiameseCat created.");
        }

    }

}
