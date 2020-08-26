using System;

namespace test
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int i, j, s = 1;
                for (i = 1; i <= 9; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        s = i * j;
                        Console.Write("  {0}", s);
                    }
                    Console.Write("\n");
                }
                Console.ReadLine();
            }


            //int num=Convert.ToInt32(i);
            //Console.WriteLine(num);
        }
    }
