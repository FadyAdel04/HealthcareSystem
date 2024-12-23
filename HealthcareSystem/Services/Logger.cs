public interface ILoggingService
{
    void Log(string message);
}

public class LoggingService : ILoggingService
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}
