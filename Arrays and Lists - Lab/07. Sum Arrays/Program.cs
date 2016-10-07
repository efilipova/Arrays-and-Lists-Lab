using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenght1 = arr1.Length;
            int lenght2 = arr2.Length;

            int[] arr3 = new int[Math.Max(lenght1, lenght2)];
           
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr1[i % lenght1] + arr2[i % lenght2];               
            }
            Console.WriteLine(string.Join(" ",arr3));
        }
    }
}
