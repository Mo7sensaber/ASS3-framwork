using inheritance_Example.Context;
using inheritance_Example.Entities;
namespace inheritance_Example
{
    internal class Program
    {
        static void Main()
        {
            Context.AppContext appContext = new Context.AppContext();
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Name = "mohsen",
            //    Address = "giza",
            //    Email = "mohsen@gamil",
            //    Salary = 500
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "mayar",
            //    Address = "hadayk elKopa",
            //    Email = "MayarMyLove@gmail.com",
            //    HourRate = 5,
            //    NumberOfHour = 2
            //};
            //appContext.PartTimeEmployees.Add(partTimeEmployee);
            //appContext.SaveChanges();




            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name="saber",
            //    Address="Cairo",
            //    Email="saber@gmail.com"
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "mahmoud",
            //    Address = "alex",
            //    Email = "al@gmail",
            //    HourRate = 200,
            //    NumberOfHour = 10
            //};
            //appContext.Employees.Add(partTimeEmployee);
            //appContext.SaveChanges();




        }
    }
}
