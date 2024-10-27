
using Shared;

namespace OrderBy

{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = Repository.LoadEmployees();
            var OrderByEmployee = from employee in employees
                                  orderby employee.Salary
                                  select employee;
            OrderByEmployee.Print("Employee order by Query ");
        }
    }
}
