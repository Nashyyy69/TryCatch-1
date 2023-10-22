using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter an integer number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number < 0)
            {   
                throw new Exception("Invalid number");
            }

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine($"Square root of {number} is {squareRoot}");
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
