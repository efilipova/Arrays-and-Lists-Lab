﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(' ').ToArray();
            string[] reverseSeq = sequence.Reverse().ToArray();

            Console.WriteLine(string.Join(" ",reverseSeq));
        }
    }
}
