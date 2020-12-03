namespace Chinook.Persistence
{
	public class FileDataPersisterSettings
	{
		public static FileDataPersisterSettings Default { get; } = new FileDataPersisterSettings();

		public FileDataPersisterSettings(
			int numberOfRetries = 3,
			int retryDelay = 100,
			bool exclusiveMode = true)
		{
			NumberOfRetries = numberOfRetries;
			RetryDelay = retryDelay;
			ExclusiveMode = exclusiveMode;
		}

		public int NumberOfRetries { get; }

		public int RetryDelay { get; }

		public bool ExclusiveMode { get; }
	}
}
