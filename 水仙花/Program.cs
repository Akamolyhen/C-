//using System;
/*namespace 水仙花
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
/*using System;
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
}*/
//using System;
/*namespace 水仙花
{
    class test
    {
        static void Main()
        {
            int i;
            Console.Write("水仙花数有：");
            for(i=100;i<10000;i++)
            {
                int sum=0;
                int length=i.ToString().Length;
                for(int j=i;j>0;j/=10)
                    {
                        int temp=j%10;
                        sum+=(int)Math.Pow(temp,length);
                    }
                if(i==sum)
                {
                    Console.Write($"\t  {i}");
                } 

            }
             Console.Write("\n");  
        }
    }
}*/

/*class test
{
    /*static void Main()//声明具名元组，将元组值赋给他，并按照名称访问元组项
    {
        (string Name, string Capital, double GdpPerCapita) countryInfo =
            ("中国", "北京", 223342030400.43);
        Console.WriteLine($"The richest country in the world in 2020 was {countryInfo.Name}," +
            $"首都是{countryInfo.Capital},国民总Gdp{countryInfo.GdpPerCapita}");
    }
    static void Main()
    {
        
    }
}*/
using System;
namespace test

{
    class 阶乘
    {
        static void Main(string[] args)

        {

            Console.WriteLine("请输入一个数");

            int number = Convert.ToInt32(Console.ReadLine());

            int sum=0;
            for(int j = number; j >= 1; j--)
            {
                
                int result = JieCheng(j);
                sum = sum + result;
            }
            Console.WriteLine($"这个数的阶乘和是{sum}");
            

           
           

        }



        public static int JieCheng(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * JieCheng(number - 1);

        }
       
    }
}



