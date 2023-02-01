using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Student
    {
        static int _count;
        public Student()
        {
            _count++;
            this.Id = _count;
        }

        public int Id;
        public string Name;
        string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4)
            {
                return false;
            }
            if (!Char.IsUpper(groupNo[0]))
            {
                return false;
            }
            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!Char.IsDigit(groupNo[i]))
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
