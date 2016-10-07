using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split('|').ToList();
            inputList.Reverse();
            List<string> result = new List<string>();

            foreach (var item in inputList)
            {
                List<string> temp = item.Split(' ').ToList();
                foreach (var items in temp)
                {
                    if (items != "")
                    {
                        result.Add(items);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
            //do
            //{
            //    result.AddRange(inputList);
            //} while (inputList.Contains("|"));
        }
    }
}
