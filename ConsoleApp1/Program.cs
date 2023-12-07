using System;
class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Console.ForegroundColor = ConsoleColor.Black;
        // Console.BackgroundColor = ConsoleColor.White;
        // Console.Clear();

        Console.WriteLine($"Biggest int {int.MaxValue}");
        Console.WriteLine($"Smallest int {int.MinValue}");

        bool boolFromStr = bool.Parse("true");
        int intFromStr = int.Parse("100");

        string strVal = intFromStr.ToString();
        Console.WriteLine($"strVal type: {strVal.GetType()}");
        double dbl = 23.456;
        int intNum = (int)dbl;
        Console.WriteLine(intNum);
        long lng = intNum;

        Console.WriteLine(string.Compare("A", "B", StringComparison.OrdinalIgnoreCase));

        object[] arr = ["paul", 123, 4.56];
        string[,] twoDimArr = new string[2, 2] { { "1", "2" }, { "3", "4" } };
        Console.WriteLine(twoDimArr[1, 0]);

    }
}