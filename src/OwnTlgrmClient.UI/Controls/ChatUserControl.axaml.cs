using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using OwnTlgrmClient.ViewModels.Components;

namespace OwnTlgrmClient.UI.Controls;

public partial class ChatUserControl : UserControl
{
    public ChatUserControl()
    {
        InitializeComponent();
        DataContext = new ChatViewModel(); // Set the DataContext to the ViewModel
    }

    private void MessageInput_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            // var viewModel = (ChatViewModel)DataContext;
            // if (viewModel.SendMessageCommand.CanExecute())
            // {
            //     viewModel.SendMessageCommand.Execute().Subscribe();
            // }
            e.Handled = true; // Prevents the beep sound on Enter key
        }
    }
}
