/*
 * Problem10
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */
using System;
using System.Collections;
using System.Collections.Generic;

class Problem9
{
	public static void Main ()
	{
		Console.WriteLine (SumSieveOfEratosthenes(2000000).ToString());
	}

	public static long SumSieveOfEratosthenes(int upperLimit) 
	{
		long result = 2;
		int sieveBound = (int)(upperLimit - 1) / 2;
		int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

		bool[] PrimeBits = new bool[sieveBound + 1];

		for (int i = 1; i <= upperSqrt; i++) 
		{
			if (!PrimeBits[i]) 
			{
				for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) 
				{
					PrimeBits[j] = true;
				}
			}
		}

		for (int i = 1; i <= sieveBound; i++) 
		{
			if (!PrimeBits[i]) 
			{
				result += (2 * i + 1);
			}
		}

		return result;
	}
}
