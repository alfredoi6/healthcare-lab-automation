using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfLabAutomationUi.Models;

namespace WpfLabAutomationUi.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		// Models
		private DeviceSimulator _deviceSimulator;
		private LimsCommunicator _limsCommunicator;
		private CloudStorageHelper _cloudStorageHelper;

		// Properties for data binding to the View
		public ObservableCollection<DeviceSimulator> Devices { get; set; }
		public ObservableCollection<string> Logs { get; set; }

		public ICommand StartSimulationCommand { get; set; }
		public ICommand StopSimulationCommand { get; set; }

		public MainViewModel()
		{
			_deviceSimulator = new DeviceSimulator
			{
				DeviceId = "Device_1",
				DeviceName = "Device Simulator 1",
				Status = "Operational",
				CurrentReading = 50.5,
				LastUpdated = DateTime.Now
			};
			_limsCommunicator = new LimsCommunicator();
			_cloudStorageHelper = new CloudStorageHelper();

			Devices = new ObservableCollection<DeviceSimulator>
			{
				_deviceSimulator // Adding the simulator to the collection directly
			};

			Logs = new ObservableCollection<string>();

			// Command bindings
			StartSimulationCommand = new RelayCommand(StartSimulation);
			StopSimulationCommand = new RelayCommand(StopSimulation);
		}

		// Command Methods
		private void StartSimulation()
		{
			_deviceSimulator.UpdateDeviceData();
			Devices.Add(_deviceSimulator);
			Logs.Add($"Device Data Updated: {DateTime.Now}");
		}

		private void StopSimulation()
		{
			_deviceSimulator.ResetDevice();
			Devices.Clear();
			Logs.Add($"Device Simulation Stopped: {DateTime.Now}");
		}

		// Simulating sending data to LIMS
		public void SendDataToLims()
		{
			foreach (var device in Devices)
			{
				_limsCommunicator.SendDataToLims(device.DeviceId, device.CurrentReading);
			}
		}

		// Simulate uploading data to cloud
		public void UploadDataToCloud()
		{
			foreach (var device in Devices)
			{
				_cloudStorageHelper.UploadDataToCloud($"Device {device.DeviceId} data: {device.CurrentReading}");
			}
		}
	}
}