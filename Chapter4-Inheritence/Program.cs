
namespace Chapter4_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Dog("Rufus", 3, "Ball", true);
            a.PrintLegsAndEyes(); // 0, 0
            a.Age = 5;
            a.PrintAge();
            a.Talk();
            Console.WriteLine(a.IsPregnant);
            a.PrintBreed();
            a.PrintBreedFamily();

        }
    }
}
