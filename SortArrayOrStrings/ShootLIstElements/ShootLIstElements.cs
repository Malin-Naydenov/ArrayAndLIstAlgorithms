using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ShootLIstElements
    {
        static void Main(string[] args)
        {
            string inputElement = Console.ReadLine();
            int lastElement = 0;

            List<int> numbers = new List<int>();

            while (inputElement != "bang" && inputElement != "stop")
            {
                int inputDigit = 0;
                inputDigit = int.Parse(inputElement);
                numbers.Insert(0, inputDigit);
                inputElement = Console.ReadLine();
            }
            while (inputElement == "bang")
            {


                double average = GetAverage(numbers);

                foreach (var item in numbers)
                {

                    if (item < average)
                    {
                        lastElement = item;
                        Console.WriteLine($"shot {item}");
                        numbers.Remove(item);
                        break;
                    }
                    else if (numbers.Count == 1)
                    {
                        lastElement = item;
                        Console.WriteLine($"shot {item}");
                        numbers.Remove(item);
                        break;
                    }
                }

                    inputElement = Console.ReadLine();
                if (numbers.Count == 0 && inputElement == "bang")
                {
                    Console.WriteLine("nobody left to shoot! last one was {0}", lastElement);
                    return;
                }
                else
                {
                    numbers = NumbersGetingOneLess(numbers);
                }
            }
            if (inputElement == "stop")
            {
                if(numbers.Count >0)
                {
                    Console.WriteLine("survivors: {0}", String.Join(" ", numbers));
                }
                else
                {

                Console.WriteLine($"you shot them all. last one was {lastElement}");
                }
            }

        }

        static List<int> NumbersGetingOneLess(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] -= 1;

            }
            return numbers;
        }

        static double GetAverage(List<int> numbers)
        {
            double average = 0;
            foreach (var item in numbers)
            {
                average += item;
            }
            average /= numbers.Count;
            return average;
        }
    }
}

