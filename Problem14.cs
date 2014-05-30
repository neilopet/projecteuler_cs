/*
 * Problem #14
The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million.
 */
using System;
					
public class Problem14
{
	public static int max = 1000000;
	public static int[] cache = new int[ max + 1 ];
	
	public static void Main()
	{
		/* initialize cache array with -1 values */
		for(int i = 0; i <= max; cache[i++] = -1)
			;
		cache[1] = 1;
		
		Func<long, int> Collatz = null;
		
		Collatz = ( x ) => {
			int ret = 1;
			
			if (x < cache.Length && cache[x] != -1)
			{
				return cache[x];
			}
			
			if ( x % 2 == 0 )
			{
				ret = 1 + Collatz( x / 2 );
			}
			else
			{
				ret = 1 + Collatz( 3 * x + 1 );
			}
			
			if (x < cache.Length)
			{
				cache[x] = ret;
			}
			return ret;
		};
		
		int c = 0, collatzSequences = 0, num = 0;
		for( int i = 1; i < max; i++ )
		{
			c = Collatz(i);
			if (c > collatzSequences)
			{  
				collatzSequences = c;
				num = i;
			}
		}
		
		Console.WriteLine("{0} has {1} sequences", num, collatzSequences);
		
	}
}
