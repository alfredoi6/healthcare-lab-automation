namespace WpfLabAutomationUi.Models
{
	public class CloudStorageConfig
	{
		public string StorageAccountName { get; set; }
		public string StorageContainer { get; set; }
		public string AccessKey { get; set; }

		public void DisplayConfiguration()
		{
			Console.WriteLine($"Storage Account: {StorageAccountName}");
			Console.WriteLine($"Container: {StorageContainer}");
		}
	}
}