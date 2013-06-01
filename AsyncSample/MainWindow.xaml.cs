using System.Threading.Tasks;
using System.Windows;
using System.Threading;

namespace AsyncSample
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            status.Text = "1回目";
            await Task.Run(() => Thread.Sleep(1000));
            status.Text = "2回目";
            await Task.Run(() => Thread.Sleep(1000));
            status.Text = "3回目";
        }
    }
}
