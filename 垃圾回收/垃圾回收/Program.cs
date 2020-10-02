using System;

namespace 垃圾回收
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal ani = new Animal(5);
            ani = null;
            //垃圾回收机制，自动回收垃圾
            //注意：垃圾回收的时间点不能确定
            //如何避免系统很多垃圾的时候，垃圾回收没有启动？
            //手动调用垃圾回收，回收垃圾
            //调用垃圾回收机制会消耗性能，不能随意调用
            //GC.Collect()
            Console.ReadKey();
        }
    }
}
