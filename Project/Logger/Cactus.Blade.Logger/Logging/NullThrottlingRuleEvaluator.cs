namespace Logging
{
    public class NullThrottlingRuleEvaluator : IThrottlingRuleEvaluator
    {
        public bool ShouldLog(ILogEntry logEntry)
        {
            return true;
        }
    }
}
