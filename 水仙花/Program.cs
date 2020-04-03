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
/*namespace test

{
    class 阶乘
    {
        static void Main(string[] args)

        {

            /*Console.WriteLine("请输入一个数");

            int number = Convert.ToInt32(Console.ReadLine());

            int sum=0;
            for(int j = number; j >= 1; j--)
            {
                
                int result = JieCheng(j);
                sum = sum + result;
            }*/
/* Console.WriteLine("请输入一个数");
 string i;//= Console.ReadLine();

 do
 {
     i = Console.ReadLine();
 }
 while (i=="");
 int number = Convert.ToInt32(i);
 int[] cen = new int[number+1];
 int[] result = Sum(number,cen);
 Console.Write($"这个数是{number},他的阶乘和：");
 for (int j = 0; j < number-1; j++)
 {
     Console.Write($"{result[j]}+");
 }
 Console.Write($"{result[number-1]}={result[number]}");
 //Console.WriteLine($"这个数是{number},他的阶乘和是{result[number]}");
}

public static  int[] Sum(int i,int[] shu)
{


 int sum = 0;

 for (int j = i; j >= 1; j--)
 {

     int result = JieCheng(j);
     shu[i - j] = result;
     sum += result;
 }
 shu[i] = sum;
 return shu;
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
}*/

/*using System;
class laoqu
{
    static void Main(string[] args)
    {

        //1.for
        int ODDadd = 0;
        int EVENadd = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) EVENadd = EVENadd + i;
            else ODDadd = ODDadd + i;
            
        }
        Console.WriteLine("100以内的奇数和为：{0}", +ODDadd);
        Console.WriteLine("100以内的偶数和为：{0}", +EVENadd);
        Console.WriteLine("----------------------------------");


        //2.while
        int ODDadd1 = 0;
        int EVENadd1 = 0;
        int j = 1;
        while (j <= 100)
        {
            if (j % 2 == 0) EVENadd1 = EVENadd1 + j;
            else ODDadd1 = ODDadd1 + j;
            j++;


        }
        Console.WriteLine("100以内的奇数和为：{0}", +ODDadd1);
        Console.WriteLine("100以内的偶数和为：{0}", +EVENadd1);
        Console.WriteLine("***********************************");


        // 3.do....while
        int ODDadd2 = 0;
        int EVENadd2 = 0;
        int k = 1;
        do
        {
            if (k % 2 == 0) EVENadd2 = EVENadd2 + k;
            else ODDadd2 = ODDadd2 + k;
            k++;

        } while (k <= 100);
        Console.WriteLine("100以内的奇数和为：{0}", +ODDadd2);
        Console.WriteLine("100以内的偶数和为：{0}", +EVENadd2);
        Console.WriteLine("###################################");

    }
}
*/
/*namespace Test
{

     public class Anlimal
    {
        protected int age = 4;
        protected void say(string name, string color)
        {
            Console.WriteLine("姓名：{0}，颜色：{1}", name, color);
        }
    }
    class Dog : Anlimal
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            int age = dog.age;
            Console.WriteLine("dog.age:{0}", age);
            dog.say("小黄", "黑色");
        }

    }


}*/
namespace 登录界面{    static class Program    {






        /// <summary>        /// 应用程序的主入口点。        /// </summary>        [STAThread]        static void Main()        {            Application.EnableVisualStyles();            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Login login = new Login();
            //界面转换
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)            {                login.Dispose();                Application.Run(new MainForm());            }            else if (login.DialogResult == DialogResult.Cancel)            {                login.Dispose();                return;            }        }    }}




