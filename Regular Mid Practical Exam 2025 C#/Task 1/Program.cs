using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int opposingFactoryBiscuits = int.Parse(Console.ReadLine());

            int days = 0;

            double biscuitsProducedADay;
            double totalBiscuitsTillNow = 0;

            double differencePercentage;
            double difference;

            for (int i = 0; i < 30; i++)
            {
                days++;

                biscuitsProducedADay = biscuitsPerWorker * workersCount;

                if (days % 3 == 0) 
                {
                    biscuitsProducedADay *= 0.75;
                    biscuitsProducedADay = Math.Floor(biscuitsProducedADay);
                }

                totalBiscuitsTillNow += biscuitsProducedADay;
            }

            Console.WriteLine($"You have produced {totalBiscuitsTillNow} biscuits for the past month.");

            if (totalBiscuitsTillNow < opposingFactoryBiscuits)
            {
                difference = opposingFactoryBiscuits - totalBiscuitsTillNow;
                differencePercentage = difference / opposingFactoryBiscuits * 100;
                Console.WriteLine($"You produce {differencePercentage:F2} percent less biscuits.");
            }
            else if (totalBiscuitsTillNow > opposingFactoryBiscuits) 
            {
                difference = totalBiscuitsTillNow - opposingFactoryBiscuits;
                differencePercentage = difference / opposingFactoryBiscuits * 100;
                Console.WriteLine($"You produce {differencePercentage:F2} percent more biscuits.");
            }
        }
    }
}
