using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_EvenMaker
{
    class EvenMaker
    {
        int[] numbers; #creates an array called numbers
        static Random rand = new Random(); #intializes the random class for use 

        public EvenMaker(int size) #method with an integer as a parameter 
        {
            numbers = new int[size]; #makes the array a certain size based on the user input
        }

        public void Fill() #method for filling the array with numbers 
        {
            for (int i = 0; i < numbers.Length; i++) #goes through the numbers array  
            {
                numbers[i] = rand.Next(1, 50); #adds random numbers to the array between 1 and 50
            }
        }

        public void MakeEven() #method name to make the odd number even within the array
        {
            for (int i = 0; i < numbers.Length; i++) #goes through the number array
            {
                int number = numbers[i]; #singles out each number within the array
                if (number % 2 != 0)
                {
                  numbers [i]= number + 1; #if the number in the array is odd then add one to make even 
                }

            }
            Console.WriteLine();
        }


        public void Show() #method to show the array before or after making the numbers even 
        {
            for (int i = 0; i < numbers.Length; i++)#goes through the number array
            {
                int number = numbers[i]; #singles out each number within the array
                Console.Write($"{number} "); #prints out each number within the array 
            }
        }
    }
}
