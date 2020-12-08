namespace Logging
{
    public interface ILogFormatter
    {
        string Format(ILogEntry entry);
    }
}
