namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print its reverse :");

            int number = Convert.ToInt32(Console.ReadLine());

            ReverseNumber obj = new ReverseNumber();
            obj.Reverse(number);


        }
    }
}
