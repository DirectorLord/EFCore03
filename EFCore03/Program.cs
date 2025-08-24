using EFCore03.Medals;
using Microsoft.EntityFrameworkCore;

namespace EFCore03;


public class Program
{
    public static void Main(string[] args)
    {
        using var context = new Context.CompanyDbContext();
        #region Inheritance mapping

        #region TBH
        //using var context = new Context.CompanyDbContext();

        //var emp1 = new Medals.Employee()
        //{
        //    Name = "John Doe",
        //    Email = "john@email.com",
        //    Address = "123 Main St"
        //};
        //var emp2 = new Medals.Employee()
        //{
        //    Name = "Ron Bon",
        //    Email = "ron@email.com",
        //    Address = "123 Main St"
        //};
        //var emp3 = new Medals.Employee()
        //{
        //    Name = "jossef bal",
        //    Email = "jossef@email.com",
        //    Address = "123 Main St"
        //};
        //var emp4 = new Medals.Employee()
        //{
        //    Name = "Allen joe",
        //    Email = "allen@email.com",
        //    Address = "123 Main St"
        //};

        //context.Employee.AddRange(emp4, emp3, emp2, emp1);

        ////context.SaveChanges();

        //foreach (var emp in context.Employee.OfType<Employee>())
        //{
        //    Console.WriteLine(emp);
        //}
        #endregion

        #region TPCC

        //using var context = new Context.CompanyDbContext();

        //var emp1 = new Medals.Employee()
        //{
        //    Name = "John Doe",
        //    Email = "john@email.com",
        //    Address = "123 Main St"
        //};
        //var emp2 = new Medals.Employee()
        //{
        //    Name = "Ron Bon",
        //    Email = "ron@email.com",
        //    Address = "123 Main St"
        //};
        //var emp3 = new Medals.Employee()
        //{
        //    Name = "jossef bal",
        //    Email = "jossef@email.com",
        //    Address = "123 Main St"
        //};
        //var emp4 = new Medals.Employee()
        //{
        //    Name = "Allen joe",
        //    Email = "allen@email.com",
        //    Address = "123 Main St"
        //};

        //context.Set<Employee>().AddRange(emp4, emp3, emp2, emp1);

        //context.SaveChanges();

        #endregion
        #endregion

        #region Adding related data


        //var dept1 = new Department { Name = "HR" };
        //var dept2 = new Department { Name = "Finance" };
        //var dept3 = new Department { Name = "IT" };

        //var emp4 = new List<Employee>
        //{
        //    new () { Name = "Kinger ", Email = "kinger.com", Address = "123 st", Department = dept2 },
        //    new () { Name = "Abel caine", Email = "abel.com", Address = "123 st", Department = dept2 },
        //    new () { Name = "Jax", Email = "jax.com", Address = "123 st", Department = dept2 },

        //};
        //dept1.Employees = emp4;

        //context.Department.Add(dept1);

        //context.SaveChanges();
        #endregion

        #region Loading related data

        #region Explicit Loading

        //var employee = context.Employee.FirstOrDefault(e => e.Id == 12);
        //var department = context.Department.First();

        //context.Entry(employee).Reference(e => e.Department).Load();

        //context.Entry(department).Collection(d => d.Employees).Load();

        #endregion

        #region Eager Loading

        var employee = context.Employee.Include("Department").FirstOrDefault();
        //var employee = context.Employee.Include("Department").ThenInclude(x => x.Department).FirstOrDefault();

        #endregion

        #region Projection
        //var employees = context.Employee
        //    .Select(e => new
        //    {
        //        e.Name,
        //        e.Email,
        //        DepartmentId = e.Department.Id
        //    }).Where( x=> x.DepartmentId==2);

        //foreach (var item in employees)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Lazy Loading

        Console.WriteLine($"Employee {employee?.Name?? "NA"} || {employee?.Department?.Name?? "NA`"}");
        #endregion

        #endregion

        #region Local / Remote

        #region Logic
        var employees = context.Employee.Where(e => e.Id > 10);
        #endregion

        #region Local
        if(employee is null)
        {
            employee = context.Employee.Local.FirstOrDefault(e => e.Id == 12);
        }
        #endregion

        #region Remote
        var emp2 = context.Employee.Find();
        #endregion
        #endregion
        Console.ReadLine();
    }
}