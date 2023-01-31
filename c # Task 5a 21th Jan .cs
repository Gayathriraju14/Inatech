using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Question5a
    {
        string Name;
        int Age;
        public Question5a()
        {
            Name = "Gayathri";
            Age = 21;
        }
        public Question5a(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public static void Main(string[] args)
        {
            Question5a dobj = new Question5a();
            Console.WriteLine(dobj.Name);
            Console.WriteLine(dobj.Age);
            Question5a bobj = new Question5a("Gayu", 22);
            Console.WriteLine(bobj.Name);
            Console.WriteLine(bobj.Age);
        }
    }
}




