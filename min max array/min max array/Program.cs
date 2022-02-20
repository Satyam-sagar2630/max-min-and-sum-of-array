using System;
using System.Linq;
namespace app
{
    class Program
    {
        static void Main(string[]arg)
        {
            int[] num = { 1, 2, 3, 4, 5,};
            Console.Write("Max number is : ");
            Console.WriteLine( num.Max());
            Console.Write("Min number is : ");
            Console.WriteLine(num.Min());
            Console.Write("Sum of Array is : ");
            Console.WriteLine(num.Sum());
        }
    }
}