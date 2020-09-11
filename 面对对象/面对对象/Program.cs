using System;

namespace 面对对象
{
    //核心思想：封装，继承，多态
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "野猫";
            cat.age = 3;
            cat.colour = "yellow";
            cat.SayHello();
            cat.Run();
            cat.Eat();
            Console.ReadKey();
           
        }
    }
}
