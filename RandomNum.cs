using System;
namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Number Generator");
            Console.WriteLine("Enter the number of digits for the random number (1-100): ");
            int numberOfDigits = int.Parse(Console.ReadLine());
            if(numberOfDigits < 1 || numberOfDigits > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                return;
            }
            Console.WriteLine($"Generating a random number with {numberOfDigits} digits...");
            Random random = new Random();
            string randomNumber = "";
            for (int i = 0; i < numberOfDigits; i++)
            {
                int digit = random.Next(0, 10);
                randomNumber += digit.ToString();
            }
            Console.WriteLine($"Random number generated: {randomNumber}");
        }
    }
}