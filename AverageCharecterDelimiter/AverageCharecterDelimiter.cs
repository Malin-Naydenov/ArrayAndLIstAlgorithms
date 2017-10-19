using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharecterDelimiter
{
    class AverageCharecterDelimiter
    {
        static void Main(string[] args)
        {
            string[] originalArray = Console.ReadLine().Split(' ').ToArray();

            List<char> fromArray = new List<char>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                var chars = originalArray[i].ToCharArray();
                for (int k = 0; k < chars.Length; k++)
                {
                    fromArray.Add(chars[k]);
                }
            }

            double sum = 0;
            for (int i = 0; i < fromArray.Count; i++)
            {
                sum += fromArray[i];
            }
            int average = (int)sum / fromArray.Count;

            char symbol = (char)average;

            if (average >= 97 && average <= 122)
            {
                char index = char.ToUpper(symbol);
                Console.WriteLine(String.Join($"{index}", originalArray));
            }
            else
            {
                Console.WriteLine(String.Join($"{symbol}", originalArray));

            }
        }
    }
}
