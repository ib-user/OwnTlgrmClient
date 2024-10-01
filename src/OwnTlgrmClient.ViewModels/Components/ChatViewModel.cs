using OwnTlgrmClient.Interfaces.DTO;
using OwnTlgrmClient.Interfaces.ViewModels;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;


namespace OwnTlgrmClient.ViewModels.Components;

public class ChatViewModel : ReactiveObject, IChatViewModel
{
    public ObservableCollection<ChatMessage> Messages { get; } = [];

    private string _messageInput;
    public string MessageInput
    {
        get => _messageInput;
        set => this.RaiseAndSetIfChanged(ref _messageInput, value);
    }

    public ReactiveCommand<Unit, Unit> SendMessageCommand { get; }

    public ChatViewModel()
    {
        SendMessageCommand = ReactiveCommand.Create(SendMessage, this.WhenAnyValue(x => x.MessageInput, input => !string.IsNullOrWhiteSpace(input)));
    }

    private void SendMessage()
    {
        if (!string.IsNullOrWhiteSpace(MessageInput))
        {
            Messages.Add(new ChatMessage(MessageInput));
            MessageInput = string.Empty; // Clear the input
        }
    }
}
