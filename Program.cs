using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IChatMediator chatMediator = new ChatMediator();

        User alice = new User("Alice", chatMediator);
        User bob = new User("Bob", chatMediator);
        User charlie = new User("Charlie", chatMediator);

        alice.SendMessage("Hello, Bob!", bob);
        bob.SendMessage("Hi, Alice!", alice);
        charlie.SendMessage("Hey, guys!", alice);
    }
}
