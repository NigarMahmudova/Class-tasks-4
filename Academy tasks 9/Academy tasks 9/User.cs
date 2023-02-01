using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_9
{
    class User
    {
        public string UserName;
        private string _passWord;
        public string PassWord
        {
            set
            {
                if (CheckPassword(value))
                {
                    _passWord = value;
                   
                }
            }
            get => _passWord;
        }

        static public bool CheckPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                return false;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (!Char.IsDigit(password[i]) )
                {
                    return false;
                }
            }
            return true;
        }
    }
}
