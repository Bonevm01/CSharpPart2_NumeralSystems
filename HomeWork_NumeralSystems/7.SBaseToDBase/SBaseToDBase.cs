//7.Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class SBaseToDBase
{
    static void Main()
    {
        Console.Write("Please enter the base of the first numeral System. S(2<=S<=16) = ");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Enter a random number in {0} based numeral system: ", S);
        string inputNumber = Console.ReadLine();
        Console.Write("Please enter the base of the second numeral System. D(2<=S<=16) = ");
        int D = int.Parse(Console.ReadLine());

        char[] hexaSystem = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        //Convert S number to Decimal number
        int decimalNumber = 0;
        for (int i = 0; i < inputNumber.Length; i++)
        {
            decimalNumber += Array.BinarySearch(hexaSystem, inputNumber[inputNumber.Length - i - 1]) * (int)Math.Pow(S, i);

        }
        Console.WriteLine();
        Console.WriteLine("Decimal equivalent is {0}.", decimalNumber);
        Console.WriteLine();

        //Convert Decimal number to D number
        string output = "";
        do
        {
            int remainder = decimalNumber % D;
            output = hexaSystem[remainder] + output;
            decimalNumber /= D;
        } while (decimalNumber > 0);

        Console.WriteLine("The number in {0} numeral system looks {1}", D, output);
    }
}
