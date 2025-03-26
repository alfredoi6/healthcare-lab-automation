namespace WpfLabAutomationUi.Models
{
	public class DeviceConfiguration
	{
		public string DeviceId { get; set; }
		public double UpperThreshold { get; set; }
		public double LowerThreshold { get; set; }

		public bool IsReadingWithinThreshold(double reading)
		{
			return reading >= LowerThreshold && reading <= UpperThreshold;
		}
	}
}