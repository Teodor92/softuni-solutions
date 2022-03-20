using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int barcodeCount = int.Parse(Console.ReadLine());
            string barcodePattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";

            for (int i = 0; i < barcodeCount; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, barcodePattern))
                {
                    char[] digits = input.Where(x => char.IsDigit(x)).ToArray();

                    if (digits.Length == 0)
                    {
                        Console.WriteLine("00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join(string.Empty, digits)}");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
