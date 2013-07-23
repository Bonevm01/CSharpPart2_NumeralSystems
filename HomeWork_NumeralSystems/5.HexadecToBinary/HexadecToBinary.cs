//5.Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexadecToBinary
{
    static void Main()
    {
        Console.Write("Please enter a hexadecimal number: ");
        string input = Console.ReadLine();
        char[] hexaSystem = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        int length = input.Length;
        string output = "";
        for (int i = 0, j = length - 1; i < length; i++, j--)
        {
            int possition = Array.BinarySearch(hexaSystem, input[j]);
            do
            {
                int remainder = possition % 2;
                output = remainder + output;
                possition /= 2;
            } while (possition > 0);
            output = " " + output;

        }
        Console.WriteLine("Binary representation of your number is {0}.", output);
    }
}
