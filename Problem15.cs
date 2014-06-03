/*
 * http://projecteuler.net/problem=15
 */
using System;
using System.Numerics;

public class Problem15
{
	public static void Main()
	{
		/* Formula: (2R!) / (R! ^ 2) */
		BigInteger n = recfact( 1, 40 );
		BigInteger r = recfact( 1, 20 );
		Console.WriteLine( n / (r * r) );
	}
	
	/* Credit: http://www.luschny.de/math/factorial/FastFactorialFunctions.htm */
	public static BigInteger recfact(long start, long n) {
		long i;
		if (n <= 16) { 
			BigInteger r = new BigInteger(start);
			for (i = start + 1; i < start + n; i++) r *= i;
			return r;
		}
		i = n / 2;
		return recfact(start, i) * recfact(start + i, n - i);
	}
	
}
