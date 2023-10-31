namespace Mediator
{
    public class User
    {
        public string Name { get; }
        public User(string name) => Name = name;

        public void SendMessage(string message, User receiver)
        {
            Console.WriteLine($"{Name} sends a message to {receiver.Name}: {message}");
        }
    }
}

namespace Mediator
{

    class Program
    {
        static void Main()
        {
            User said = new User("said");
            User aimad = new User("aimad");
            User dounia = new User("dounia");

            said.SendMessage("Hello, aimad!", aimad);
            aimad.SendMessage("Hi, said!", said);
            dounia.SendMessage("Hey, guys!", said);
        }
    }
}