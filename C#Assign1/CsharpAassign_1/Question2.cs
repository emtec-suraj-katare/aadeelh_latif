using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Mail;
using System.Text;

namespace Assignments
{
    //2.	Write a C# program to validate an Email ID using – 
    //    a.Custom logic with loop & conditions



    public class Question2
    {
        public string display(string email)
        {
            Console.WriteLine($"The email is {email}");
            var mail = new MailAddress(email);
            bool isValid = mail.Host.Contains(".");
            if (!isValid)
                return "Email is InValid";
            else
                return "Email is Valid";
        }
    }
}
