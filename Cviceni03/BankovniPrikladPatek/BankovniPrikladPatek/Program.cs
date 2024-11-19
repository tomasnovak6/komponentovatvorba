using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovniPrikladPatek
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucet u1 = new Ucet("Homer Simpson");
            Ucet u2 = new Ucet("Lisa Simpson", 1000);
            Ucet u3 = new Ucet("Marge Simpson", 5000, 1000);

            Console.WriteLine(u1);
            Console.WriteLine(u2);
            Console.WriteLine(u3);

            try
            {
                u1.Vklad(100);
            }
            catch (InvalidAmountException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(u1);

            try
            {
                u1.Vyber(-200);
            }
            //catch (InvalidAmountException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (BalanceException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            catch (BankingException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(u1);

        }
    }
}
