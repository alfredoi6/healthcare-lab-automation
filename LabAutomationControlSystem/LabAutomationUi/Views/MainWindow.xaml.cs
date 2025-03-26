using System.Windows;
using WpfLabAutomationUi.ViewModels;

namespace WpfLabAutomationUi.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();  // Ensure DataContext is set to MainViewModel
        }
    }
}