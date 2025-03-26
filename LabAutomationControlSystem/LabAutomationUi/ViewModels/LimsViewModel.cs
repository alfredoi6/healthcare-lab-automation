using System.Collections.ObjectModel;
using WpfLabAutomationUi.Models;

namespace WpfLabAutomationUi.ViewModels
{
	public class LimsViewModel : BaseViewModel
	{
		private LimsCommunicator _limsCommunicator;
		public ObservableCollection<string> LimsData { get; set; }

		public LimsViewModel()
		{
			_limsCommunicator = new LimsCommunicator();
			LimsData = new ObservableCollection<string>();
		}

		public void SendDataToLims(string deviceId, double reading)
		{
			_limsCommunicator.SendDataToLims(deviceId, reading);
			LimsData.Add($"Data sent to LIMS for device {deviceId} with reading {reading}");
		}

		public void RetrieveDataFromLims(string deviceId)
		{
			var data = _limsCommunicator.RetrieveDataFromLims(deviceId);
			LimsData.Add($"Retrieved data from LIMS: Device {deviceId}, Reading {data}");
		}
	}
}