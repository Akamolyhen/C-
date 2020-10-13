using System;
using System.Collections.Generic;

namespace 学生管理系统
{
    public class Tool
    {
        public Tool()
        {
        }
        public static void Dorank(Dictionary<string, Student> dicStudentInfor)
        {
            List<Student> list = new List<Student>();
            foreach(var item in dicStudentInfor.Values)
            {
                //遍历完后，所有的学生信息就存在与list里面了
                list.Add(item);
            }
            //对list里面的数据根据平均分排序
            Student temp;
            for(int i=0;i<list.Count-1;i++)
            {
                for(int j=0;j<list.Count-1-i;j++)
                {
                    if(list[j].AveScore<list[j+1].AveScore)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            for(int i=0;i<list.Count;i++)
            {
                string stunum = list[i].Num;
                StuManager.Instance.DicStudentInfor[stunum].Rank = i + 1;
            }
        }
        public static float GetClassAveScore()
        {
            float sum = 0;
            float avescore = 0;
            int count = 0;
            foreach(Student stu in StuManager.Instance.DicStudentInfor.Values)
            {
                sum += stu.AveScore;
                count++;
            }
            avescore = (float)Math.Round(sum / count, 2, MidpointRounding.AwayFromZero);
            return avescore;
        }
        public static float GetClassjige()
        {
            int count = 0;
            foreach(Student stu in StuManager.Instance.DicStudentInfor.Values)
            {
                if(stu.AveScore>=90)
                {
                    count++;
                }
            }
            float jigelv = (float)Math.Round((float)(count / StuManager.Instance.DicStudentInfor.Count), 2, MidpointRounding.AwayFromZero);
            return jigelv;
        }

    }
}
