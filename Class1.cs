using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class SchoolDbContext : DbContext
        public DbSet<Student> Students {  get; set; }
    
    protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
    { 
        optionsBuilder.UseSqlServer(("Server= ")
    }
}
using (var context = new SchoolDbContext))
        {
     context.Database.EnsureCreated();
    var grade1=new Grade { GradeName= "1st Grade"}
    var student1=new Student { FirstName= "Rodil",LastName ="Concha", Grade =grade1 };

    context.Students.Add(student1);
    context.SaveChanges();
}