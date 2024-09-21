using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotChampListBox : ListBox
{
    public RiotChampListBox()
    {
        DefaultStyleKey = typeof(RiotChampListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotChampGroupItem();
    }
}