using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Encapsulation
{
    internal class User
    {
        public string Username { get; set; }
        private string _password;
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Menfi yash olmur.");
                    return;
                }
                _age = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Shifre hissesi bosh ola bilmez.");
                    return;
                }

                else if (value.Length < 8)
                {
                    Console.WriteLine("Shifrenin uzunlugu 8 herfden kicik ola bilmez.");
                    return;
                }
                else
                {
                    if (!checkCapital(value))
                    {
                        Console.WriteLine("Shifre icinde en az 1 boyuk herf olmalidir.");
                        return;
                    }
                    if (!checkNum(value))
                    {
                        Console.WriteLine("Shifre icinde en az 1 reqem olmalidir");
                        return;
                    }
                }
                _password = value;
            }
        }



        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(string username, string password, int age)
        {
            Username = username;
            Password=password;
            Age = age;
        }



        private bool checkCapital(string password)
        {
            foreach (char c in password)
            {
                if (char.IsLetter(c) && char.IsUpper(c))
                    return true;
            }
            return false;
        }
        private bool checkNum(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetter(c))
                    return true;
            }
            return false;
        }
    }
}