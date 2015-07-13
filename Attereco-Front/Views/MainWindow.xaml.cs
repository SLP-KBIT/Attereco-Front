using System.Windows;
using Attereco_Front.ViewModel;
using Attereco_Front.Model;

namespace Attereco_Front
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Window_SourceInitialized(object sender, System.EventArgs e)
        {

        }
    }
}