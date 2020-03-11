using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string i;
            while (true)
            {
                i = Console.ReadLine();
                foreach (char c in i)
                {
                    if ((int)c > 0)
                        break;
                }
            }
            Console.WriteLine("hehe");
            
           
            //int num=Convert.ToInt32(i);
            //Console.WriteLine(num);
        }
    }
}
