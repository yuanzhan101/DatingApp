using DatingApp.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        
        }

        public DbSet<Value> MyValues { get; set; }

        public DbSet<User> Users { get; set;}
    }
}