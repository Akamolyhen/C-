﻿using System;
using System.Collections.Generic;
/*namespace HelloWorld
{
class Program
{
static void Main(string[] args)//方法的说明，要求返回void或int；且要么无参，要么接收一个字符串数组
{
string str1,str2,str3;//变量使用camelCase风格（除第一个单词外，其他每个单词的首字母都要大写）
Console.Write("你的名字是：");
str3=Console.ReadLine();
str2="程锦昊是：";
str1=Console.ReadLine();
Console.WriteLine(str2+str1);
int value;
char character;
value=Console.Read();
character=(char) value;
Console.WriteLine(character);

}
}
}
*/
/*namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_16
{
    public class Program
    {
        public static void Main()
        {
            string firstName;
            string lastName;
            string str1="大炮几秒钟",str2="爱操你老公";

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine(
                "Your full name is {0}{1}.",firstName,lastName);
            System.Console.WriteLine($"Your full name is {firstName}{lastName} say："+$"{str1}\t{str2}");
        }
    }
}*/

/*</pre><pre name="code" class="csharp">using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace NarcissisticNumber
{
    class NarNumber//建立水仙数的类，在Main中调用此类
    {
        public void NarcisNumber()
        {
            Console.WriteLine("*****************输出100~999的水仙花数***************");
            Console .Write("\n\t100~999之间的水仙花数为：");
 
            for (int i = 100; i <= 999; i++)
            {
                if (judge(i))
                {
                    Console.Write("{0} ",i);
                }
            }
            Console.WriteLine("\n\n****************************************************\n\n");
        }
 
        public void Narcinumber()//判断四位数是否为水仙数的函数
        {
            Console.WriteLine("*****************输出1000~9999的水仙花数************");
            Console.Write("\n\t1000~9999的水仙花数为：");
 
            for (int i = 1000; i <= 9999; i++)
            {
                if (Judge(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\n\n****************************************************\n\n");
        }
 
        public bool judge(int num)  //判断三位水仙花数的语句
        {
            int a, b, c;
            a = num / 100;
            b = (num - a * 100) / 10;
            c = num % 10;
 
            if (num == Recurison(a,3) + Recurison(b,3) + Recurison(c,3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
        public bool Judge(int num)      //判断四位数为水仙数的语句
        {
            int a, b, c, d;
            a = num / 1000;
            b = num % 1000 / 100;
            c = num % 100 / 10;
            d = num % 10;
 
            if (num == Recurison(a,4) + Recurison(b,4) + Recurison(c,4) + Recurison(d,4))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
 
        public int Recurison(int num, int n)  //利用递归计算  a^4
        {
            if (n == 1)
            {
                return num;
            }
            else
            {
                return num * Recurison(num,n-1);
            }
        }
 
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            NarNumber a = new NarNumber();//构造新的NarNumber函数
            //判断三位数的调用的函数类
            a.NarcisNumber();
            //判断四位数的调用的函数类
            a.Narcinumber();
            Console.ReadKey();//防止程序闪退
        }
    }
}*/


/*
namespace test
{
    class 阶乘
    {
        static void Main()
        {
            Console.WriteLine("请输入一个数");
            string i;       //= Console.ReadLine();
            do
            {
                i = Console.ReadLine();
            }
            while (i == "");
            int number = Convert.ToInt32(i);
            int[] cen = new int[number + 1];
            int[] result = Sum(number, cen);
            Console.Write($"这个数是{number},他的阶乘和：");
            for (int j = 0; j < number - 1; j++)
            {
                Console.Write($"{result[j]}+");
            }
            Console.Write($"{result[number - 1]}={result[number]}");
            //Console.WriteLine($"这个数是{number},他的阶乘和是{result[number]}");
        }
        public static int[] Sum(int i, int[] shu)
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
}

*/

namespace test
{
    class Program

    { 
        static void Main()
        {
            /*int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadKey();*/

            //要求用户输入他的语文，数学，英语成绩，并求出总分
            /* Console.WriteLine("请输入语文成绩");
             double chinese = double.Parse(Console.ReadLine());
             Console.WriteLine("请输入数学成绩");
             double math = double.Parse(Console.ReadLine());
             Console.WriteLine("请输入英语成绩");
             double english = double.Parse(Console.ReadLine());
             Console.Write($"总分为：{chinese+math+english}");
             Console.ReadKey();*/
            /*string[] arr = { "www", "eee", "ttt" };
            foreach (var item in arr)//foreach遍历
            {
                Console.WriteLine(item);
            }*/
            Dictionary<int, string> dic = new Dictionary<int, string>
            {
                { 1, "一" },
                { 2, "二" },
                { 3, "三" }
            };//键值对中键是唯一的
            string value = dic[2];
            Console.WriteLine(value);
            int count = dic.Count;
            Console.WriteLine(count);
            foreach (var item in dic)//KeyValuepair  键值对
            {
                Console.WriteLine(item.Value);
            }

            //判断字典里是否有某个键
            bool hasKey=dic.ContainsKey(5);
            Console.WriteLine(hasKey);
            Console.ReadKey();
        }
    }
    
}
 