using System;
using System.Configuration;
namespace ConsoleAppCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(ConfigurationManager.AppSettings["fname"]);
            Console.ReadLine();
        }
    }
}
