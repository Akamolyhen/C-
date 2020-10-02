using System;
namespace 单例模式
{
    //单例模式：多个类共用一个实例
    //1、先写一个私有的该类类型的静态字段
    //2、写一个静态的方法，返回值为该类类型
    //方法里面先判断该类类型的静态字段是否为空，如果为空就实例化该静态字段，并返回该静态字段
    //构造函数私有化
    public class Packdata
    {
        private Packdata()//构造函数私有化（私有化后可以防止外界随意的实例化出一个对象）
        {
        }
        private int count = 100;
        private static Packdata instance;

        public int Count { get => count; set => count = value; }
        public void Setcount(int num)
        {
            count = num;
        }

        public static Packdata GetInstance()//利用类的方法来创建一个单例
        {
            if(instance==null)
            {
                instance = new Packdata();
            }
            return instance;
        }
        public static Packdata Instance//利用类的属性创建一个单例
        {
            get
            {
                if (instance == null)
                    instance = new Packdata();
                return instance;
            }
        }
    }
}
