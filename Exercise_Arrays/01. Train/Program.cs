using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*

3
13
24
8
             
*/




            int wagons = int.Parse(Console.ReadLine());
            string[] passagersInTrain = new string[wagons];
            for (int i = 0; i < wagons; i++) 
            {
                passagersInTrain[i] = Console.ReadLine();
            }
            for (int i = 0;i < passagersInTrain.Length;i++)
            {
                Console.Write($"{passagersInTrain[i]} ");
            }
            int sum = 0;
            for (int i = 0; i < passagersInTrain.Length; i++)
            {
                sum += int.Parse(passagersInTrain[i]);
            }
            Console.WriteLine("" +
                "");
            Console.WriteLine(sum);


        }
    }
}
