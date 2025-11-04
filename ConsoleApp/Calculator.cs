using System;

public class Class1
{
	public Class1()
	{
        using System;

public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Welcome to the Calculator");

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid number. Exiting...");
                return;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid number. Exiting...");
                return;
            }

            Console.Write("Enter an operator (+, -, *, /): ");
            string op = Console.ReadLine();

            try
            {
                double result = op switch
                {
                    "+" => num1 + num2,
                    "-" => num1 - num2,
                    "*" => num1 * num2,
                    "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero."),
                    _ => throw new InvalidOperationException("Invalid operator.")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


}
}
