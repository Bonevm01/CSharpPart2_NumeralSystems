//1.Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Please enter a decimal integer:");
        int input = int.Parse(Console.ReadLine());
        string output = "";
        do
        {
            int remainder = input % 2;
            output = remainder + output;
            input /= 2;
        } while (input > 0);
        Console.WriteLine("Binary representation of your number is: {0}.", output);
    }
}
