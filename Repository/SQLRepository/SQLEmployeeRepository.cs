using mvc.Models;
using mvc.Repository.IRepository;

namespace mvc.Repository.SQLRepository
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        public readonly AppDbContext context;
        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }

       

        public Employee AddEmployee(Employee employee)
        {
            this.context.Employees.Add(employee);
            this.context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = this.context.Employees.SingleOrDefault(e => e.Id == id);
            if(employee != null)
            {
                this.context.Employees.Remove(employee);
                this.context.SaveChanges();
            }

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.context.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return this.context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee UpdateEmployee(Employee updatedEmployee)
        {
            var employee = this.context.Employees.Attach(updatedEmployee);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.context.SaveChanges();

            return updatedEmployee;
        }
    }
}
