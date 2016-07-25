namespace IoCApp.Biz.Logger
{
    class NullLogger : ILogger
    {
        void ILogger.Log(string text) { }
    }
}
