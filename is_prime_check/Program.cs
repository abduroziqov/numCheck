namespace is_prime_check
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number => ");
            int.TryParse(Console.ReadLine(), out int firstNum);

            int count = 0;

            for (int i = 1; i < firstNum; i++) if (firstNum % i == 0) count++;

            if (count <= 2) Console.WriteLine("The number is prime: " + firstNum);
            else Console.WriteLine("The number is not prime: " + firstNum);

            Main();
        }
    }
}