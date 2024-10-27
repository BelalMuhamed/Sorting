using Shared;

namespace OrderByCompare
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var ordered = employees.OrderBy(e => e, new EmployeeCompare());
            ordered.Print("Order by Comparer");
        }
    }
}
