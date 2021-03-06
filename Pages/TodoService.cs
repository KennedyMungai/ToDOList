using Microsoft.EntityFrameworkCore;

namespace ToDOList.Data;

public class TodoService : ITodoService
{
    private readonly TodoContext _context;

    public List<Todo> todoList { get; set; } = new List<Todo>();

    public TodoService(TodoContext context)
    {
        _context = context;
    }

    public async Task Create(Todo todo)
    {
        await _context.todo.AddAsync(todo);
        await _context.SaveChangesAsync();
    }

    public async Task RetrieveAll()
    {
        todoList = await _context.todo.ToListAsync();
    }

    public async Task Delete(int id)
    {
        var item = await _context.todo.FindAsync(id);

        if(item is not null)
        {
            _context.todo.Remove(item);
        }

        await _context.SaveChangesAsync();
    }
}