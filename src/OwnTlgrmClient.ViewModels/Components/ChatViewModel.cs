using System.Collections.ObjectModel;
using System.Reactive;
using OwnTlgrmClient.Interfaces.DTO;
using OwnTlgrmClient.Interfaces.ViewModels;
using ReactiveUI;

namespace OwnTlgrmClient.ViewModels.Components;

public class ChatViewModel : ReactiveObject, IChatViewModel
{
    private string _messageInput = string.Empty;

    public ChatViewModel()
    {
        SendMessageCommand = ReactiveCommand.Create(SendMessage,
            this.WhenAnyValue(x => x.MessageInput, input => !string.IsNullOrWhiteSpace(input)));
    }

    public ObservableCollection<ChatMessage> Messages { get; } = [];

    public string MessageInput
    {
        get => _messageInput;
        set => this.RaiseAndSetIfChanged(ref _messageInput, value);
    }

    public ReactiveCommand<Unit, Unit> SendMessageCommand { get; }

    private void SendMessage()
    {
        if (string.IsNullOrWhiteSpace(MessageInput))
            return;

        Messages.Add(new ChatMessage(MessageInput));
        MessageInput = string.Empty; // Clear the input
    }
}