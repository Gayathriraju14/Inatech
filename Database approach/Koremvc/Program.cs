using Koremvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Koremvc
{
    internal class Program
    {
        public static void InsertDepartment()
        {
            using (var dbs = new NewProcessContext())
            {
                Department department = new Department();
                department.DepartmentName = "ECE";
                dbs.Add(department);
                // department.DepartmentId = 1;
                //  dbs.Add(department); u should a not enter a the primary key in the code///
                department = new Department();
                department.DepartmentName = "CS";
             //   department.DepartmentId = 2;
                dbs.Add(department);
                dbs.SaveChanges();
            }
            //public static void InsertEmployee()
            //{
            //    using (var dbs = new P)
            //}
        }
        public static void Main(string[] args)
        {
            InsertDepartment();


        }
    }
}
