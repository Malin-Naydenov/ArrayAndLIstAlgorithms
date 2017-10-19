using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class Program
    {
        static void Main()
        {

            List<string> packageOfWords = Console.ReadLine().Split(' ').ToList();

            List<string> sortedWords = new List<string>();
            List<int> counter = new List<int>();
            
            
            

            for (int i = 0; i < packageOfWords.Count; i++)
            {
                if(!sortedWords.Contains(packageOfWords[i]))
                {
                    sortedWords.Add(packageOfWords[i]);
                    counter.Add(1);
                }
                else
                {
                    int index = sortedWords.IndexOf(packageOfWords[i]);
                    counter[index]++;
                }
            }

            for (int firstUnsorted = 0; firstUnsorted < counter.Count - 1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i > 0)
                {
                    if (counter[i - 1] < counter[i])
                    {
                        int temp = counter[i];
                        counter[i] = counter[i - 1];
                        counter[i - 1] = temp;

                        string wordTemp = sortedWords[i];
                        sortedWords[i] = sortedWords[i - 1];
                        sortedWords[i - 1] = wordTemp;
                    }
                    i--;
                }
            }
            for (int i = 0; i < sortedWords.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:f2}%)", sortedWords[i], counter[i], ((double)counter[i]/packageOfWords.Count)*100);

            }
        }
    }
}
