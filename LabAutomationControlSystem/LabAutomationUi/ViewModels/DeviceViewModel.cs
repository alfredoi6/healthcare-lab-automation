using WpfLabAutomationUi.Models;

namespace WpfLabAutomationUi.ViewModels
{
	public class DeviceViewModel : BaseViewModel
	{
		private DeviceSimulator _device;

		public DeviceSimulator Device
		{
			get { return _device; }
			set { _device = value; OnPropertyChanged(nameof(Device)); }
		}

		public DeviceViewModel(DeviceSimulator device)
		{
			_device = device;
		}

		public void UpdateDevice()
		{
			Device.UpdateDeviceData();
		}

		public void ResetDevice()
		{
			Device.ResetDevice();
		}
	}
}