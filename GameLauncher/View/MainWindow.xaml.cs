using GameLauncher.View.Resources;
using System.Windows;

namespace GameLauncher.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WowPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new WowPage());
        }

        private void HSPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HSPage());
        }

        private void OWPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new OWPage());
        }

        private void W3Page_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new W3Page());
        }

        private void D3Page_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new D3Page());
        }

        private void HOTSPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new HOTSPage());
        }

        private void SC2Page_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SC2Page());
        }

        private void SCPage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SCPage());
        }
    }
}
