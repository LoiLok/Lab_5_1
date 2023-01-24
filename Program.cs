using System;

class Program
{
    static void Main()
    {
        string b = "start";
        double previosValue = 0;
        while (b != "q")
        {
            b = Console.ReadLine();
            bool isDouble = double.TryParse(b, out double numDouble);
            bool isInt = int.TryParse(b, out int numInt);
            if (isInt)
            {
                Console.WriteLine((char)numInt);
                previosValue = numInt;
            }
            else if (isDouble)
            {
                if (numDouble == previosValue) break;
                previosValue = numDouble;

            }
        }

    }
}