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


                //Fel meddelanden//

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



                //Fel meddelanden//

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
                int amountOfCash;
                int typeOfCash = 500;
                amountOfCash = payBack / typeOfCash;
                
                //500 lappar//
                if(amountOfCash > 0)
                {
                    Console.WriteLine("500-lappar          :   {0:0}", amountOfCash);
                    payBack %= typeOfCash;
                }
                
                //100-lappar//
                typeOfCash = 100;
                amountOfCash = payBack / typeOfCash;
                
                if (amountOfCash > 0)
                {
                    Console.WriteLine("100-lappar          :   {0:0}", amountOfCash);
                    payBack %= typeOfCash;
                }

                //20-lappar//
                typeOfCash = 20;
                amountOfCash = payBack / typeOfCash;

                if (amountOfCash > 0)
                {
                    Console.WriteLine("20-lappar           :   {0:0}", amountOfCash);
                    payBack %= typeOfCash;
                }

                //5-kronor//
                typeOfCash = 5;
                amountOfCash = payBack / typeOfCash;

                if (amountOfCash > 0)
                {
                    Console.WriteLine("5-kronor            :   {0:0}", amountOfCash);
                    payBack %= typeOfCash;
                }

                //1-kronor//
                typeOfCash = 1;
                amountOfCash = payBack / typeOfCash;

                if (amountOfCash > 0)
                {
                    Console.WriteLine("1-kronor            :   {0:0}", amountOfCash);
                    payBack %= typeOfCash;
                }

            }
        }
    }
