namespace Test27
{
	public class LogManager : object
	{
		public LogManager(ILogger log) : base()
		{
			MyLog = log;
		}

		public ILogger MyLog { get; set; }

		public void Log(string message)
		{
			MyLog.Log(message);
		}
	}
}
