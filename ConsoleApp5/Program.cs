using System;
namespace loops
{
    class program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while(a<=20)
            {
                Console.WriteLine("a={0}",a);
                a++;
            }
            Console.ReadLine();
        }
    }
}