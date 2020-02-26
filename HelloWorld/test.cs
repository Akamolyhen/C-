//using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)//方法的说明，要求返回void或int；且要么无参，要么接收一个字符串数组
        {
            string str1,str2,str3;
            System.Console.Write("你的名字是：");
            str3=System.Console.ReadLine();
            str2="程锦昊是：";
            str1=System.Console.ReadLine();
            System.Console.WriteLine(str2+str1);

        }
    }
}
