using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+num2);
        }
    }
}
