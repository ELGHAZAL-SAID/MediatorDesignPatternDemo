class User
{
    public string Name { get; }
    private IChatMediator mediator;

    public User(string name, IChatMediator mediator)
    {
        Name = name;
        this.mediator = mediator;
    }

    public void SendMessage(string message, User receiver)
    {
        mediator.SendMessage(message, this, receiver);
    }
}
