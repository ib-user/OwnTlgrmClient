using Microsoft.Extensions.DependencyInjection;
using OwnTlgrmClient.Interfaces.ViewModels;
using OwnTlgrmClient.ViewModels;
using OwnTlgrmClient.ViewModels.Components;

namespace OwnTlgrmClient.UI;

public static class Setup
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        return collection.AddViewModels();
    }

    private static IServiceCollection AddViewModels(this IServiceCollection collection)
    {
        return collection.AddSingleton<IMainViewModel, MainViewModel>()
            .AddSingleton<IChatViewModel, ChatViewModel>();
    }
}