using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_9
{
    class Student
    {
        public Student()
        {
            Count++;
            this.No = Count;
        }
        public string FullName;
        public int Point;
        public static int Count;
        public int No;
    }
}
