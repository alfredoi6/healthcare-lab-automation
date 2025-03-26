namespace WpfLabAutomationUi.Models
{
	public class DeviceSimulator
	{
		public string DeviceId { get; set; }
		public string DeviceName { get; set; }
		public string Status { get; set; }
		public double CurrentReading { get; set; }
		public DateTime LastUpdated { get; set; }

		// Simulate updating device data
		public void UpdateDeviceData()
		{
			// Example simulation: Updating status and reading
			Status = "Operational";
			CurrentReading = new Random().Next(0, 100);
			LastUpdated = DateTime.Now;
		}

		public void ResetDevice()
		{
			Status = "Offline";
			CurrentReading = 0;
			LastUpdated = DateTime.Now;
		}
	}
}