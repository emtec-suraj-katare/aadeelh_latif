using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
namespace Assignments
{

    //Write a C# program that demonstrates the use of Enums for countries – INDIA, AUSTRALIA, USA, JAPAN, FRANCE, ENGLAND


    enum countries
    {
        INDIA,
        AUSTRALIA,
        USA,
        JAPAN,
        FRANCE,
        ENGLAND
    }
    public class Question3
    {
        public void display()
        {
            Console.WriteLine("The value of INDIA " +
                         "enum is " + (int)countries.INDIA);
            Console.WriteLine("The value of AUSTRALIA " +
                              "enum is " + (int)countries.AUSTRALIA);
            Console.WriteLine("The value of   USA " +
                              "enum is " + (int)countries.USA);
            Console.WriteLine("The value of JAPAN " +
                              "enum is " + (int)countries.JAPAN);
            Console.WriteLine("The value of FRANCE " +
                              "enum is " + (int)countries.FRANCE);
            Console.WriteLine("The value of ENGLAND " +
                              "enum is " + (int)countries.ENGLAND);

        }
    }
}
