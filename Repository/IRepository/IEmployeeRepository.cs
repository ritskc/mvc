using mvc.Models;

namespace mvc.Repository.IRepository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();

        Employee AddEmployee(Employee employee);
    }
}
