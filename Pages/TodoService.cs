namespace ToDOList.Data;

public class TodoService
{
    private readonly TodoContext _context;

    public TodoService(TodoContext context)
    {
        _context = context;
    }
}