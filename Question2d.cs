using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Question2d
    {
        public static void Main()
        {
            float[] marks = new float[5];
            float sum = 0;
            Console.WriteLine("Enter your marks");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                sum += marks[i];

            }
            Console.WriteLine("Total:" + sum);
            float percentage = (sum / 500) * 100;
            Console.WriteLine("Percentage;" + percentage);
        }
    }
}
