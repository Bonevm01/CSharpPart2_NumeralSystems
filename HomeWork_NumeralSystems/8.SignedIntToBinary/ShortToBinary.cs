//8.Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class ShortToBinary
{
    static void Main()
    {
        Console.Write("Please enter a random signed integer (-32 768 <=N<=32 767). N = ");
        short input = short.Parse(Console.ReadLine());
        int[] bits = new int[16];
        int possition = 15;
        if (input >= 0)
        {
            do
            {
                int remainder = input % 2;
                bits[possition] = remainder;
                possition--;
                input /= 2;

            } while (input > 0);
        }
        else
        {
            input = (short)(-1 * input - 1);
            for (int i = 0; i < 16; i++) bits[i] = 1;
            do
            {
                int remainder = input % 2;
                if (remainder == 1)
                {
                    bits[possition] = 0;
                }
                possition--;
                input /= 2;

            } while (input > 0);
        }
        Console.Write("Binary representation of this number is: ");
        for (int i = 0; i < 16; i++)
        {
            Console.Write(bits[i]);
            if (i % 4 == 3) Console.Write(" ");

        }
        Console.WriteLine();
    }
}
