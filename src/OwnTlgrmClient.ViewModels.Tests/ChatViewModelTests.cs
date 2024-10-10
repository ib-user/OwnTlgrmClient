using FluentAssertions;
using OwnTlgrmClient.ViewModels.Components;
using System.Reactive.Linq;

namespace OwnTlgrmClient.ViewModels.Tests;

public class ChatViewModelTests
{
    [Fact]
    public void SendMessage_ShouldAddMessage_WhenMessageInputIsNotEmpty()
    {
        // Arrange
        var viewModel = new ChatViewModel
        {
            MessageInput = "Test message"
        };

        // Act
        viewModel.SendMessageCommand.Execute().Subscribe();

        // Assert
        viewModel.Messages.Should().HaveCount(1);
        viewModel.Messages[0].Content.Should().Be("Test message");
    }

    [Fact]
    public void SendMessage_ShouldNotAddMessage_WhenMessageInputIsEmpty()
    {
        // Arrange
        var viewModel = new ChatViewModel
        {
            MessageInput = "" // Empty input
        };

        // Act
        viewModel.SendMessageCommand.Execute().Subscribe();

        // Assert
        viewModel.Messages.Should().BeEmpty();
    }
}
