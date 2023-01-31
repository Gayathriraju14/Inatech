using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Question1
    {
        public void Add2Num(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        public void Sub2Num(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
    class Question1a : Question1
    {

        public void Mul2Num(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void Div2Num(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Main()
        {
            int choice;
            Question1a obj = new Question1a();
            Console.WriteLine("Enter 2 Number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?\n1.Add\n2.Subract.\n3.Multiply.\n4.Divide");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Add2Num(a, b);
                    break;
                case 2:
                    obj.Sub2Num(a, b);
                    break;
                case 3:
                    obj.Mul2Num(a, b);
                    break;
                case 4:
                    obj.Div2Num(a, b);
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;

            }
        }
    }
}

