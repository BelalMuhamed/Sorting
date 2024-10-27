using Shared;

namespace ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = Repository.LoadEmployees();
            var OrderByEmployee = employees.OrderBy(e => e.Salary).ThenByDescending(e=> e.Name);
            OrderByEmployee.Print("Employee order by Query ");
        }
    }
}
