using DotNet_ToDo_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_ToDo_API.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
