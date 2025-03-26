namespace WpfLabAutomationUi.Models
{
	public class LimsCommunicator
	{
		public string LimsSystemName { get; set; }
		public string LimsUrl { get; set; }

		// Simulate sending data to LIMS
		public void SendDataToLims(string deviceId, double reading)
		{
			// For simulation, just log the data being sent
			Console.WriteLine($"Sending data to LIMS: Device: {deviceId}, Reading: {reading}");
		}

		// Simulate retrieving data from LIMS
		public double RetrieveDataFromLims(string deviceId)
		{
			// For simulation, return a random reading
			return new Random().Next(0, 100);
		}
	}
}