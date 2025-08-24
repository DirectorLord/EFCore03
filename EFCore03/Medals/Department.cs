
namespace EFCore03.Medals;

internal class Department
{
    public int Id{ get; set; }
    public string Name{ get; set; } = default!;
    public ICollection<Employee> Employees { get; set; } = [];
}
