using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vat
    {
        public void CalTax()
        {
            Console.WriteLine("Enter the amount in double precision:");
            double amt = Convert.ToDouble(Console.ReadLine());
            double vat = 20;
            double tax = (amt * vat) / 100;
            Console.WriteLine("VAT:{0} ", tax);
        }

    }
    class Gst:Vat
    {
        public new void CalTax()
        {
            Console.WriteLine("Enter the amount in double precision:");
            double amt = Convert.ToDouble(Console.ReadLine());
            double gst = 12;
            double tax = (amt * gst) / 100;
            Console.WriteLine("Gst:{0}", tax);
        }
    }


    internal class Task3a
    {
        public static void Main(string[] args)
        {
            Vat gst = new Vat();
            gst.CalTax();
            Vat vat = new Vat();
            vat.CalTax();

        }

    }
}
