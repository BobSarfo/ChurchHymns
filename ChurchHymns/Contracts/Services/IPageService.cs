using System.Windows.Controls;

namespace ChurchHymns.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
