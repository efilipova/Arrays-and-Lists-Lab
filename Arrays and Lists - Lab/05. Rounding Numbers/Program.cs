using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split(' ').
                Select(decimal.Parse).ToArray();

            foreach (var item in nums)
            {
                decimal roundItem = Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine(item + " => " + roundItem);
            }
        }
    }
}
