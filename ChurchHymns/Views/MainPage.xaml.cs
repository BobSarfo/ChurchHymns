using System.Windows.Controls;

using ChurchHymns.ViewModels;

namespace ChurchHymns.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
