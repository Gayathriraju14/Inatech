using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public abstract class Question4a
    {
        public abstract void membership();

    }
    public class Silver_Question4a : Question4a

    {
        public override void membership()
        {
            Console.WriteLine("3 days accomodation at resort");
        }
    }
    public class Gold_Question4a : Question4a
    {
        public override void membership()
        {
            Console.WriteLine("5 days accomodation at resort and 2 dinners at house");
        }
    }
    public class Platinum_Question4a : Question4a
    {
        public override void membership()
        {
            Console.WriteLine("7 days accomodation at resort and 5 dinners at house");
        }
    }
    public class Question4aImplementation
    {
        public static void Main(string[] args)
        {
            Question4aImplementation m1 = new Question4aImplementation();
            string membership_choice = "";
            Console.WriteLine("Enter the membership choice either silver,gold,platinum");
            membership_choice =Console.ReadLine();

            Question4a membership;
            switch (membership_choice)
            {
                case "silver":
                    membership = new Silver_Question4a();
                    break;
                case "gold":
                    membership = new Gold_Question4a();
                    break;
                case "platinum":
                    membership = new Platinum_Question4a();
                    break;
                default:
                    Console.WriteLine("Invalid membership choice");
                    return;
            }
            membership.membership();
        }
    }
}
