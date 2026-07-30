using System.Windows;
using StatusLamp.Wpf.ViewModels;

namespace StatusLamp.Wpf;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
