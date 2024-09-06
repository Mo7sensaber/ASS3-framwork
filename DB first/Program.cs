using DB_first.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DB_first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context= new AppDbContext();
            //var result=context.Categories.ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}
            context.Database.ExecuteSqlRaw("select UnitsInStock  from  Products where productId>1   ");
        }
    }
}
