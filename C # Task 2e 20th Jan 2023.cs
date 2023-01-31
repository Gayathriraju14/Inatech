using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Question2c
    {
        public static void Main()
        {
            string[][] table= new string[4][];
            table[0] = new string[3] {"List","Product","No.of.items"};
            table[1] = new string[3] { "a", "Buiscuits", "There are 4 items" };
            table[2] = new string[3] { "b", "Chocolates", "There are 5 items" };
            table[3] = new string[3] { "c", "Drinks",     "There are 6 items" };
            
            
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    Console.Write(table[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    
    }
}

