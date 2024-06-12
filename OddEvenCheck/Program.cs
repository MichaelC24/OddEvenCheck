namespace OddEvenCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = 4;

            //Console.WriteLine("Please input a number");
            //string userInput = Console.ReadLine();

            //input = int.Parse(userInput);

            if (input % 2 == 0)
            {
                Console.WriteLine($"The number {input} is even");
            }
            else Console.WriteLine($"The number {input} is odd");

        }
    }
}
