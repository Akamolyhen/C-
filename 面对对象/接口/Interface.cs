using System;
namespace 接口
{
    //接口是一种行为规范
    //不需要访问修饰符，不需要方法体实现，只需要声明
    public interface IBank
    {
        void SaveMoney();
        void GetMoney();
        void ChangeMoney();
        
    }
}
