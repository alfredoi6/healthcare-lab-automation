namespace WpfLabAutomationUi.Models
{
	public class LogEntry
	{
		public string Message { get; set; }
		public DateTime Timestamp { get; set; }
		public string Severity { get; set; }

		public LogEntry(string message, string severity)
		{
			Message = message;
			Timestamp = DateTime.Now;
			Severity = severity;
		}

		public void Log()
		{
			// Simulate logging the message (e.g., save to a file or database)
			Console.WriteLine($"[{Timestamp}] {Severity}: {Message}");
		}
	}
}