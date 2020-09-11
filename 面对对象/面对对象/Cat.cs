using System;
namespace 面对对象
{
    public class Cat
    {
        public int age = 0;
        public string colour = "";
        public string name = "";

        public int Age { get => age; set => age = value; }

        public void Eat()
        {
            Console.WriteLine("猫在喵喵！");
        }
        public void Run()
        {
            Console.WriteLine("猫在墙上");
        }
        public void SayHello()
        {
            Console.WriteLine($"我是一只{colour}的{name},今年{age}岁");
        }
    }
}
