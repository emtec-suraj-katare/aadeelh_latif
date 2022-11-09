using System;

namespace Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------Question1-------------");
            Question1 q1 = new Question1();
            string r1 = q1.display();
            Console.WriteLine(r1);

            bool r2 = q1.display2();
            Console.WriteLine(r2);

            string r3 = q1.display3();
            Console.WriteLine(r3);

            string r4 = q1.display4();
            Console.WriteLine(r4);
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("------------------Question2-------------");

            Question2 q2 = new Question2();
            string r5 = q2.display("aadeelh@gmail.com");
            Console.WriteLine(r5);

            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("------------------Question3-------------");
            Question3 q3 = new Question3();
            q3.display();

           



        }
    }
}
