using System.Windows.Controls;

using ChurchHymns.ViewModels;

namespace ChurchHymns.Views;

public partial class ListDetailsPage : Page
{
    public ListDetailsPage(ListDetailsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
