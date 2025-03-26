using System.Collections.ObjectModel;
using WpfLabAutomationUi.Models;

namespace WpfLabAutomationUi.ViewModels
{
	public class CloudStorageViewModel : BaseViewModel
	{
		private CloudStorageHelper _cloudStorageHelper;
		public ObservableCollection<string> CloudLogs { get; set; }

		public CloudStorageViewModel()
		{
			_cloudStorageHelper = new CloudStorageHelper();
			CloudLogs = new ObservableCollection<string>();
		}

		public void UploadDataToCloud(string data)
		{
			_cloudStorageHelper.UploadDataToCloud(data);
			CloudLogs.Add($"Uploaded data to cloud: {data}");
		}

		public void DownloadDataFromCloud(string fileName)
		{
			var data = _cloudStorageHelper.DownloadDataFromCloud(fileName);
			CloudLogs.Add($"Downloaded data from cloud: {data}");
		}
	}
}