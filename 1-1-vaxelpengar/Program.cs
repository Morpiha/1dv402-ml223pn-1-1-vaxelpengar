using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            int givenSum = 0;

            Console.Write("Ange totalsumma: ");
            totalSum = double.Parse(Console.ReadLine());

            Console.Write("Erhållet belop: ");
            givenSum = int.Parse(Console.ReadLine());

            Console.WriteLine("\nKVITTO");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Totalt       :     {0:c}", totalSum);
            totalSum = (uint)Math.Round(totalSum);
            Console.WriteLine("Öresavrundning     :      ");

            Console.WriteLine("----------------------------");
        }
    }
}
