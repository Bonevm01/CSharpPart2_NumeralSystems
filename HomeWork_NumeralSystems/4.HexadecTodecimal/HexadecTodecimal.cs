//4.Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecTodecimal
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string input = Console.ReadLine();
        char[] hexaSystem = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int length = input.Length;
        int output = 0;
        for (int i = 0, j = length - 1; i < length; i++, j--)
        {
            int possition = Array.BinarySearch(hexaSystem, input[j]);
            output += possition * (int)Math.Pow(16, i);

        }
        Console.WriteLine("Decimal representation of your number is {0}.", output);
    }
}
