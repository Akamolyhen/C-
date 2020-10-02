using System;

namespace 只读字段
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(45);
            p.Gender = "女";
            Console.WriteLine(p.Gender+" "+p.age);
            Console.ReadKey();
        }
    }
}
