/*
 * Problem #4
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */
using System;

public class Problem4
{
	public void Main()
	{
		int LargestPalindrome = 1;
		
		for (int i = 998001; i > 10001; i--) 
		{
			for (int j = 999; j > 99; j--)
			{
				if (i % j == 0 
					&& IsPalindrome(i.ToString())
				    && (i/j).ToString().Length == 3)
				{
					LargestPalindrome = i;
					i = 0;
					break;
				}
			}
		}

		Console.WriteLine(LargestPalindrome);
	}
	
	public bool IsPalindrome(string value)
  {
		int min = 0;
		int max = value.Length - 1;
		while (true)
		{
		    if (min > max)
		    {
				    return true;
		    }
		    char a = value[min];
		    char b = value[max];
		    if (char.ToLower(a) != char.ToLower(b))
		    {
				    return false;
		    }
		    min++;
		    max--;
		}
  }
}
