﻿using System;

namespace Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
          int y = 1;
            Console.Write("The Fibonacci Series is ");
            Console.Write("{0}, ", x);
            for (int c = 0; c < 10; c++)
            {
                Console.Write("{0}, ", y);
                y+=x;
                x = y;
            }
                
        }
    }
}
