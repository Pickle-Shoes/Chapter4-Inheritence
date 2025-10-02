
namespace Chapter4_Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals a = new Animals(3);
            a.PrintAge(); //3
            a.PrintLegsAndEyes(); //0 0
            a.PairsOfEyes = 1;
            a.NumberOfLegs = 4;
            a.PrintLegsAndEyes(); // 4, 2
            a.Age = 5;
            a.PrintAge();
        }
    }
}
