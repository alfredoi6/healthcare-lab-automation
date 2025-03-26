namespace WpfLabAutomationUi.Models
{
	public class Alert
	{
		public string DeviceId { get; set; }
		public double Reading { get; set; }
		public string AlertMessage { get; set; }
		public DateTime AlertTime { get; set; }

		public Alert(string deviceId, double reading, string alertMessage)
		{
			DeviceId = deviceId;
			Reading = reading;
			AlertMessage = alertMessage;
			AlertTime = DateTime.Now;
		}

		public void SendAlert()
		{
			// Simulate sending alert (e.g., by email, message, or cloud)
			Console.WriteLine($"Alert: {AlertMessage} (Device: {DeviceId}, Reading: {Reading})");
		}
	}
}