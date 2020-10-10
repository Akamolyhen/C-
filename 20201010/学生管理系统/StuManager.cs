using System;
using System.Collections.Generic;

namespace 学生管理系统
{
    public class StuManager
    {
        #region 学生管理的单例模式

        private static StuManager instance;//使用属性来包装字段

        private StuManager()
        {
        }

        public static StuManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new StuManager();
                return instance;
            }
        }

        
        #endregion

        private Dictionary<string, Student> dicStudentInfor = new Dictionary<string, Student>();
        public Dictionary<string, Student> DicStudentInfor
        { get => dicStudentInfor;  }
        //对外提供添加学生信息的方法
        public void AddStudentInfor(Student stu)
        {
            if(!dicStudentInfor.ContainsKey(stu.Num))
            {
                dicStudentInfor.Add(stu.Num, stu);
            }
            else
            {
                Console.WriteLine("已存在该学生");
            }
        }
    }
}
