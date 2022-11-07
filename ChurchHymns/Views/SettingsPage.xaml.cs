using System.Windows.Controls;

using ChurchHymns.ViewModels;

namespace ChurchHymns.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
