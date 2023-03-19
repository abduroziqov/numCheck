namespace calculator
{
    internal class Program
    {
        static void Main()
        {
            int result = 0;

            Console.Write("Enter operation type for two numbers ( +, -, *, / ) => ");
            ConsoleKey keys = Console.ReadKey().Key;
            Console.WriteLine();

            Console.Write("Enter first value => "); int.TryParse(Console.ReadLine(), out int firstNum);
            Console.Write("Enter second value => "); int.TryParse(Console.ReadLine(), out int secondNum);

            switch (keys)
            {
                case ConsoleKey.Add: result = firstNum + secondNum; break;
                case ConsoleKey.Subtract: result = firstNum - secondNum; break;
                case ConsoleKey.Multiply: result = firstNum * secondNum; break;
                case ConsoleKey.Divide: if (secondNum != 0) result = firstNum / secondNum; break;
            }

            Console.WriteLine($"Result is {result}");

            Main();
        }
    }
}