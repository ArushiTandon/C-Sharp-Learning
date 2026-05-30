using System.Security.Cryptography;

namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            FullTimeWorker emp1 = new FullTimeWorker("Arushi");
            Intern emp2 = new Intern("Rohit");

            emp1.CalculateSalary();
            emp2.CalculateSalary();


        }
    }
}
