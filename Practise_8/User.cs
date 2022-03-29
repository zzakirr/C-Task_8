using System;
using System.Collections.Generic;
using System.Text;

namespace Practise_8
{
    internal class User
    {
        public User(string username)
        {
            
        }
        private string _userName = "No Name" ;
        private string _password = "No Password";
        public User()
        {
            
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length>=6 && value.Length<=25 )
                {
                    _userName = value;
                    
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if(value.Length>=8 && value.Length<=25)
                {
                    if((HasDigit(value) == true || HasUpper(value) == true || HasLower(value) == true))
                    {
                        _password = value;
                    }
                    
                }
            }
        }
        public bool HasDigit(string password)
        {
            bool check = false;
            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    check = true;
                    return check;
                }
            }
            return check; 
        }
        public bool HasUpper(string password)
        {
            bool check = false;
            foreach (var item in password)
            {
                if (char.IsUpper(item))
                {
                    check = true;
                    return check;
                }
            }
            return check;
        }
        public bool HasLower(string password)
        {
            bool check = false;
            foreach (var item in password)
            {
                if (char.IsLower(item))
                {
                    check = true;
                    return check;
                }
            }
            return check;
        }
        public void GetInfo()
        {
            Console.WriteLine(_userName + " " + _password);
        }
        
    }
}
