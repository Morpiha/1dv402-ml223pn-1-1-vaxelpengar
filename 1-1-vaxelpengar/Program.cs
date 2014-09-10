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
            //Anvgivna variable//
            double totalSum = 0;
            int givenSum = 0;
            uint subtotal = 0;

            //Anvigen total summa och belopp//

            Console.Write("Ange totalsumma: ");
            totalSum = double.Parse(Console.ReadLine());
            Console.Write("Erhållet belopp: ");
            givenSum = int.Parse(Console.ReadLine());

            //Kvitto//
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Totalt              :   {0:c}", totalSum);
            subtotal = (uint)Math.Round(totalSum);
            double roundingOffAmount = totalSum - subtotal;
            Console.WriteLine("Öresavrundning      :   {0:c}", roundingOffAmount);
            Console.WriteLine("Att betala          :   {0:c0}", subtotal);
            Console.WriteLine("Kontant             :   {0:c0}", givenSum);

            double sumBack = givenSum - subtotal; 
            Console.WriteLine("Tillbaka            :   {0:c0}", sumBack);

            Console.WriteLine("---------------------------------");

           
            //Pengar att få tillbaks
            int payBack= (int)Math.Round(sumBack);
            int count = payBack/500;
            int hundred = count/100;

            Console.WriteLine("500-lappar          :   {0:0}", count);
            Console.WriteLine("100-lappar          :   {0:0}", hundred);

        }
    }
}
