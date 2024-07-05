using CRUD_APP.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace CRUD_APP.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
