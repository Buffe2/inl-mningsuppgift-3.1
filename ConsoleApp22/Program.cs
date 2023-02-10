using System;
namespace Uppgift_3._1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int intNr1 = Convert.ToInt32(Console.ReadLine());

            if (intNr1 < 16)
                Console.WriteLine("Du är för ung");
            else if (intNr1 > 19)
                Console.WriteLine("Du är för gammal");
            else
                Console.WriteLine("Du får delta i tävlingen");
        }
    }
}