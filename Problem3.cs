/*
 * Problem #3
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
 */
using System;

public class Problem3
{
	public void Main()
	{
		Console.WriteLine( Factor( 6008514751430 ) );
	}
	
	public Int64 Factor( Int64 number )
	{
		Int64 ret = 1;
		int mod = 2;
		while ( number > 1 )
		{
			while ( number % mod == 0 )
			{
				number /= mod;
				ret = number;
			}
			mod += 1;
			/* Square Root check: Makes this O(sqrt(n)) average */
			if ( mod * mod > number )
			{
				if ( number > 1 )
				{
					ret = number;
				}
				break;
			}
		}
		return ret;
	}
}
