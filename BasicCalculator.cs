using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2, result;
        char operation;

        Console.WriteLine("Basic Calculator in C#");

        Console.Write("Enter an operator (+, -, *, /, %): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            case '%':
                result = num1 % num2;
                Console.WriteLine($"Result: {num1} % {num2} = {result}");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
