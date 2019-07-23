﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_EvenMaker
{
    class EvenMaker
    {
        int[] numbers;
        static Random rand = new Random();

        public EvenMaker(int size)
        {
            numbers = new int[size];
        }

        public void Fill()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 50);
            }
        }

        public void MakeEven()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (number % 2 != 0)
                {
                  numbers [i]= number + 1;
                }

            }
            Console.WriteLine();
        }


        public void Show()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                Console.Write($"{number} ");
            }
        }
    }
}