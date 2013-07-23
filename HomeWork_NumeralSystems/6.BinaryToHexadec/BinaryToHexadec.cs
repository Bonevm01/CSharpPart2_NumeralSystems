//6.Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHexadec
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        long input = long.Parse(Console.ReadLine());
        char[] hexaSystem = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int power = 0;
        long tempor = 0;
        string output = "";
        do
        {
            long remainder = input % 10;
            tempor += remainder * (long)Math.Pow(2, power);
            input /= 10;
            power++;
            if (power == 4 || input == 0)
            {
                output = hexaSystem[tempor] + output;
                power = 0;
                tempor = 0;
            }

        } while (input > 0);
        Console.WriteLine("Hexadecimal representation of your number is 0x{0}.", output);
    }
}
