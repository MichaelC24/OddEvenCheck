namespace OddEvenCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 1;

            while (true)

            {

                Console.Write("Enter an integer (Zero to close): ");
                string userInput = Console.ReadLine();

                input = Convert.ToInt32(userInput);

                if (input == 0)
                {
                    break;
                }
            
                if (input % 2 == 0)
                {
                    Console.WriteLine($"The number {input} is even");
                }
                else Console.WriteLine($"The number {input} is odd");
            }
                Console.Write("Done...");
        }
    }
}