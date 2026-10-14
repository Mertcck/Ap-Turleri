using Microsoft.EntityFrameworkCore;

namespace RestAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public virtual DbSet<Todo> Todos { get; set; }
    }
}
