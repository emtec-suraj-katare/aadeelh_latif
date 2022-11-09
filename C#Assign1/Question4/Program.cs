using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        public string Name = "HDFC";
        public string City = "Sangli";

        public int bankid;
        public int citycode;

        public Bank ()
            {
            bankid = 1;
            citycode = 416416;
        }
        public void Display()
        {
            Console.WriteLine("bank name ={0}", Name);
            Console.WriteLine("citycode = {0}",citycode);
        }

        static void Main(string[] args)
        {
            int p = 100, r = 8, t = 1;
            int SI;
            string fname = "Aadeelh";
            string lname = "Latif";
            string city = "Sangli";

            Customer customer = new Customer();
            customer.Display();
            Console.WriteLine(customer.bankid);
            Console.WriteLine(customer.citycode);

            customer.Saving();
            customer.Current();
            customer.Details(fname, lname);
            //customer.Details(fname,lname,city);
            SI = customer.Intrest(p, r, t);
            Console.WriteLine(SI);

        }
    }

    class Account :Bank
    {
        public int[] AccountNumber = { 111,121,123,124};
        public int[] BalanceSaving = { 5000, 6000, 7000 ,8000};
        public int[] BalanceCurrent = {500,600,700,800 };

        public void Saving()
        {
            for (int i=0;i<AccountNumber.Length;i++)
            {
                Console.WriteLine("Account number {0} have balance {1}", AccountNumber[i], BalanceSaving[i]);
            }
        }
        public void Current()
        {
            for (int i = 0; i < AccountNumber.Length; i++)
            {
                Console.WriteLine("Account number {0} have balance {1}", AccountNumber[i], BalanceCurrent[i]);
            }
        }
    }

    class Customer : Account
    {
        public int[] CustomerId = {121,234,543,456 };

        public int Intrest(int p,int r,int t)
        {
        return(p+r+t)/100;
        }
        public void Display()
        {
            for (int i = 0; i < CustomerId.Length; i++) 
            {
                Console.WriteLine("CustomerId {0} have AccountNumber {1}",CustomerId[i], AccountNumber[i]);
            }
        }
        public void Details(string fname , string lname)
        {
            Console.WriteLine("first name {0} last name {1}", fname, lname);
        }

        //public void Detailss(string fname, string lname)
        //{
        //    Console.WriteLine("first name {0} last name {1} city {2}", fname, lname,City );
        //}
    }
}
