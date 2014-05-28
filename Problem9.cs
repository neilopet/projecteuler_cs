/*
 * Problem #9
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/
using System;
using System.Numerics;
					
public class Problem9
{
	public void Main()
	{
		int[] pythTriplet = LargestTripletFromSum( 1000 );
		
		Console.WriteLine("{0} * {1} * {2} = {3}", 
						  pythTriplet[0], 
						  pythTriplet[1], 
						  pythTriplet[2], 
						  (pythTriplet[0] * pythTriplet[1] * pythTriplet[2]));
	}
	
	/* Credit: http://www.mathblog.dk/pythagorean-triplets/ */
	public int[] LargestTripletFromSum( int val ) 
	{
		int a = 0, 
			b = 0, 
			c = 0;
		
		int	k = 0, 
			n = 0, 
			d = 0;
		
		bool found = false;
		
		for ( int m = 2, max = (int)Math.Sqrt(val / 2); m <= max; m++ ) 
		{
			if ( (val / 2) % m == 0 ) 
			{
				k = ( m % 2 == 0 ) ? (m + 1) : (m + 2);
				
				while ( k < (2 * m) 
					   && k <= (val / (2 * m)) )
				{
					if ( ( ((val / (2 * m)) % k) == 0 ) 
						&& BigInteger.GreatestCommonDivisor(k, m) == 1 ) 
					{
						d = val / 2 / (k * m);
						n = k - m;
						a = d * ((m * m) - (n * n));
						b = 2 * d * n * m;
						c = d * ((m * m) + (n * n));
						found = true;                            
						break;
					}
					k += 2;
				}                    
				
			}
			
			if ( found ) 
			{
				break;
			}
		}
		
		return new int[] { a, b, c };
	}
                    
}
