using System;
using CurrencyExchange.service;

namespace CurrencyExchange
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CurrencyConverterService converter = new CurrencyConverterService(31.5m, 40.0m);

            Console.WriteLine("1. Convert UAH to USD");
            Console.WriteLine("2. Convert USD to UAH");
            Console.WriteLine("3. Convert UAH to EUR");
            Console.WriteLine("4. Convert EUR to UAH");
            Console.Write("Enter your choice (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                decimal amount;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter UAH amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Converted amount: {0} USD", converter.ConvertUahToUsd(amount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                        break;
                    
                    case 2:
                        Console.Write("Enter USD amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Converted amount: {0} UAH", converter.ConvertUsdToUah(amount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                        break;

                    case 3:
                        Console.Write("Enter UAH amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Converted amount: {0} EUR", converter.ConvertUahToEur(amount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                        break;

                    case 4:
                        Console.Write("Enter EUR amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Converted amount: {0} UAH", converter.ConvertEurToUah(amount));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input.");
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
        }
    }
}