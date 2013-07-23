//2.Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        int input = int.Parse(Console.ReadLine());
        int output = 0, power = 0;
        do
        {
            int remainder = input % 10;
            output += remainder * (int)Math.Pow(2, power);
            input /= 10;
            power++;
            
        } while (input>0);
        Console.WriteLine("Decimal representation of your number is {0}.", output);
    }
}
