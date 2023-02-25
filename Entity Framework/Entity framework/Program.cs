using EntitFrame.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntitFrame
{
    internal class Program
    {

        //        public static void InsertProduct()
        //        {
        //            using(var dbcon = new ProdContext())
        //            {
        //                Product product = new Product();
        //                product.Name = "Liril";
        //                dbcon.Products.Add(product);
        //                product = new Product();
        //                product.Name = "Margo";
        //                dbcon.Add(product);
        //                dbcon.SaveChanges();


        //            }
        //            return;
        //        }


        //            public static void InsertBatch()
        //        {
        //            using (var dbcon = new ProdContext())
        //            {
        //                ProductBatch productBatch = new ProductBatch();
        //                productBatch.BatchID = 1;
        //                productBatch.price = 100;
        //                productBatch.description = "Skin care for all ages";
        //                productBatch.Product.Id = 2;
        //                productBatch.quantity = 100;
        //                dbcon.SaveChanges();

        //            }

        //            //    public static void ReadProduct()
        //            //{ 

        //                //List<Product> prads = dbcon.Products.ToList();
        //                //foreach(Product pr in prads)

        //                //u can comment list line and add foreach(Product pr in dbcon.Product)
        //                //{
        //                //    Console.WriteLine(pr.Name + " " + pr.Id);
        //                //}
        //            }
        //        }
        //        //public static void UpdateProduct()
        //        //{
        //        //    using(var dbcon = new ProdContext())
        //        //    {
        //        //        Product ? prads = dbcon.Products.Find(1);
        //        //        prads.Name = "Dove";
        //        //        dbcon.SaveChanges();
        //        //    }
        //        public static void DeleteProduct()
        //        {
        //            using (var dbcon = new ProdContext())
        //            {
        //                Product? prod = dbcon.Products.Find(2);
        //                dbcon.Products.Remove(prod);
        //                dbcon.SaveChanges();

        //            }
        //        }

        //public static void InsertStandard()
        //{
        //    using (var dbcon = new ProdContext())
        //    {
        //        Standard standard = new Standard();
        //        standard.StandardName = "10";
        //        dbcon.Add(standard);
        //        dbcon.SaveChanges();
        //        standard = new Standard();
        //        standard.StandardName = "11";

        //        dbcon.Add(standard);
        //        dbcon.SaveChanges();

        //    }
        //}
        //public static void InsertStudent()

        //    {
        //    using(var dbcon = new ProdContext())
        //    {
        //        student student= new student();
        //        student.Name ="gayathri";
        //        student.StandarRefId= 1;

        //        dbcon.Add(student);
        //            dbcon.SaveChanges();
        //        student = new student();
        //        student.Name = "Gokul";
        //        student.StandarRefId= 2;
        //        dbcon.Add(student);
        //        dbcon.SaveChanges();

        //    }



        //    }




        //}
        public static void InsertStandard()
        {
            using (var dbs = new ProdContext())
            {
                Standard std = new Standard();
                std.StandardName = "First Year";
                dbs.Add(std);
                dbs.SaveChanges();
                std = new Standard();
                std.StandardName = "Second Year";
                dbs.Add(std);
                dbs.SaveChanges();
                std = new Standard();
                std.StandardName = "Third Year";
                dbs.Add(std);
                dbs.SaveChanges();
                std = new Standard();
                std.StandardName = "Final Year";
                dbs.Add(std);
                dbs.SaveChanges();
            }
        }
        public static void InsertStudent()
        {
            using (var dbs = new ProdContext())
            {
                student stu = new student();
                stu.Name = "Ram";
                stu.StandarRefId = 1;
                dbs.Add(stu);
                
                stu = new student();
                stu.Name = "Sai";
                stu.StandarRefId = 2;
                dbs.Add(stu);
               
                stu = new student();
                stu.Name = "Sita";
                stu.StandarRefId = 3;
                dbs.Add(stu);
               
                stu = new student();
                stu.Name = "Lakhan";
                stu.StandarRefId = 4;
                dbs.Add(stu);
                dbs.SaveChanges();
            }
            return;
        }

        public static void Main(string[] args)
        {
            InsertStandard();
            InsertStudent();
            //UpdateProduct();//


            Console.WriteLine("Sucess");
        }
    }
}

        //    }
        //}
    

