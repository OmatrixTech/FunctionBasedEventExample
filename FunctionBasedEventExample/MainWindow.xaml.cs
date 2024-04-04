using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FunctionBasedEventExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EventHandler eventHandler = new EventHandler();
        Subscriber subscriber = new Subscriber();
        public MainWindow()
        {
            InitializeComponent();
            eventHandler.FunctionEvent += EventHandler_FunctionEvent;
        }

        private async Task EventHandler_FunctionEvent()
        {
            // Perform the necessary logic when the event is raised
            // For example, updating UI elements, fetching data asynchronously, etc.
            await Task.Delay(1000); // Simulate some asynchronous operation
            MessageBox.Show("collection changed event fired!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            eventHandler.TriggerCollectionChanged();
        }
    }
}