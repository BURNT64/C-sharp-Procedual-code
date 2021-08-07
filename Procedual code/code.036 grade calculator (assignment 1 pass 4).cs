using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //this line of code doesn't add much to the program as it is more of a cosmetic change to the background and text
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            //This line of code creates a basic graphic for the title of my program
            Console.WriteLine("<=================>");
            Console.WriteLine("  Grade calculator ");
            Console.WriteLine("<=================>");

            //All of these are the intergers that hold a variables value. all of these will be used later on in the program 
            int pass = 70;
            int merit = 80;
            int distinction = 90;
            int userpass;
            int usermerit;
            int userdistinction;
            int passtotal;
            int merittotal;
            int distinxriontotal;
            int UCAST;

            //in this line of code the user must enter the amount of passes they have achieved within their respected course. this also gives the userpass a value
            Console.Write("how many passes do you have?");
            userpass = Convert.ToInt32(Console.ReadLine());

            //in this line of code the user must enter the amount of merits they have achieved within their respected course. this also gives the usermerit a value
            Console.Write("how many merits do you have?");
            usermerit = Convert.ToInt32(Console.ReadLine());

            //in this line of code the user must enter the amount of distinctions they have achieved within their respected course. this also gives the userdistinction a value
            Console.Write("how many distinctions do you have?");
            userdistinction = Convert.ToInt32(Console.ReadLine());

            //this line of code multiplies the users value and the grade value together
            //the results are then added together in order to calculate the numvber of UCAS point the user has
            passtotal = pass * userpass;
            merittotal = merit * usermerit;
            distinxriontotal = distinction * userdistinction;
            UCAST = passtotal + merittotal + distinxriontotal;

            //this displays the results that were calculated before hand to give the user their total UCAS points
            Console.WriteLine("With the amount of UCAS points you will recieve: {0}", UCAST);

            //this line of code is needed so the user can end the program when they wish to

            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}
