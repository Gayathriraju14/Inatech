using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Question2
    {

        string mailId = "someone@noway.com";
        string password = "Please123@";
        int Pin = 1231;
        int Pin_num = 0911;
        string MembershipID = "Hello987";
        long MobileNumber = 9876543210;
        public void validate(string p1, string p2)
        {
            this.mailId = p1;
            this.password = p2;
            if (p1 == mailId && p2 == password)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect mailId or password!!!");
            }
        }
        public void validate(string p1, int p2)
        {
            this.MembershipID = p1;
            this.Pin = p2;
            if (p1 == MembershipID && p2 == Pin)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect mbId or password!!!");
            }
        }
        public void validate(long p1, int p2)
        {
            this.MobileNumber = p1;
            this.Pin_num = p2;
            if (p1 == MobileNumber && p2 == Pin_num)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password!!!");
            }
        }

        public static void Main(string[] args)
        {
            Question2 obj = new ();
            Console.WriteLine("Enter Login Credentials:");
            Console.Write("a.Login with Email id and password\t");
            Console.Write("b.Login with Membership id and pin\t");
            Console.WriteLine("c.Login with Mobile no and pin\t");
            string ch = Console.ReadLine();
            switch (ch)
            {
                case "a":
                    Console.WriteLine("Enter Email id:");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string pass = Console.ReadLine();
                    obj.validate(email, pass);
                    break;
                case "b":
                    Console.WriteLine("Enter Membership id:");
                    string Mid = Console.ReadLine();
                    Console.WriteLine("Enter pin:");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    obj.validate(Mid, pin);
                    break;
                case "c":
                    Console.WriteLine("Enter mobile number:");
                    long mb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter pin:");
                    int pin_num = Convert.ToInt32(Console.ReadLine());
                    obj.validate(mb, pin_num);

                    break;
                default:

                    break;




            }

        }
    }
}

