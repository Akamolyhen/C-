using System;
namespace 单例模式
{
    public class Level
    {
        public Level()
        {
        }
        public void Passlevel()
        {
            /*Packdata pack = new Packdata();
            pack.count += 50;
            Console.WriteLine($"恭喜通关，目前背包的金币个数：{pack.count}");*/
            //Packdata pack=Packdata.GetInstance();
            Packdata pack = Packdata.Instance;
            int count = pack.Count;
            count += 50;
            //pack.Setcount(count);
            pack.Count = count;
            Console.WriteLine($"恭喜通关，目前背包的金币个数：{pack.Count}");
        }//通关奖励
    }
}
