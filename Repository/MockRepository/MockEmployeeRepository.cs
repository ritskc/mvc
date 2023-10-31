using mvc.Models;
using mvc.Repository.IRepository;

namespace mvc.Repository.MockRepository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public MockEmployeeRepository()
        {
            _employees = new List<Employee>()
            {
                new Employee() { Id = 1,Name="Rohit", Department=Dept.Batsman,Email = "rohit@bcci.com"},
                new Employee() { Id = 2,Name="Shubhman", Department=Dept.Batsman,Email = "shubhman@bcci.com"},
                new Employee() { Id = 3,Name="Virat", Department=Dept.Batsman,Email = "virat@bcci.com"},
                new Employee() { Id = 4,Name="Shreyas", Department=Dept.Batsman,Email = "shreyas@bcci.com"},               
                new Employee() { Id = 5,Name="KL Rahul", Department=Dept.Keeper,Email = "rahul@bcci.com"},
                new Employee() { Id = 6,Name="Surya", Department=Dept.Batsman,Email = "surya@bcci.com"},
                new Employee() { Id = 7,Name="Hardik", Department=Dept.AllRounder,Email = "hardik@bcci.com"},
                new Employee() { Id = 8,Name="Jadeja", Department=Dept.AllRounder,Email = "jadeja@bcci.com"},                
                new Employee() { Id = 9,Name="Kuldeep", Department=Dept.Bowler,Email = "kuldeep@bcci.com"},
                new Employee() { Id = 10,Name="Shami", Department=Dept.Bowler,Email = "shami@bcci.com"},
                new Employee() { Id = 11,Name="Jasprit", Department=Dept.Bowler,Email = "jasprit@bcci.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee Get(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }

        Employee IEmployeeRepository.Delete(int id)
        {
           var employee = _employees.FirstOrDefault(x => x.Id == id);
           if(employee != null)
                _employees.Remove(employee);

            return employee;
        }

        Employee IEmployeeRepository.Update(Employee updateEmployee)
        {
            var employee = _employees.FirstOrDefault(x => x.Id == updateEmployee.Id);
            if (employee != null)
            {
                employee = updateEmployee;
            }
            return employee;
        }
    }
}
