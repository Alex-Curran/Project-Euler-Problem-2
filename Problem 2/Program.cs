/*
 *   Project Euler: Problem 2
 *   Alex Curran 
 *   
 *   By considering the terms in the Fibonacci sequence whose values do not exceed four million,
 *   find the sum of the even-valued terms.
 *   
 *  https://projecteuler.net/problem=2
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            long upperLimit = 4000000;
            long sum = sumEvenFibonacci(upperLimit);
            Console.WriteLine("The sum of even fibonacci numbers under {0:n0} = {1:n0}", upperLimit, sum);
        }


        /// <summary>
        ///  Computes fibonacci numbers. Then adds the even numbers. 
        ///  This is the first implementation. There are better and faster ways to do this!
        /// </summary>
        /// <param name="limit"> Upper limit. Used as stopping point for calculation</param>
        /// <returns> Returns the sum of the even fibonacci numbers</returns>
        private static long sumEvenFibonacci(long limit)
        {
            long sum = 0; 

            List<long> Fibonacci = new List<long>();
            Fibonacci.Add(1);
            Fibonacci.Add(2);

            // Adds Fibonacci numbers < limit to a List 
            int i = 1;
            while (Fibonacci[i] + Fibonacci[i - 1] < limit)
            {
                Fibonacci.Add(Fibonacci[i] + Fibonacci[i - 1]);
                i++;
            }

            //Get the even numbers 
            var evenFibonacci =     (from fib in Fibonacci
                                     where fib % 2 == 0
                                     select fib).ToList();
            foreach (long value in evenFibonacci)
            {
                sum += value;
            }

            return sum;

        }

    }
}
