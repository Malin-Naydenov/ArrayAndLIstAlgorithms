using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOrStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            for (int f = 0; f < words.Length; f++)
            {

                for (int i = 0; i < words.Length - 1; i++)
                {
                    int result = words[i].CompareTo(words[i + 1]);
                   
                    if (result > 0)
                    {
                        string temp = words[i + 1];
                        words[i + 1] = words[i];
                        words[i] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", words));
        }
    }
}
