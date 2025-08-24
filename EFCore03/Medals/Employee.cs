using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Medals;

internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    public int? DepartmentId { get; set; }
    public virtual Department Department { get; set; }

    public override string ToString()
    {
        return $"Employee Id: {Id} || Name: {Name} || Email: {Email} || Address: {Address}";
    }
}
