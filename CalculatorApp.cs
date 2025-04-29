using System;

class Calculator
{
    private double num1;
    private double num2;
    private char operation;

    public void GetInput()
    {
        Console.Write("Enter an operator (+, -, *, /, %): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());
    }

    public void Calculate()
    {
        double result;

        switch (operation)
        {
            case '+':
                result = Add(num1, num2);
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case '-':
                result = Subtract(num1, num2);
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case '*':
                result = Multiply(num1, num2);
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = Divide(num1, num2);
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            case '%':
                result = Modulus(num1, num2);
                Console.WriteLine($"Result: {num1} % {num2} = {result}");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
    private double Add(double a, double b) => a + b; //Expression-bodied members
    private double Subtract(double a, double b) => a - b;
    private double Multiply(double a, double b) => a * b;
    private double Divide(double a, double b) => a / b;
    private double Modulus(double a, double b) => a % b;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Basic Calculator Using OOP in C#");
        Calculator calc = new Calculator();
        calc.GetInput();
        calc.Calculate();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
