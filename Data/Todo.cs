namespace ToDOList.Data;

public class Todo
{
    public int Id { get; set; }
    public string? Item { get; set; }
    public DateTime DeadLine { get; set; }
    public bool IsDone { get; set; } = false;
}