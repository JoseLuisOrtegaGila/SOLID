public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}
public class SomeService
{
    private readonly ILogger _logger;

    public SomeService(ILogger logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        _logger.Log("Haciendo trabajo...");
    }
}
