using System.Security.Cryptography;

namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            PropertyExample example = new PropertyExample();
            example.Width = 200; //setter
            Console.WriteLine(example.Width); //getter

          
        }
    }
}
