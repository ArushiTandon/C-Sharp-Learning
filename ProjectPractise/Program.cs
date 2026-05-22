namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to print its multiplication table:");

            int number = Convert.ToInt32(Console.ReadLine());

            PrintTable obj = new PrintTable();
            obj.Print(number);


        }
    }
}
