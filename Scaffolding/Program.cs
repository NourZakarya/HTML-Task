using Scaffolding.Data;
using Scaffolding.Models;

namespace Scaffolding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            ApplicationDbContext context = new ApplicationDbContext();
            //var result = context.Categories.ToList();
            //foreach(var category in result)
            //{
            //    Console.WriteLine($"{category.CategoryId} , {category.CategoryName}");
            //}


            //2
            //var result = context.Products.First();
            //Console.WriteLine($"{result.ProductId} , {result.ProductName}, {result.ListPrice}");


            //3
            //var result = context.Products.Find(5);
            //Console.WriteLine($"{result.ProductId} , {result.ProductName}, {result.ListPrice}");


            //4
            //var result = context.Products.Where(e => e.ModelYear == 2018).ToList();
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductId} , {product.ProductName}, {product.ModelYear}");
            //}


            //5
            //var result = context.Customers.Find(100);
            //Console.WriteLine($"{result.CustomerId} , {result.FirstName} , {result.LastName}");


            //6
            //var result = context.Products.Select(e => new { e.ProductName, e.Brand.BrandName }).ToList();
            //foreach(var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} , {product.BrandName}");
            //}


            //7
            //var result = context.Products.Count(e => e.CategoryId == 1);
            //Console.WriteLine(result);


            //8
            //var result = context.Products.Where(e => e.CategoryId == 1).Sum(e => e.ListPrice);
            //Console.WriteLine(result);


            //9
            var result = context.Products.Average(e => e.ListPrice);
            Console.WriteLine(result);


            //10
            //var result = context.Orders.Where(e => e.OrderStatus == 4).ToList();
            //foreach(var order in result)
            //{
            //    Console.WriteLine($"{order.OrderId} , {order.OrderItems} , {order.OrderStatus}");
            //}


        }
    }
}