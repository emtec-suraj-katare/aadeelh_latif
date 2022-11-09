using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Assignments
{

    //1.	Write a C# program that performs all string operations like COMPARE, CONCAT, SUBSTRING, REVERSE using – 
    //       a.Manual Array operations for character array ‘char[]’
    //        b.Built-in functions for ‘string’ variables

    public class Question1
    {
        public string display()
        {
            string strA = "Hello! ";
            string strB = "Aadeelh";
            string str = String.Concat(strA, strB);
            return str;
        }
        public bool display2()
        {
            string strA = "Hello! ";
            string strB = "Aadeelh";
            int str = string.Compare(strA, strB);
            if (str == -1)
                return false;
            else
                return true;
        }

        public string display3()
        {
            string str = "AadeelhLatif";
            string newstr = str.Substring(6);
            return newstr;
        }

        public string display4()
        {
            string str = "AadeelhLatif";
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

}
