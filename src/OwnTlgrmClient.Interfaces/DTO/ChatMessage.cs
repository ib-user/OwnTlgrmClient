using System;

namespace OwnTlgrmClient.Interfaces.DTO;

public class ChatMessage
{
public string Content { get; set; }
    public DateTime Timestamp { get; set; }

    public ChatMessage(string content)
    {
        Content = content;
        Timestamp = DateTime.Now;
    }
}
