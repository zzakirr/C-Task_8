using System;

namespace Practise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User adini daxil edin:");
            string username = Console.ReadLine();
            Console.WriteLine("Password-u daxil edin:");
            string password = Console.ReadLine();
            User user = new User(username)
            {
                UserName = username,
                Password = password
            };
            user.GetInfo();
           
        }
    }
}
