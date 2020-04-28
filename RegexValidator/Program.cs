using System;
using System.Text.RegularExpressions;

namespace RegexValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Lucas Carver";
            RegexName(myName);
            string myEmail = "carverLucas@gmail.com";
            RegexEmail(myEmail);
            string myPhone = "586-296-9546";
            RegexPhone(myPhone);
            myPhone = "5862969546";
            RegexPhone(myPhone);
            string myDate = "09/09/1992";
            RegexDate(myDate);
            string myHTML = "<b></b>";
            RegexHTML(myHTML);
        }
        public static void RegexName(string name)
        {
            if (!Regex.IsMatch(name, "^[A-Z]([A-z]| ){1,29}$"))
            {
                Console.WriteLine(name + " not validated.");
            }
            else
            {
                Console.WriteLine(name + " validated.");
            }
        }

        public static void RegexEmail(string email)
        {
            if(!Regex.IsMatch(email, "^[A-z0-9]{5,30}@[A-z0-9]{5,10}.[A-z0-9]{2,3}$"))
            {
                Console.WriteLine(email + " not validated.");
            }
            else
            {
                Console.WriteLine(email + " validated.");
            }
        }

        public static void RegexPhone(string phone)
        {
            if(!Regex.IsMatch(phone, "^([0-9]{3}-[0-9]{3}-[0-9]{4})|([0-9]{10})$"))
            {
                Console.WriteLine(phone + " not validated.");
            }
            else
            {
                Console.WriteLine(phone + " validated.");
            }
        }

        public static void RegexDate(string date)
        {
            if (!Regex.IsMatch(date, "^([0-2][0-9]|3[0-1])/(((0)[0-9])|((1)[0-2]))/\\d{4}$"))
            {
                Console.WriteLine(date + " not validated.");
            }
            else
            {
                Console.WriteLine(date + " validated.");
            }
        }

        public static void RegexHTML(string html)
        {
            if (!Regex.IsMatch(html, "^<([a-z]|[0-9])+></([a-z]|[0-9])+>"))
            {
                Console.WriteLine(html + " not validated.");
            }
            else
            {
                Console.WriteLine(html + " validated.");
            }
        }
    }
}
