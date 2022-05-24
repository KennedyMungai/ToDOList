using Microsoft.EntityFrameworkCore;

namespace ToDOList.Data;

public class TodoContext : DbContext
{
    public DbSet<Todo>? todo { get; set; }
    
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
        
    }
}