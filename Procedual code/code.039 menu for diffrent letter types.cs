using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose an option from the following list of leter types");
            Console.WriteLine("\ta - bills");
            Console.WriteLine("\ts - circulars");
            Console.WriteLine("\tm - Postcards");
            Console.WriteLine("\td - Personal Letters");
            Console.Write("Your option? ");

         
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("bills must be paid:");    
                case "s":
                    Console.WriteLine("circulars are thrown away:");
                case "m":
                    Console.WriteLine("postcards are put on the wall:");
                case "d":
                    Console.WriteLine("personal letters are read and have replies written for them:");
            }

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
