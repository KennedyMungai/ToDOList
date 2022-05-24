namespace ToDOList.Data;

public interface ITodoService
{
    public List<Todo> todoList { get; set; }
    Task Create(Todo todo);
    Task RetrieveAll();
    Task Delete(int id);
}