using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Question6a
    {
        public static void Main()
        {
            ArrayList dessert = new ArrayList();
            dessert.Add("Sweets");
            dessert.Add("Cakes");
            dessert.Add("Donut");


            FileStream fs = new FileStream("D:\\Inatech Training\\Tasking\\task6\\desserts.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            foreach (object i in dessert)
                sw.WriteLine(i);
            sw.Flush();
            sw.Close();
            fs.Close();
            FileInfo info = new FileInfo("D:\\Inatech Training\\Tasking\\task6\\desserts.txt");
            Console.WriteLine("Creation time: {0}",info.CreationTime);
            Console.WriteLine("Size:{0}", info.Length);
        }
    }
}
