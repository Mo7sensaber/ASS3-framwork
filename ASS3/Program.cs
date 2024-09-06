
using ASS3.Controller;
using ASS3.Models;

namespace ASS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyDBController appContext = new MyDBController();
            //appContext.Entry(Employees).Reference("Department").Load();
            //var employee= appContext.employees.FirstOrDefault(e=>e.Id==2);
            //Console.WriteLine(employee?.Id??0);
            //Console.WriteLine(employee?.Name??"na");
            //Console.WriteLine(employee?.Age??0);
            //Console.WriteLine(employee?.Address??"na");


            var result = appContext.employees.Join(appContext.departments, e => e.Id, d => d.Id, (e, d) => new
            {
                empName = e.Name,
                empId = d.Id,
                deptName = d.Name,
                deptId = d.Id,
            });
            foreach (var item in result)
            {
                Console.WriteLine(item);   
            }
        }
    }
}
