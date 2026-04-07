using System;

namespace ifelse
{
    class ifelse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade:\n");
            int idd = Convert.ToInt32(Console.ReadLine());

            if (idd >= 18)
            {
                Console.WriteLine("\nAdulto.");
            }
            else if (idd >= 14)
            {
                Console.WriteLine("\nAdolescente.");
            }
            else
            {
                Console.WriteLine("\nCriança.");
            }
        }
    }
}