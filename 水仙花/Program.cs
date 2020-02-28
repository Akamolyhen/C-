/*using System;
namespace 水仙花
{
    class Program
    {
        static void Main(string[] args)
        {
           int ge, shi, bai,qian;
           int j=0;
         Console.WriteLine("所有三位水仙花数是:");
         for (int i = 100; i <= 999; i++)
         {
            ge = i % 10;
            shi = i / 10 % 10;
            bai = i / 100;
            if (ge * ge * ge + shi * shi * shi + bai * bai * bai == i)
               {
               	Console.Write($"  {i}");
                j++;

               }
         
         }
         Console.WriteLine($"共有{j}个");
         Console.WriteLine("\n所有四位水仙花数是：");
         j=0;
         for(int i=1000;i<10000;i++)
         {
         	ge=i%10;
         	shi=i/10%10;
         	bai=i/100%10;
         	qian=i/1000;
         	if(ge*ge*ge*ge+shi*shi*shi*shi+bai*bai*bai*bai+qian*qian*qian*qian==i)
         		{
         			Console.Write($"  {i}");
                    j++;
         		}
        }
        Console.WriteLine($"共有{j}个");
       
       
    }
}
}
*/
using System;
namespace qia
{
    class ToString
    {
        static void Main()
        {
            int i;
            int m=1;
            for(i=0;i<100;i++)
            {
                
                int length=i.ToString().Length;
                Console.Write(length);
                if(m!=length)
                {
                    Console.WriteLine(length);
                    m=length;
                }
            }
        }
    }
}