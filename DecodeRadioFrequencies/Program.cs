using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> radioFrequencies = Console.ReadLine().Split('.', ' ').ToList();

            List<int> justNums = new List<int>();
            List<char> readyWords = new List<char>();

            foreach (var item in radioFrequencies)
            {
                int numItem = int.Parse(item);
                justNums.Add(numItem);
            }
            int count = 0;
            for (int i = 0; i < justNums.Count; i++)
            {
                int back = (readyWords.Count) - count;
                if(i%2==0 && justNums[i]>0)
                {
                    char letter = (char) justNums[i];
                    readyWords.Insert(count, letter);
                    count++;
                }

                else if (i%2!=0 && justNums[i]>0)
                {
                    char letter = (char)justNums[i];
                    readyWords.Insert(back, letter);
                }

            }
            readyWords.Reverse();
            Console.WriteLine(String.Join("",readyWords));
        }
    }
}
