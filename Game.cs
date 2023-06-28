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
        // @ is a verbatim identifier
        Console.WriteLine(@"Welcome to Cook's Assistant!

In this game, you will encounter a sad cook who's down on his luck.
It is up to you to help him bake a cake and save his head!

Press 'Enter' to begin.");
        Console.ReadLine();
        Console.Clear();//clearing console once something is entered
        first();

    }

    public void first()
    {
        string answer;//variable for Console.ReadLine

        Console.WriteLine("You are a brave new Adventurer in a quaint town, perfect for beginners like yourself.");
        Console.WriteLine("You make your way into a small castle and find a kitchen where a sad and pathetic cook is crying in the corner.");
        Console.WriteLine("");
        Say("Adventurer", "Hi there. Why are you crying?");
        Say("Cook", "The Duke's birthday is today and I don't have the ingredients to make his birthday cake! He's going to toss me out!");
        Say("Cook", "What am I to do?(crying ensues) Please, Please will you help me?");
        Console.WriteLine("1. No");
        Console.WriteLine("2. Yes");
        Console.Write("Answer: ");
        answer = Console.ReadLine().ToLower();
        Console.Clear();

        //switch based on the answer variable
        switch (answer)
        {
            //all 3 of these cases will call the code
            case "1":
            case "No won't help":
            case "No":
                {
                    Say("Adventurer", "I have a lunch date planned already.  Maybe some other time.");
                    Say("Cook", "Just great. I had a feeling I couldn't rely on an Adventurer.");
                    Say("Adventurer", "Best of luck to you and the cake!");
                    Console.ReadLine();
                    gameOver();
                    break;
                }

            case "2":
            case "Yes":
                {
                    Say("Cook", "Oh, thank you for your kindness!");
                    Say("Cook", "I will need all of these ingredients: Flour, Sugar, Milk, Butter, Sardines, and Eggs.");
                    Say("Adventurer", "I'm beginning to regret my decision.  Where do I go to find all of these ingredients for the cake?");
                    Say("Cook", "Marla: Flour and Sugar, Shelby: Butter and Milk, Garrett: Sardines, Brianne: Eggs");
                    Say("Adventurer", "Is that all... I better get on my way.");
                    Enter("Press 'Enter' to continue");
                    Console.ReadLine();
                    second();
                    break;

                }

            default:
                {
                    Enter("Unrecognizable command.  Press 'Enter' to try again");
                    Console.ReadLine();
                    first(); //bringing back to beginning
                    break;
                }
        }
    }
    public void second()
    {
        string options;
        
        Say("Adventurer", "First up on my list is Marla at the Flour Mill");
        Console.WriteLine("");
        Console.WriteLine("You walk along a dirt path passing by many goblins and beggars.");
        Console.WriteLine("");
        Console.WriteLine("You arrive at Marla's Flour Mill");
        Say("Adventurer", "Marla, I was sent here by the Duke's cook to purchase flour and sugar.");
        Say("Marla", "Of course! That will be 800 gold pieces.");
        Say("Adventurer", "I don't have that kind of money!");
        Say("Marla", "Unfortunately for you, I'm the only flour mill around.");
        Console.WriteLine("1. No");
        Console.WriteLine("2. Yes");
        Console.Write("Options: ");
        options = Console.ReadLine().ToLower();
        Console.Clear();

    }

    public void third()
    {

    }

    public void gameOver()
    {

    }

    private void Say(string name, string line)
    {
        Console.WriteLine($"{name}: {line}");
    }

    private void Enter(string line)
    {
        Console.WriteLine($"{line}");
    }

}