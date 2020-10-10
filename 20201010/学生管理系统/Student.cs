using System;
namespace 学生管理系统
{
    public class Student
    {
        private string name;
        private string num;
        private float mathScore;
        private float englishScore;
        private float chineseScore;
        private float aveScore;
        private int rank;
        public Student()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Num  { get => num;  set => num = value; }
        public float MathScore { get => mathScore; set => mathScore = value; }
        public float EnglishScore { get => englishScore; set => englishScore = value; }
        public float ChineseScore { get => chineseScore; set => chineseScore = value; }
        public int Rank { get => rank; set => rank = value; }
        public float AveScore { get => aveScore; set => aveScore = value; }
    }
}
