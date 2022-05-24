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

    public async Task Retrieve()
    {
        todoList = await _context.todo.ToListAsync();
    }

    public async Task Delete(int id)
    {
        if(id != null)
        {
            await _context.todo.Remove(id);
            await _context.SaveChangesAsync();
        }
    }
}