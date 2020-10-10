using System;
using System.IO;
using System.Text;

namespace 文件流操作
{
    class Program
    {
        //写法1 using (FileStream fs = File.Create(path))    写法2  fs.Dispose();
        static void Main(string[] args)
        {
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //using (FileStream fs = File.Create(path))//using 手动释放资源
            //{
            //    AddText(fs, "秦伟钦能不能大方一点！扭扭捏捏的!");
            //    AddText(fs, "\n明明真的喜欢，为什么不去改变!!");
            //}
            ReadandWrite();
            Console.WriteLine("操作完成 ");
            Console.ReadKey();
        }
        public static void AddText(FileStream fs,string value)
        {
            //先把字符串转换为Byte类型的数组
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        public static void ReadandWrite()
        {
            string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile1.txt";
            //以下是写入
            //using (StreamWriter sw = File.CreateText(path))//会覆盖
            //{
            //    sw.WriteLine("想你！");
            //    sw.WriteLine("zwy");
            //}
            //using (StreamWriter sw = File.AppendText(path))//追加
            //{
            //    sw.WriteLine("想你！");
            //    sw.WriteLine("zwy");
            //}
            //以下是读取
            using (StreamReader sr = File.OpenText(path))
            {
                string str;
                str = sr.ReadToEnd();//一次性读取文本里面所有的内容
                Console.WriteLine(str);
                

                //while ((str1= sr.ReadLine())!= null)
                //{
                //    Console.WriteLine(str1);
                //}
            }
        }
    }
}
