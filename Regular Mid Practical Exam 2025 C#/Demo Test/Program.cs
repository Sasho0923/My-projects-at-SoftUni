using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Test
{
    internal class Program
    {
        static void Main()
        {
            List<int> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int startingPosition = int.Parse(Console.ReadLine());

            string type = Console.ReadLine();

            int totalDamageLeft = 0;
            int totalDamageRight = 0;

            totalDamageLeft = LeftRemover(items, type, startingPosition, totalDamageLeft);
            totalDamageRight = RightRemover(items, type, startingPosition, totalDamageRight);

            if (totalDamageLeft >= totalDamageRight)
            {
                Console.WriteLine($"Left - {totalDamageLeft}");
            }
            else 
            {
                Console.WriteLine($"Right - {totalDamageRight}");
            }
        }

        static int LeftRemover(List<int> items, string type, int startingPosition, int totalDamageLeft) 
        {
            int startingPositionItem = items[startingPosition];
            //switch (type)
            //{
            //    case "cheap":

            //        for (int i = startingPosition - 1; i >= 0; i--) 
            //        {
            //            currentItem = items[i];
            //            if (currentItem < startingPositionItem) 
            //            {
            //                totalDamageLeft += currentItem;
            //            }
            //        }

            //        break;
            //    case "expensive":

            //        for (int i = 0; i < items.Count - startingPosition; i++)
            //        {
            //            currentItem = items[i];
            //            if (currentItem >= startingPositionItem)
            //            {
            //                totalDamageLeft += currentItem;
            //            }
            //        }

            //        break;
            //}

            for (int i = startingPosition - 1; i >= 0; i--) // Looping from left to entry point
            {
                if ((type == "cheap" && items[i] < startingPositionItem) ||
                    (type == "expensive" && items[i] >= startingPositionItem))
                {
                    totalDamageLeft += items[i];
                }
            }

            return totalDamageLeft;
        }

        static int RightRemover(List<int> items, string type, int startingPosition, int totalDamageRight)
        {
            int startingPositionItem = items[startingPosition];
            //switch (type)
            //{
            //    case "cheap":

            //        for (int i = startingPosition; i < items.Count; i++)
            //        {
            //            currentItem = items[i];
            //            if (currentItem < startingPositionItem)
            //            {
            //                totalDamageRight += currentItem;
            //            }
            //        }

            //        break;
            //    case "expensive":

            //        for (int i = startingPosition; i < items.Count - 1; i++)
            //        {
            //            currentItem = items[i];
            //            if (currentItem >= startingPositionItem)
            //            {
            //                totalDamageRight += currentItem;
            //            }
            //        }

            //        break;
            //}

            for (int i = startingPosition + 1; i < items.Count; i++) // Looping right from entry point
            {
                if ((type == "cheap" && items[i] < startingPositionItem) ||
                    (type == "expensive" && items[i] >= startingPositionItem))
                {
                    totalDamageRight += items[i];
                }
            }

            return totalDamageRight;
        }
    }
}
