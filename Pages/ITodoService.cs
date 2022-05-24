namespace ToDOList.Data;

public interface ITodoService
{
    public List<Todo> todoList { get; set; }
    Task Create(Todo todo);
    Task Retrieve();
    Task Delete(int id);
}