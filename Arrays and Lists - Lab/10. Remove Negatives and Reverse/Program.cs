using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> integers = new List<int>();
            integers.AddRange(arr);
            List<int> result = new List<int>();
            result.AddRange(integers.FindAll(item => item > 0));
            result.Reverse();
            if (result.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
            
        }
    }
}
