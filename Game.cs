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
          
        Console.WriteLine("---");

        Say("Adventurer", "First up on my list is Marla at the Flour Mill");
        Console.WriteLine("");
        Console.WriteLine("*You walk along a dirt path passing by many goblins and beggars.*");
        Console.WriteLine("");
        Console.WriteLine("*You arrive at Marla's Flour Mill*");
        Console.WriteLine("");
        Say("Adventurer", "Marla, I was sent here by the Duke's cook to purchase flour and sugar.");
        Console.WriteLine("");
        Say("Marla", "Of course! That will be 800 gold pieces.");
        Console.WriteLine("");
        Say("Adventurer", "I don't have that kind of money!");
        Console.WriteLine("");
        Say("Marla", "Unfortunately for you, I'm the only flour mill around.");
        Console.WriteLine("---");
        Console.WriteLine("");
        Console.WriteLine("1. Give up and go home.");
        Console.WriteLine("2. Confuse Marla and steal the goods.");
        Console.Write("Options: ");
        options = Console.ReadLine().ToLower();
        Console.Clear();

        switch (options)
        {
            case "1":
            case "Give up":
                {
                    Console.WriteLine("---");
                    Say("Adventurer", "I've only just arrived in this world! Please find some generosity in your heart!");
                    Console.WriteLine("");
                    Say("Marla", "No.");
                    Console.WriteLine("");
                    Say("Adventurer", "Guess I'd better tell the Cook I'm a failure just like him.");
                    Console.WriteLine("---");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    second();
                    break;
                }

            case "2":
            case "Confuse Marla and steal the goods":
                {
                    Console.WriteLine("---");
                    Say("Adventurer", "OH NO, MARLA! LOOK! A SWITCH STATEMENT!");
                    Console.WriteLine("");
                    Say("Marla", "NO, PLEASE! MAKE IT STOP!");
                    Console.WriteLine("");
                    Console.WriteLine("*Marla drops to the ground in the fetal position.*");
                    Console.WriteLine("*You quickly run inside and steal the flour and sugar.*");
                    Console.WriteLine("");
                    Say("Adventurer", "Okay, lets see... Where to next?");
                    Console.WriteLine("");
                    Console.WriteLine("*You check your list.*");
                    Console.WriteLine("");
                    Say("Adventurer", "Get butter, milk, and eggs from the farmers. Sounds easy enough!");
                    Console.WriteLine("");
                    Console.WriteLine("---");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    third();
                    break;

                }

            default:
                {
                    Enter("Unrecognizable command.  Press 'Enter' to try again.");
                    Console.ReadLine();
                    second(); //bringing back to beginning of the sescond method
                    break;
                }
        }

    }

    public void third()
    {

        string choice;

        Console.WriteLine("---");
        Console.WriteLine("*You cross a small creek and wave hello to the baby ducks.*");
        Console.WriteLine("");
        Console.WriteLine("*You arrive at the farm.");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: Hello. I'm needing to get some milk, butter, and eggs for a birthday cake. 
        It's for the Duke's birthday party.");
        Console.WriteLine("");
        Console.WriteLine(@"Brianne: Sure thing. I'll go get you some eggs.
You'll have to go visit Shelby to get the milk and butter.
She'll show you what do do.");
        Console.WriteLine("");
        Say("Adventurer", "Great, thank you very much.");
        Console.WriteLine("");
        Console.WriteLine("*You walk towards the cow pasture and find Shelby sitting on a stool, milking a cow.*");
        Console.WriteLine("");
        Say("Adventurer", "Hi, Shelby. I'm here to get some butter and milk. Brianne said I should see you about those.");
        Console.WriteLine("");
        Console.WriteLine(@"Shelby: Yep. Take this here bucket and go find yerself a dairy cow... 
And make sure it's a DAIRY COW! 
Hope yer smart enough to tell em apart.");
        Console.WriteLine("");
        Say("Adventurer", "Trust me. I know what I'm doing.");
        Console.WriteLine("");
        Console.WriteLine("*You walk deeper into the field and find more cows.*");
        Console.WriteLine("*You look around, trying to find a dairy cow.*");
        Console.WriteLine("");
        Say("Adventurer", "Hey, there little lady. Mind if I get some milk from ya?");
        Console.WriteLine("");
        Console.WriteLine("*The cow slowly turns its head and looks at you.*");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: Don't worry, I'll be quick! You've only got one udder, anyway.");
        Console.WriteLine("");
        Console.WriteLine("*You sit down and position your bucket under the udder.*");
        Console.WriteLine("");
        Console.WriteLine("*The cow lets out a deep 'moo' of warninig.*");
        Console.WriteLine("---");
        Console.WriteLine("");
        Console.WriteLine("1. Ignore the 'moo' and give it a yank.");
        Console.WriteLine("2. Heed the 'moo' and find a different cow.");
        Console.Write("Options: ");
        choice = Console.ReadLine().ToLower();
        Console.Clear();
        
        switch (choice)
        {
            case "1":
            case "Ignore the 'moo' and give it a yank.":
                {
                    Console.WriteLine("---");
                    Say("Adventurer", "Easy does it!");
                    Console.WriteLine("");
                    Console.WriteLine("*You yank the udder.*");
                    Console.WriteLine("");
                    Console.WriteLine("You are swiftly kicked in the head by the cow and die.");
                    Console.WriteLine("---");
                    Console.ReadLine();
                    gameOver();
                    break;
                }

            case "2":
            case "Heed the 'moo' and find a different cow.":
                {
                    Console.WriteLine("---");
                    Say("Adventurer", "On second thought, I think I might try a different cow.");
                    Console.WriteLine("");
                    Console.WriteLine("*You choose a different cow with a normal udder.*");
                    Console.WriteLine("*You fill your bucket with milk and pet the cow for a job well done.*");
                    Console.WriteLine("*The cow moos happily.*");
                    Console.WriteLine(""); 
                    Say("Adventurer", "Hey Shelby, I've got the milk. How's the butter coming along?");
                    Console.WriteLine("");
                    Console.WriteLine(@"Shelby: Great! Here's yer stick o' butter from the fridge,
and yer egg that Brianne fetched for ye.");
                    Console.WriteLine("");
                    Say("Adventurer", "Excellent, thank you! By the way, what's a fridge?");
                    Console.WriteLine("");
                    Say("Shelby", "I don't know.");
                    Console.WriteLine("---");
                    Enter("Press 'Enter' to continue");
                    Console.ReadLine();
                    fourth();
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

    public void fourth()
    {
        Console.WriteLine("---");
        Console.WriteLine("*Happy that you have gathered all but the sardines, you make your way to see Garrett the fisherman at the local port.*");
        Console.WriteLine("");
        Console.WriteLine("*You arrive at the port.");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: Geez, it smells here! Where is Garrett? I'm needing to get some sardines for a birthday cake. 
        Not my favorite kind of birthday cake, but oh well.");
        Console.WriteLine("");
        Console.WriteLine(@"Garrett: You have found the right person. Hi, I'm Garrett.  I can assist you with the sardines.
Hopefully you aren't tricking me and giving these to your cats.  Man, cats are the worst!");
        Console.WriteLine("");
        Say("Adventurer", "No cats, just for the Duke's birthday cake.");
        Console.WriteLine("");
        Say("Adventurer", "How much for the sardines?");
        Console.WriteLine("");
        Say("Garrett", "Your lucky day, only 3 gold coin pieces.");
        Console.WriteLine("");
        Say("Adventurer", "I'll take them, thanks sir!  Wish all my stops have been this easy.");
        Console.WriteLine("");
        Console.WriteLine("*You have gathered all of the cook's requested ingredients, time to head back to the castle to hand over the ingredients to him.*");
        Console.WriteLine("");
        Say("Adventurer", "That cook better be super glad to see me after all that he put me through!");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
        fifth();
        

    }

    public void fifth()
    {
        Console.WriteLine("---");
        Console.WriteLine("*You arrive at the castle and find the cook pacing the kitchen floor.*");
        Console.WriteLine("");
        Console.WriteLine("*The cook sees you and lets out a big sigh of relief.");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: I return with all of the ingredients you need for the Duke's birthday cake. I'll just drop these on the table here and head on my way.");
        Console.WriteLine("");
        Console.WriteLine(@"Cook: You have saved my life!  I can not thank you enough... Wait, where are the birthday candles??");
        Console.WriteLine("");
        Say("Adventurer", "CANDLES?  You didn't say anything about candles!");
        Console.WriteLine("");
        Say("Cook", "Oh, really?  Huh.  Must have slipped my mind! I also need 100 birthday candles for the Duke's cake.");
        Console.WriteLine("");
        Say("Adventurer", "I don't know. There are more adventures out there for me. I'm thinking we should just part our ways here.");
        Console.ReadLine();
        Console.Clear();
        sixth();
    }
        
    public void sixth()
    {
            Console.WriteLine("---");
            Random rnd = new Random();
            String[] candleOptions = {"The cook pleads for your additional assistance of picking up the birthday candles", "The cook offers to let you help him bake the cake if you go pick up the birthday candles",
            "The cook falls to the ground and begs you to go and pick up the birthday candles."};
            int randomNumber = rnd.Next(0,3);
            String candleText = candleOptions[randomNumber];

            String candleChoice;

            Console.WriteLine(candleText);
            Console.WriteLine("Do you help the cook by going to pick up the 100 birthday candles; Yes or No?");
            Console.Write("Your Choice: ");
            candleChoice = Console.ReadLine().ToLower();

            if (candleChoice == "yes" || candleChoice == "y")
            {
                Console.WriteLine("You feel like you really should just end this adventure but you decide to continue and seek out the 100 birthday candles.");
                Console.ReadLine();
                Console.Clear();
                seventh();
            }
            else if(candleChoice == "no" || candleChoice == "n")
            {
                Console.WriteLine("You are so done with this cook and wish him the best and make a quick exit.");
            Console.WriteLine("");
                Console.WriteLine("For partial completion of quest, you have earned 1 quest point.");
                Console.ReadLine();
                Console.Clear();
                gameOver();
            }
            else
            {
                Console.WriteLine("Unrecognizable command. Must enter 'yes' or 'no'. Press 'Enter' to try again.");
                Console.ReadLine();
                sixth();
            }
        

    }

    public void seventh()
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