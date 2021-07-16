using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
        static void Main(String[] args) 
	{
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        
        int i222 = int.Parse(Console.ReadLine());
        double d222 = double.Parse(Console.ReadLine());
        string s222 = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i222);
        
        // Print the sum of the double variables on a new line.
        Console.WriteLine(d222 + d);
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + s222);
        // The 's' variable above should be printed first.

        }
}