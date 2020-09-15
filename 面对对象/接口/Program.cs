using System;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            ICBC bank = new ICBC();
            bank.SaveMoney();
        }
    }
}
