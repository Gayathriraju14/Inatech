using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TvPack
    {
        public static void Main()
        {
            string package;
            Console.WriteLine("Package A Contains- South Special,Children's Club, Movies");
            Console.WriteLine("Package B Contains- News,Sports, Movies,Regional");
            Console.WriteLine("Package C contains- History Discovery,National");
            Console.WriteLine("Enter your package:");
            package = Console.ReadLine();
            switch(package)
            {
                case "A":Console.WriteLine("Rs 250");
                    break;
                    case "B":Console.WriteLine("Rs 450");
                        break;
                    case "C":Console.WriteLine("Rs 350");
                        break;
                    default: Console.WriteLine("Please enter your Package");
                    break;

            }
        
        }
    }
}
