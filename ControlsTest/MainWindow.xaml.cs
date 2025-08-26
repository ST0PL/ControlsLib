using System.Windows;
using ControlsLib;

namespace ControlsTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ulong StartTimestamp => (ulong)DateTimeOffset.UtcNow.AddMinutes(-4).ToUnixTimeMilliseconds();
        public ulong EndTimestamp => (ulong)DateTimeOffset.UtcNow.AddMinutes(10).ToUnixTimeMilliseconds();

        public MainWindow()
        {
            DataContext = this;
            Loaded += OnLoad;
            InitializeComponent();

        }
        void OnLoad(object sender, RoutedEventArgs e)
        {
            var element = TreeTools.GetVisualTree(this);
            Loaded -= OnLoad;
        }
    }
}