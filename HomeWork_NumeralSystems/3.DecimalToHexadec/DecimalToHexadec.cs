//3.Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadec
{
    static void Main()
    {
        Console.Write("Please enter a decimal integer:");
        int input = int.Parse(Console.ReadLine());
        string output = "";
        char[] hexaSystem = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        do
        {
            int remainder = input % 16;
            output = hexaSystem[remainder] + output;
            input /= 16;
        } while (input > 0);
        Console.WriteLine("Hexadecimal representation of your number is 0x{0}.", output);
    }
}
