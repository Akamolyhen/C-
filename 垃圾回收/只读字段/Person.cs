using System;
namespace 只读字段
{
    public class Person
    {
        private string gender="保密";
        public Person(int num)
        {
            age = num;
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != "男" && value != "女")
                    return;
                gender = value;
            }
        }
       //通过属性来保护字段
        public readonly int age = 18;//readonly 是只读的关键字
        //只读字段无法修改他的值，但是可以在构造函数里面重新赋值
        //const 与 readonly 的区别
        //1、const是常量的关键字，常量在申明的时候一定要赋值，readonly在申明时不需要要一定赋值
        //2、常量只能在申明的时候赋值，其他地方就不能重新对它赋值
        //只读字段可以在构造函数里进行重新赋值
    }   
}
