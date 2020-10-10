using System;

namespace 学生管理系统
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowWelcome();
            Console.ReadKey();
        }
        public static void ShowWelcome()
        {
            Console.WriteLine("**************欢迎进入学生管理系统**************");
            Console.WriteLine("                    菜单                     ");
            Console.WriteLine("                1、输入成绩                   ");
            Console.WriteLine("                2、查看成绩及成绩排序          ");
            Console.WriteLine("                3、查询学生成绩               ");
            Console.WriteLine("                4、成绩统计                  ");
            Console.WriteLine("                5、修改成绩                  ");
            Console.WriteLine("                6、添加成绩                  ");
            Console.WriteLine("                7、保存成绩                  ");
            Console.WriteLine("                8、退出系统                  ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("请输入你的选择");
            JudgeByinput();
        }
        public static void InputInfor()
        {
            Console.WriteLine("请输入学生人数：");
            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine($"请输入第{i+1}个学生的学号与姓名,用空格来分开");
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');//根据空格来分开
                Student stu = new Student();
                stu.Num = inputArr[0];
                stu.Name = inputArr[1];
                Console.WriteLine("请分别输入该学生的数学，英语，语文成绩，用空格分开");
                string inputScore = Console.ReadLine();
                string[] ScoreArr = inputScore.Split(' ');
                stu.MathScore = float.Parse(ScoreArr[0]);
                stu.EnglishScore = float.Parse(ScoreArr[1]);
                stu.ChineseScore = float.Parse(ScoreArr[2]);
                float avescore = (stu.ChineseScore + stu.EnglishScore + stu.MathScore) / 3;
                stu.AveScore = (float)Math.Round(avescore, 2, MidpointRounding.AwayFromZero);
                StuManager.Instance.AddStudentInfor(stu);
            }
            //每次录入完全部学生信息后，都要根据平均分来排名
            Tool.Dorank(StuManager.Instance.DicStudentInfor);
            Console.WriteLine("学生信息录入完毕");
            ShowWelcome();
        }
        public static void InforShow()
        {
            foreach(Student stu in StuManager.Instance.DicStudentInfor.Values)
            {
                Console.WriteLine($"姓名：{stu.Name}\t学号：{stu.Num}\t排名：{stu.Rank}\t平均分：{stu.AveScore}");
            }
            ShowWelcome();
        }
        public static void Showstu(string num)
        {
            if(StuManager.Instance.DicStudentInfor==null)
            {
                Console.WriteLine("请先录入学生信息");
                ShowWelcome();
                return;
            }    
            foreach (Student stu in StuManager.Instance.DicStudentInfor.Values)
            {
                if(num==stu.Num)
                {
                    Console.WriteLine($"该生成绩为数学:{stu.MathScore}英语:{stu.EnglishScore}语文:{stu.ChineseScore}");
                }
                else
                    Console.WriteLine("该生不存在");
            }
            ShowWelcome();
        }
        public static void Tongji()
        {

        }
        public static void JudgeByinput()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    InputInfor();
                    break;
                case "2":
                    InforShow();
                    break;
                case "3":
                    Console.WriteLine("请输入该生学号");
                    string num = Console.ReadLine();
                    Showstu(num);
                    break;
                case "4":
                    Tongji();
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                default:
                    break;
            }
        }
    }
}
