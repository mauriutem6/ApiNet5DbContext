using Microsoft.EntityFrameworkCore;

namespace api5.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Marca> Marcas { get; set; }
    }
}