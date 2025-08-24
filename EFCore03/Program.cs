using EFCore03.Medals;

namespace EFCore03;


public class Program
{
    public static void Main(string[] args)
    {
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

        #endregion
        Console.ReadLine();
    }
}