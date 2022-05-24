namespace ToDOList.Pages;

public interface ITodoService
{
    Task Create();
    Task Delete();
}