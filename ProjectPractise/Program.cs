using System.Security.Cryptography;

namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ConstructorExample obj = new ConstructorExample(2, 3);
            ConstructorExample obj1 = new ConstructorExample(obj);

          
        }
    }
}
