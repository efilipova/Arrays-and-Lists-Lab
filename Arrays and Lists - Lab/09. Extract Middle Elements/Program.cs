using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = numbers.Length;

            if (n == 1)
            {
                Console.WriteLine("{ " + numbers[0] + " }");
            }
            else if (n % 2 == 0)
            {
                for (int i = (n/2)-1; i <= n/2; i++)
                {
                    Console.Write("{ " +numbers[i] + " }");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = (n/2)-1; i <= (n/2)+1; i++)
                {
                    Console.Write("{ " + numbers[i] + " }");
                }
            }
        }
    }
}
