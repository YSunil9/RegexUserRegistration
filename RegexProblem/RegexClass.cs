using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class RegexClass
    {
        public void Name(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                return;
            }
            Console.WriteLine(name + " is a invalid Name");
        }
        public void Email(string id)
        {
            const string mailId = "^[a-zA-z0-9]+[.]{0,1}[a-zA-z0-9]+([@]?)+[a-z]{1,15}[.]+(com|co)+((.in)*)$";
            if (Regex.IsMatch(id, mailId))
            {
                Console.WriteLine(id + " is valid Email");
                return;
            }
            Console.WriteLine(id + " is invalid Email");
        }
        public void Mobile(string number)
        {
            const string numberRegex = "^(91 )[6-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(number, numberRegex))
            {
                Console.WriteLine(number + " is a valid Number");
                return;
            }
            Console.WriteLine(number + " is a invalid Number");
        }
        public void Password(string password)
        {
            //const string passwordRegex = "^[A-z]{8,}$";
            //const string passwordRegex = "^((?=.*[A-Z])(?=.*[a-z])).{8,}$";
            //const string passwordRegex = "^((?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])).{8,}$";
            const string passwordRegex = "^((?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%&])).{8,}$";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is valid Password");
                return;
            }
            Console.WriteLine(password + " is invalid Password");
        }
        public void EmailSample()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex1 = new Regex(emailFormat);
            if (regex1.IsMatch(email))
            {
                Console.Write(email + " is Valid \n");
            }
            else
            {
                Console.Write("Email Is Invalid!\nPlease Enter Email ID in Proper Format \n");
            }
        }
    }
}
