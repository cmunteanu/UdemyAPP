using Microsoft.EntityFrameworkCore;
using UdemyApp.API.Models;

namespace UdemyApp.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
