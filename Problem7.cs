/*
 * Problem #7
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
 */
using System;
using System.Collections;
using System.Collections.Generic;

public class Problem7
{
	public void Main()
	{
		Console.WriteLine(GeneratePrimesSieveOfEratosthenes(10001));
	}

	/* Uses Eratosthenes Sieve - 
	Credit: http://stackoverflow.com/a/1072205 */
	public static int ApproximateNthPrime(int nn)
	{
	    double n = (double)nn;
	    double p;
	    if (nn >= 7022)
	    {
	        p = n * Math.Log(n) + n * (Math.Log(Math.Log(n)) - 0.9385);
	    }
	    else if (nn >= 6)
	    {
	        p = n * Math.Log(n) + n * Math.Log(Math.Log(n));
	    }
	    else if (nn > 0)
	    {
	        p = new int[] { 2, 3, 5, 7, 11 }[nn - 1];
	    }
	    else
	    {
	        p = 0;
	    }
	    return (int)p;
	}

	public static BitArray SieveOfEratosthenes(int limit)
	{
	    BitArray bits = new BitArray(limit + 1, true);
	    bits[0] = false;
	    bits[1] = false;
	    for (int i = 0; i * i <= limit; i++)
	    {
	        if (bits[i])
	        {
	            for (int j = i * i; j <= limit; j += i)
	            {
	                bits[j] = false;
	            }
	        }
	    }
	    return bits;
	}

	public static int GeneratePrimesSieveOfEratosthenes(int n)
	{
	    int largestPrime = 0;
	    int limit = ApproximateNthPrime(n);
	    BitArray bits = SieveOfEratosthenes(limit);
	    for (int i = 0, found = 0; i < limit && found < n; i++)
	    {
	        if (bits[i] && i > largestPrime)
	        {
				largestPrime = i;
	            found++;
	        }
	    }
	    return largestPrime;
	}
}
