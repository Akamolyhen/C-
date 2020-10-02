using System;
namespace 枚举
{
    //作用：枚举用来限定一个变量的取值范围
    public enum E_Dir
    {
        up,down,left,right
    }
    public class Person
    {
       
        public Person()
        {
        }
        public E_Dir dir = E_Dir.up;
        public void Showdir()
        {
            int num = 3;
            E_Dir mydir = (E_Dir)num;//根据整型数据转换成枚举类型
            Console.WriteLine(mydir);
            string str = "down";
            E_Dir mydir2 = (E_Dir)Enum.Parse(typeof(E_Dir), str);
            //这是将字符串转换成枚举类
            Console.WriteLine(mydir2);
            E_Dir d = E_Dir.up;
            string sre = d.ToString();//枚举类型转换为字符串类型
            int num2 = (int)d;
     
            Console.WriteLine(sre+' '+num2);
           


        }
    }
}
