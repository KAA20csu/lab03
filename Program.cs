using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Summing(3);
        }

        static void Summing(int numberToPlus)
        {
            var rnd = new Random();
            var listX = new List<float>();
            var rndCount = rnd.Next(5, 20);
            for (int i = 0; i < rndCount; i++)
                listX.Add(rnd.Next(10, 50)-1);
            Console.WriteLine("|----------|--------------------|");
            Console.WriteLine("|    x     |          y         |");
            Console.WriteLine("|----------|--------------------|");
            for (int i = 0; i < listX.Count(); i++)
            {
                var x = listX[i]+numberToPlus;
                var y = Math.Log(x, 10);
                Console.WriteLine("|    " + x + "    |" + " " + y + " |");
                Thread.Sleep(400);
            }
            Console.WriteLine("|----------|--------------------|");
        }
    }
}
