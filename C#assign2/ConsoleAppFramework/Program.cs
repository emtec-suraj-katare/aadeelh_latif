using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleAppFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Cal().add(3, 5));
            Console.WriteLine(new Cal().sub(5 , 3));
            Console.WriteLine(new Cal().mul(5, 3));
            Console.WriteLine(new Cal().div(5, 3));
            Console.WriteLine(ConfigurationManager.AppSettings["name"]);
            Console.ReadLine();
        }
    }
}
