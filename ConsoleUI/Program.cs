
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EfProductDal efProductDal = new EfProductDal();
            Product product1 = new Product { Name ="Su",BrandId=1,CategoryId=1,Price=1,CreateDate=DateTime.Now,Code="WTR0",Active=true };
            //efProductDal.Add(product1);

            //foreach (var product in efProductDal.GetAll())
            //{
            //    Console.WriteLine(product.Name);
            //}
        }

        

       
    }
}
