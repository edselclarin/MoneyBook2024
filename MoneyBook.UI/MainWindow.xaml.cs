using MoneyBook.UI.ViewModel;
using System.Windows;

namespace MoneyBook.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel_;

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();

            viewModel_ = viewModel;
            DataContext = viewModel_;

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel_.Load();
        }
    }
}