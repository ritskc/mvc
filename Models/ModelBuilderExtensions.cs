using Microsoft.EntityFrameworkCore;

namespace mvc.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                 new Employee() { Id = 1, Name = "Rohit Sharma", Department = Dept.Batsman, Email = "rohit@bcci.com", PhotoPath="" },
                new Employee() { Id = 2, Name = "Shubhman Gill", Department = Dept.Batsman, Email = "shubhman@bcci.com", PhotoPath = "" },
                new Employee() { Id = 3, Name = "Virat Kohli", Department = Dept.Batsman, Email = "virat@bcci.com", PhotoPath = "" },
                new Employee() { Id = 4, Name = "Shreyas Iyyer", Department = Dept.Batsman, Email = "shreyas@bcci.com, PhotoPath=\"\" " },
                new Employee() { Id = 5, Name = "KL Rahul", Department = Dept.Keeper, Email = "rahul@bcci.com", PhotoPath = "" },
                new Employee() { Id = 6, Name = "Surya Yadav", Department = Dept.Batsman, Email = "surya@bcci.com", PhotoPath = "" },
                new Employee() { Id = 7, Name = "Hardik Pandya", Department = Dept.AllRounder, Email = "hardik@bcci.com", PhotoPath = "" },
                new Employee() { Id = 8, Name = "Ravi Jadeja", Department = Dept.AllRounder, Email = "jadeja@bcci.com", PhotoPath = "" },
                new Employee() { Id = 9, Name = "Kuldeep Yadav", Department = Dept.Bowler, Email = "kuldeep@bcci.com", PhotoPath = "" },
                new Employee() { Id = 10, Name = "Mohd. Shami", Department = Dept.Bowler, Email = "shami@bcci.com", PhotoPath = "" },
                new Employee() { Id = 11, Name = "Jasprit Bumrah", Department = Dept.Bowler, Email = "jasprit@bcci.com", PhotoPath = "" }
                );
        }
    }
}
