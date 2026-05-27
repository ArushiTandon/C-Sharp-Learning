using System.Security.Cryptography;

namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
          
           Student[] obj = new Student[3];
            for(int i = 0; i < obj.Length; i ++)
            {
                obj[i] = new Student();
                Console.WriteLine("Enter the roll number of student " );
                int r_no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the fees of student ");
                int fees = Convert.ToInt32(Console.ReadLine());

                obj[i].Accept(r_no , fees);
            }

            int max = 0;
            int index = 0;
            for( int i = 0; i < obj.Length; i++)
            {
                if (max < obj[i].fees)
                {
                    max = obj[i].fees;
                    index = i;
                }
            }

            Console.WriteLine("maximum fees is {0}", max);
            obj[index].Display();


        }
    }
}
