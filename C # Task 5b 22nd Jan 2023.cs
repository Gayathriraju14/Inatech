using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Question5b
    {
        double sal, bonus;
        
            public void sales (double s)
        {
            this.sal = s;
            double bonus = (sal * 20) / 100;
            double total = sal * bonus;
            Console.WriteLine("Employee salary:{0}", sal);
            Console.WriteLine("Employee bonus:{0}", bonus);
            Console.WriteLine("Employee total salary:{0}", total);


        }
        public void Production(double s)
        {
            this.sal = s;
            double bonus= (sal * 20) / 100;
            double total = sal * bonus;
            Console.WriteLine("Employee salary:{0}", sal);
            Console.WriteLine("Employee Bonus:{0}", bonus);
            Console.WriteLine("Employee toytal salary:{0}", total);

        }
        

    }
    class Employment:Question5b
    {
        public static void Main(string[] args)
        {
            Question5b obj= new Question5b();
            Console.WriteLine("Enter ID");
            int ID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Gender:");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter your experience:");
            int Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your Department:");
            Console.WriteLine("1.Sales and Marketing");
            Console.WriteLine("2.Production and Department");
            int ch=Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 0: Console.WriteLine("**************************");
                    Console.WriteLine("ID:{0}",ID);
                    Console.WriteLine("name:{0}",name);
                    Console.WriteLine("Gender:{0}", gender);
                    Console.WriteLine("experience:{0}", Experience);
                    obj.sales(s);
                    break;


                    case 1: Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
                    Console.WriteLine("ID:{0}", ID);
                    Console.WriteLine("name:{0}", name);
                    Console.WriteLine("Gender:{0}",gender);
                    Console.WriteLine("experience:{0}", Experience);
                    obj.Production(s);
                    break;
            }

        }
    }
}
