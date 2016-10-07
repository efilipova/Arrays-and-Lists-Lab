using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] arr = numbers.Split(' ');
            //Console.WriteLine(Integers(arr));   
            int[] integer = Integers(arr);
            int count = 0;
            for (int a = 0; a < arr.Length-1; a++)
            {

                for (int b = a+1; b < arr.Length; b++)
                {
                    int sum = integer[a] + integer[b];
                    if (integer.Contains(sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", integer[a], integer[b], (integer[a] + integer[b]));
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }  
        }
        static int[] Integers(string[] arr)
        {
            int[] integers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                integers[i] = int.Parse(arr[i]);
            }
            return integers;
        }
    }
}
