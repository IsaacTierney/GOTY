using System;

namespace GOTY;

public class Game
{
    static void Main(string[] args)
    {
        new Game().run();
    }

    public void run()
    {
        gameTitle();
    }
    public void gameTitle()
    {

        Console.WriteLine(@"Welcome to Cook's Assistant!
In this game, you will encounter a sad cook who's down on his luck.
It is up to you to help him bake a cake and save his head!
Press 'Enter' to begin.");
        Console.ReadLine();
        Console.Clear();
        first();
    }

    public void first()
    {
        Console.WriteLine("You are a brave new Adventurer in a quaint town, perfect for beginners like yourself."); 
        Console.WriteLine("You make your way into a small castle and find a kitchen where a sad and pathetic cook is crying in the corner.");
        Say("Adventurer", "Hi there. Why are you crying?");
    }

    private void Say(string name, string line)
    {
        Console.WriteLine($"{name}: {line}");
    }
}