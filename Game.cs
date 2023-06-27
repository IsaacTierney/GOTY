using System;

namespace GOTY;

public class Game
{
    static void Main(string[] args)
    {
        gameTitle();
        first();
    }

    public static void gameTitle()
    {

        Console.WriteLine("Welcome to Cook's Assistant!");
        Console.WriteLine("In this game, you will encounter a sad cook who's down on his luck.");
        Console.WriteLine("It is up to you to help him bake a cake and save his head!");
        Console.WriteLine("");
        Console.WriteLine("Press 'Enter' to begin.");
        Console.ReadLine();
        Console.Clear();
        first();
    }


}