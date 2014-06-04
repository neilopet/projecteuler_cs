/*
 * Problem 16
2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

What is the sum of the digits of the number 2^1000?
 */
using System;
using System.Numerics;

public class Problem16
{
	public static void Main()
	{
		BigInteger n = new BigInteger(1);
	 	/* Left bit shifting is the same as raising to power of 2 */
		n <<= 1000;
		String s = n.ToString();
		int sum = 0;
		for(int i = 0, j = s.Length; i < j; sum += Int32.Parse(s.Substring(i, 1)), i++)
			;
		Console.WriteLine(sum);
	}
	
}
