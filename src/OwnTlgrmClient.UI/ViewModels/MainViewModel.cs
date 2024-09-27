using ReactiveUI;
using System.Reactive.Linq;

namespace OwnTlgrmClient.UI.ViewModels;
public class MainViewModel : ReactiveObject
{
    private string _title;
    public string Title
    {
        get => _title;
        set => this.RaiseAndSetIfChanged(ref _title, value);
    }

    public MainViewModel()
    {
        Title = "";
    }
}
