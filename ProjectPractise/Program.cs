namespace ProjectPractise
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(StaticExample.x);
            StaticExample.fun();

            InstanceExample obj = new InstanceExample();
            Console.WriteLine(obj.x);
            obj.fun1();


        }
    }
}
