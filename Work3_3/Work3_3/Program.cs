using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentName = new List<Student>();
            studentName.Add(new Student() { Age = 22, Num = 575757, Name = "王小二" });
            studentName.Add(new Student() { Age = 52, Num = 867686, Name = "张三" });
            studentName.Add(new Student() { Age = 182, Num = 235654, Name = "李四" });
            studentName.Add(new Student() { Age = 172, Num = 434446, Name = "马武" });
            studentName.Add(new Student() { Age = 182, Num = 632366, Name = "龙刘" });
            studentName.Sort(new NameSort());
            Console.WriteLine("按名字排序");
            foreach (Student n in studentName)
                Console.WriteLine(n);
            Console.WriteLine("按年龄排序");
            studentName.Sort(new AgeSort());
            foreach (Student n in studentName)
                Console.WriteLine(n);
            Console.WriteLine("按学号排序");
            studentName.Sort(new NumSort());
            foreach (Student n in studentName)
                Console.WriteLine(n);
        }
    }
    class NameSort : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);

        }
    }
    class AgeSort : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
    class NumSort : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Num.CompareTo(y.Num);
        }
    }

    class Student
    {
        private string name;
        private int age;
        private int num;
        #region 属性
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }
        #endregion
        public override string ToString()
        {
            return "name:" + name + " age:" + age + " num:" + num;
        }

    }
}
