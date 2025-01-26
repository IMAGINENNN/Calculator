using System;
using Calculator;

namespace Calculator
{
    internal class Program
    {
        // Creating input variables from user
        static double percent;
        static double value;
        static double[] values;
        static double result;
        
        // Exit of cycle in case of incorrect input
        static bool wrongNumberEntered = false;

        // Method that take`s 2 values
        static void AskForTwoVariebles()
        {
            values = new double[2];
            Console.Clear();
            Console.WriteLine("Enter Value 1:");
            try
            {
                values[0] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value, try again");
                wrongNumberEntered = true;
                Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Enter Value 2:");
            try
            {
                values[1] = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong value, try again");
                wrongNumberEntered = true;
                Console.ReadLine();
            }
        }

        // Method that take`s multiple values
        static void AskForMultipleVariebles()
        {
            Console.Clear();
            Console.WriteLine("Enter number of variebles you want to calculate:");

            int variablesLenght = 0;
            try
            {
                variablesLenght = Convert.ToInt32(Console.ReadLine());
            }
            // Catching incorrect input
            catch (Exception)
            {
                Console.WriteLine("Wrong value, try again");
                wrongNumberEntered = true;
                Console.ReadLine();
            }

            values = new double[variablesLenght];
            
            // Filling array
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"Enter Value {i + 1}:");
                values[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                const string ExitCommand = "exit";
                Console.Clear();

                Console.WriteLine("Calculator");
                Console.WriteLine();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine();
                Console.WriteLine("Enter:\t '1'\t for addition");
                Console.WriteLine("Enter:\t '2'\t for subtraction");
                Console.WriteLine("Enter:\t '3'\t for division");
                Console.WriteLine("Enter:\t '4'\t for multiplication");
                Console.WriteLine("Enter:\t '5'\t for percentage calculation");
                Console.WriteLine("Enter:\t '6'\t for square root calculation");
                Console.WriteLine();

                string inputData = Console.ReadLine();
                bool isExitCommand = ExitCommand.Equals(inputData, StringComparison.OrdinalIgnoreCase);

                // Checking if user entered incorrect number
                if (inputData != "1" & inputData != "2" & inputData != "3" & inputData != "4" & inputData != "5" & inputData != "6" & !isExitCommand)
                {
                    Console.Clear();
                    Console.WriteLine("Entered wrong number, try again");
                    Console.ReadLine();
                    continue;
                }
                
                // Exit from the program
                if (isExitCommand)
                {
                    Console.WriteLine("Program stopped");

                    break;
                }

                switch (inputData)
                {
                    case "1":
                        AskForMultipleVariebles();
                        if (wrongNumberEntered)
                        {
                            continue;
                        }
                        Console.Clear();
                        result = Calculator.Addition(values);
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (i == values.Length - 1)
                            {
                                Console.Write($"{values[i]}");
                                Console.WriteLine($" = {result}");
                                continue;
                            }
                            Console.Write($"{values[i]} + ");
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        AskForTwoVariebles();
                        if (wrongNumberEntered)
                        {
                            continue;
                        }
                        Console.Clear();
                        result = Calculator.Substraction(values);
                        Console.WriteLine($"{values[0]} - {values[1]} = {result}");
                        Console.ReadLine();
                        break;
                    case "3":
                        AskForTwoVariebles();
                        if (wrongNumberEntered)
                        {
                            continue;
                        }
                        Console.Clear();
                        result = Calculator.Dividing(values);
                        Console.WriteLine($"{values[0]} / {values[1]} = {result}");
                        Console.ReadLine();
                        break;
                    case "4":
                        AskForMultipleVariebles();
                        if (wrongNumberEntered)
                        {
                            continue;
                        }
                        Console.Clear();
                        result = Calculator.Multiplication(values);
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (i == values.Length - 1)
                            {
                                Console.Write($"{values[i]}");
                                Console.WriteLine($" = {result}");
                                continue;
                            }
                            Console.Write($"{values[i]} * ");
                        }
                        Console.ReadLine();
                        break;
                     case "5":
                        Console.Clear();
                        Console.WriteLine("Enter Number:");
                        try
                        {
                            value = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong value, try again");
                            continue;
                        }
                        Console.WriteLine("Enter amount of percent");
                        try
                        {
                            percent = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong value, try again");
                            continue;
                        }

                        Console.Clear();
                        result = Calculator.PercentCalculation(value, percent);

                        Console.WriteLine($"Percent of {value} is {result}");

                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Enter Number:");
                        try
                        {
                            value = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Wrong value, try again");
                            continue;
                        }

                        Console.Clear();
                        result = Math.Sqrt(value);

                        Console.WriteLine($"Square root of {value} is {result}");

                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
