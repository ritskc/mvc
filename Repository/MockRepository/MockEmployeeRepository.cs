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
                new Employee() { Id = 1,Name="Rohit", Department="Batsman",Email = "rohit@bcci.com"},
                new Employee() { Id = 2,Name="Shubhman", Department="Batsman",Email = "shubhman@bcci.com"},
                new Employee() { Id = 3,Name="Virat", Department="Batsman",Email = "virat@bcci.com"},
                new Employee() { Id = 4,Name="Shreyas", Department="Batsman",Email = "shreyas@bcci.com"},               
                new Employee() { Id = 5,Name="KL Rahul", Department="Keeper",Email = "rahul@bcci.com"},
                new Employee() { Id = 6,Name="Surya", Department="Batsman",Email = "surya@bcci.com"},
                new Employee() { Id = 7,Name="Hardik", Department="AllRounder",Email = "hardik@bcci.com"},
                new Employee() { Id = 8,Name="Jadeja", Department="AllRounder",Email = "jadeja@bcci.com"},                
                new Employee() { Id = 9,Name="Kuldeep", Department="Bowler",Email = "kuldeep@bcci.com"},
                new Employee() { Id = 10,Name="Shami", Department="Bowler",Email = "shami@bcci.com"},
                new Employee() { Id = 11,Name="Jasprit", Department="Bowler",Email = "jasprit@bcci.com"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }
    }
}
