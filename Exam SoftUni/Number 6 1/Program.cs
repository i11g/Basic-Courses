﻿using System;

namespace Number_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            int lastNumber=number%10;
            int secondNumber = (number / 10) % 10;
            int thirdNumber=(number/100);
           

            for (int i = 1; i<=lastNumber ; i++)
            {
                for (int j = 1; j <=secondNumber; j++)
                {
                    for (int k = 1; k <=thirdNumber; k++)
                    {
                        int product = i * j * k;
                        Console.WriteLine($"{i} * {j} * {k} = {product};");
                    }
                }
            }
        }
    }
}
