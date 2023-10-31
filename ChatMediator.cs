class ChatMediator : IChatMediator
{
    public void SendMessage(string message, User sender, User receiver)
    {
        Console.WriteLine($"{sender.Name} sends a message to {receiver.Name}: {message}");
    }
}
