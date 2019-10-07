using Microsoft.EntityFrameworkCore;
using TillWeMeet.API.Models;

namespace TillWeMeet.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}