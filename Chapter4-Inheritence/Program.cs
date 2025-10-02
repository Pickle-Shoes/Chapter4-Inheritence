
namespace Chapter4_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Mammal(3);
            a.PrintLegsAndEyes(); // 0, 0
            a.Age = 5;
            a.PrintAge();
        }
    }
}
