using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace EntityFramework
{
    // Define a class representing your database context
    public class MyDbContext : DbContext
    {
        public DbSet<Student_Info1> Students { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Demo1;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
    //  class representing (table)
    [Table("Student_Info1")]
    public class Student_Info1
    {
        public int Id { get; set; }
        public string Name { get; set; }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of the DbContext
                using (var dbContext = new MyDbContext())
                {
                    // Create a new entity instance
                    var entity = new Student_Info1
                    {
                        Id = 23,
                        Name = "jay"
                    };
                    // Add the entity to the context
                    dbContext.Students.Add(entity);
                    //var student=(Student)dbContext.Students.Where(student => student.Id == 100);
                    //Console.WriteLine(student.Name);
                    // Save changes to the database
                    dbContext.SaveChanges();
                    Console.WriteLine("Data inserted successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Outer Exception: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
            Console.ReadKey();
        }
    }
}









