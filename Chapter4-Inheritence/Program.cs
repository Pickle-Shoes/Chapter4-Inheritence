
namespace Chapter4_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var s = new SmoothFoxTerrier("Rufus", 3, "Ball", true);
            /*
            a.PrintLegsAndEyes(); // 0, 0
            a.Age = 5;
            a.PrintAge();
            a.Talk();
            Console.WriteLine(a.IsPregnant);
            a.PrintBreedFamily();
            a.PrintBreed();
            */

            var c = new SiameseCat("Gary", 6, "Yarn", true);
            /*
            c.PrintLives();
            c.PrintBreed();
            c.PrintLegsAndEyes();
            c.DeductLife();
            c.PrintLives();
            Console.WriteLine(c.IsPregnant);
            */

            Animals[] animals = { s, c };

            foreach (var a in animals) 
            {
                a.PrintLegsAndEyes();
                a.PrintAge();
                //a.Talk();
            }


        }
    }
}
