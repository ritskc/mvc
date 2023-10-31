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
                new Employee() { Id = 1,Name="Rohit", Department=Dept.Batman,Email = "rohit@bcci.com"},
                new Employee() { Id = 2,Name="Shubhman", Department=Dept.Batman,Email = "shubhman@bcci.com"},
                new Employee() { Id = 3,Name="Virat", Department=Dept.Batman,Email = "virat@bcci.com"},
                new Employee() { Id = 4,Name="Shreyas", Department=Dept.Batman,Email = "shreyas@bcci.com"},               
                new Employee() { Id = 5,Name="KL Rahul", Department=Dept.Keeper,Email = "rahul@bcci.com"},
                new Employee() { Id = 6,Name="Surya", Department=Dept.Batman,Email = "surya@bcci.com"},
                new Employee() { Id = 7,Name="Hardik", Department=Dept.AllRounder,Email = "hardik@bcci.com"},
                new Employee() { Id = 8,Name="Jadeja", Department=Dept.AllRounder,Email = "jadeja@bcci.com"},                
                new Employee() { Id = 9,Name="Kuldeep", Department=Dept.Bowler,Email = "kuldeep@bcci.com"},
                new Employee() { Id = 10,Name="Shami", Department=Dept.Bowler,Email = "shami@bcci.com"},
                new Employee() { Id = 11,Name="Jasprit", Department=Dept.Bowler,Email = "jasprit@bcci.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employees;
        }

        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }
    }
}
