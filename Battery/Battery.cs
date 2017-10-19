using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery
{
    class Battery
    {
        static void Main(string[] args)
        {
            List<double> mAhbattery = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> powerPerHours = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            int workingHours = int.Parse(Console.ReadLine());
            for (int i = 0; i < mAhbattery.Count; i++)
            {
                double finalyComsumation = workingHours * powerPerHours[i];
                if (finalyComsumation <= mAhbattery[i])
                {
                    double remainigPower = mAhbattery[i] - finalyComsumation;
                    double procent = (remainigPower /mAhbattery[i])*100;
                    Console.WriteLine($"Battery {i+1}: {remainigPower:f2} mAh ({procent:f2})%");
                }
                else
                {
                    double bateryLive = mAhbattery[i] / powerPerHours[i];
                    Console.WriteLine($"Battery {i+1}: dead (lasted {Math.Ceiling(bateryLive)} hours)");
                }
            }
        }
    }
}
