/*
 * Problem #1
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */
using System;
					
public class Problem1
{
	public static void Main()
	{
		int runningTotal = 0;
		for ( int i = 1; i < 1000; i++)
		{
			runningTotal += (i % 3 == 0) || (i % 5 == 0) ? i : 0;
		}
		Console.WriteLine("Running total: {0}", runningTotal);
	}
}
