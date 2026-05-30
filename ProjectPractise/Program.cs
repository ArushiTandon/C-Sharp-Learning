using System.Security.Cryptography;

namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Emp obj = new Emp(101, "Arushi", 5000, 500 );

            Console.WriteLine($"ID: {obj.id}");
            Console.WriteLine($"Name: {obj.name}");
            Console.WriteLine($"Salary: {obj.salary}");
            Console.WriteLine($"Incentive: {obj.incentive}");


        }
    }
}
