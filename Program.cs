using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_EvenMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements?");
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine()); #converts the num variable to Int32


            EvenMaker e = new EvenMaker(num); #creates a new instance to call on methods from the program page
            
            # method calls to run the methods from the program page using the new instance
            e.Fill();
            e.Show();
            e.MakeEven();
            e.Show();


            Console.WriteLine("\nPAK");
            Console.ReadKey();


        }
    }
}
