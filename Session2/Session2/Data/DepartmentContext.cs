using Microsoft.EntityFrameworkCore;
using Session2.Models;

namespace Session2.Data
{
    public class DepartmentContext :DbContext
    {
        public DbSet<Department> Departments { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=db5045.public.databaseasp.net; Database=db5045; User Id=db5045; Password=t#9K-6XqE+a4; Encrypt=False; MultipleActiveResultSets=True;");
        }
    }
}
