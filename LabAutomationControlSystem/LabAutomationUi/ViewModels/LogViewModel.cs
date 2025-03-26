using System.Collections.ObjectModel;
using WpfLabAutomationUi.Models;

namespace WpfLabAutomationUi.ViewModels
{
	public class LogViewModel : BaseViewModel
	{
		public ObservableCollection<LogEntry> LogEntries { get; set; }

		public LogViewModel()
		{
			LogEntries = new ObservableCollection<LogEntry>();
		}

		public void AddLogEntry(string message, string severity)
		{
			var logEntry = new LogEntry(message, severity);
			logEntry.Log();
			LogEntries.Add(logEntry);
		}
	}
}