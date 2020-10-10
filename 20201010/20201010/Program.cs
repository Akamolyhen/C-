using System;
using System.IO;
using System.Text;

namespace _20201010
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 创建文件Create
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //File.Create(path);//在指定路径下面创建一个文件，会把同名文件给覆盖掉
            #endregion

            #region 删除文件Delete
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //File.Delete(path);//删除指定路径下面的文件，如果此路径下没有该文件，不会报错
            #endregion

            #region 查看该文件是否存在Exists
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //bool result=File.Exists(path);
            //Console.WriteLine(result);
            #endregion

            #region 获取文件的创建日期GetCreationTime，访问日期GetLastAccessTime，和写入日期GetLastWriteTime
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //DateTime dt1 = File.GetCreationTime(path);
            //Console.WriteLine("该文件的创建时间"+dt1);
            //DateTime dt2 = File.GetLastAccessTime(path);
            //Console.WriteLine("上次访问该文件的时间"+dt2);
            //DateTime dt3 = File.GetLastWriteTime(path);
            //Console.WriteLine("上次写入该文件的时间"+dt3);
            #endregion

            #region 文件的移动
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //string newpath = @"/Users/aka_captain/Desktop/C#练习文件/备注文件夹/Myfile111.txt";
            //File.Move(path, newpath);
            #endregion//注意：如果此路径下已有该文件已有该文件，则会报错

            #region 复制文件copy

            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile111.txt";
            //string newpath = @"/Users/aka_captain/Desktop/C#练习文件/备注文件夹/Myfile.txt";
            //File.Copy(path, newpath);//如果有同名文件则会报错
            //File.Copy(path, newpath);//如果有同名文件则会覆盖掉
            #endregion

            #region 读取文件重的内容（一行一行的读取）ReadAllLines

            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile111.txt";
            //string[] arr = File.ReadAllLines(path);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region 读取文件中的内容（一次性全部读取）ReadAllText

            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile111.txt";
            //string arr = File.ReadAllText(path);
            //Console.WriteLine(arr);
            #endregion

            #region 写入文本文件，会覆盖原来的内容

            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile111.txt";
            //string str = "hello world!";
            //File.WriteAllText(path, str, Encoding.UTF8);//要规定文本格式
            #endregion

            #region 把一个数组写入文本文件，会覆盖原来的内容

            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile111.txt";
            //string[] arr = new string[] { "zwy", "qwq", "会在一起的！" };
            //File.WriteAllLines(path, arr);
            #endregion


            ////创建一个文件
            ////如果有该文件就把它覆盖掉
            ////往文件里面去写入字符串
            //string path = @"/Users/aka_captain/Desktop/C#练习文件/MyFile.txt";
            //File.Create(path);//在指定路径下面创建一个文件，会把同名文件给覆盖掉
            //File.AppendAllText(path, "秦伟钦你能不能大方一点，扭扭捏捏的");
            //注意：创建文件需要时间，所以需要用文件流去实现
            Console.WriteLine("操作完成");
            Console.ReadKey();

        }
    }
}
