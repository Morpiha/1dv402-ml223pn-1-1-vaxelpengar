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

            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma: ");
                    totalSum = double.Parse(Console.ReadLine());

                    if (totalSum < 1)
                    {
                        throw new OverflowException();
                    }
                    break;
                }
                catch(OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInmatning fel!");
                    Console.ResetColor();
                }
                catch(FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEtt oväntat fel har inträffat! Testa igen.");
                    Console.ResetColor();
                }
            }


            //Erhållet belopp

            while (true)
            {
                try
                {
                    Console.Write("\nErhållet belopp: ");
                    givenSum = int.Parse(Console.ReadLine());
                
                
                    if (givenSum < totalSum)
                    {
                        throw new OverflowException();
                    }
                    break;
                }
          
                catch(OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt!");
                    Console.ResetColor();
                }
                catch(FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEtt onväntat fel har inträffat");
                    Console.ResetColor();
                }
            }



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
                int payBack = (int)Math.Round(sumBack);
                int count = payBack / 500;
                int hundred = count / 100;

                Console.WriteLine("500-lappar          :   {0:0}", count);
                Console.WriteLine("100-lappar          :   {0:0}", hundred);

            }
        }
    }
