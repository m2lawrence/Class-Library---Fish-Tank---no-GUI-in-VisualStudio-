using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

//add this line in.
namespace ClassLibrary2.ConsoleApp1
{
    using ClassLibrary2.ConsoleApp1;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mike's Class Library App.");

            //build an object.
            Tank Tank1 = new Tank();

            //link method in object and write it.
            //*A user should be able to see how much food to put in the tank with a Tank1.Feed().
            //This should return the weight in grams of the total required fish food. 
            Tank1.Feed();

            //pause.
            Console.ReadKey(true);
        }
    }
}
