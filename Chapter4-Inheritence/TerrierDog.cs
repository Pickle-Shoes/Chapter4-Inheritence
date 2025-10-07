using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Inheritence
{
    public class TerrierDog : Dog
    {
        //fields
        public override string Breed { get { return "Terrier Dog"; } }
        public override string BreedFamily => "Terrier"; //shorthand of the one above

        //Construstors
        public TerrierDog(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
        {
            Console.WriteLine("Terrier Dog created");
        }


        public TerrierDog(string name, int age, string favoriteToy, bool isPregnant) : base(name, age, favoriteToy, isPregnant)
        {
            Console.WriteLine("Terrier Dog created");
        }


     /*   public override void Talk()
        {
            Console.WriteLine("Terrier Dog test");
        }
     */
    }
}
