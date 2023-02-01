using System;

namespace Academy_tasks_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userName;
            string passWord;
            Console.WriteLine("Username daxil edin: ");
            userName = Console.ReadLine();
            do
            {
                Console.WriteLine("Password daxil edin: ");
                passWord = Console.ReadLine();

            } while (User.CheckPassword(passWord));
            User user = new User()
            {
                UserName = userName,
                PassWord = passWord
            };
        }

    }
}
