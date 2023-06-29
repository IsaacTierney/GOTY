using System;

namespace GOTY;

public class Game
{
    private string? _color;
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
        Console.WriteLine(
        @"Welcome to 'The Cook's Assistant' quest!

In this quest, you will encounter a sad cook who's down on his luck.
It is up to you to help him bake a cake and save his head!

To advance in the quest, enter the number that corresponds
with the option you wish to choose, the press 'Enter'.

Some sections are longer and may require you to scroll up
a bit in your terminal to read the entire dialogue.

Be careful! Picking the wrong option could leave you stuck or worse!

        Press 'Enter' to begin.");
        Console.ReadLine();
        Console.Clear();//clearing console once something is entered
        first();

    }

    public void first()
    {
        string answer;//variable for Console.ReadLine

        Console.WriteLine("---");
        Console.WriteLine("*You are a brave new Adventurer in a quaint town, perfect for beginners like yourself*.");
        Console.WriteLine("");
        Console.WriteLine("*You make your way into a small castle and find a kitchen where a sad and pathetic cook is crying in the corner.*");
        Console.WriteLine("");
        Say("Adventurer", "Hi there. Why are you crying?");
        Console.WriteLine("");
        Say("Cook", "Duke Jackson's birthday is today and I don't have the ingredients to make his birthday cake! He's going to toss me out!");
        Console.WriteLine("");
        Say("Cook", "What am I to do? *crying ensues* Please! Please will you help me?");
        Console.WriteLine("---");
        Console.WriteLine("");
        Console.WriteLine("1. No");
        Console.WriteLine("2. Yes");
        Console.Write("Answer: ");
        answer = Console.ReadLine()!.ToLower();
        Console.Clear();

        //switch based on the answer variable
        switch (answer)
        {
            //all 3 of these cases will call the code
            case "1":
            case "Nope!":
                {
                    Console.WriteLine("---");
                    Say("Adventurer", "I have a lunch date planned already.  Maybe some other time.");
                    Console.WriteLine("");
                    Say("Cook", "Oh, great. Just great! I can never count on Adventurers!");
                    Console.WriteLine("");
                    Say("Adventurer", "Best of luck to you and the cake!");
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    gameOver();
                    break;
                }

            case "2":
            case "Yes":
                {
                    Console.WriteLine("---");
                    Console.WriteLine(@"Cook: Oh, thank you for your kindness! 
        I will need all of these ingredients: 
        - Flour
        - Sugar
        - Milk
        - Butter
        - Sardines
        - Eggs.");
                    Console.WriteLine("");
                    Console.WriteLine(@"Adventurer: I'm beginning to regret my decision...  
        Where do I go to find all of these ingredients for the cake?");
                    Console.WriteLine("");
                    Console.WriteLine(@"Cook: You can find the flour and sugar at Marla's Flower Mill.
        It's not far from here. Just take the road and head north.
        The milk and eggs will be at Shelby and Brianne's farm just east of there.
        For the sardines, you'll want to visit Garrett's Fishery to the west.");
                    Console.WriteLine("");
                    Say("Adventurer", "Is that all... I'd better get on my way.");
                    Console.WriteLine("---");
                    Console.WriteLine("");
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
        options = Console.ReadLine()!.ToLower();
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
                    Console.WriteLine("");
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
                    Console.WriteLine("");
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
        choice = Console.ReadLine()!.ToLower();
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
                    Console.WriteLine("*You are swiftly kicked in the head and die.*");
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Enter("Press 'Enter' to continue");
                    Console.ReadLine();
                    gameDead();
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
                    Console.WriteLine("");
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
        Console.WriteLine("*Happy that you have gathered all but the sardines, you make your way to see Garrett's Fishery at the local port.*");
        Console.WriteLine("");
        Console.WriteLine("*You step inside the fishery.");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: Geez, it smells here. Are you Garrett? 
    I'm needing to get some sardines for a birthday cake. 
    Not my preffered topping, but it aint my party either.");
        Console.WriteLine("");
        Console.WriteLine(@"Garrett: Yes, that's me. 
    I'm Garret, and I've got some canned sardines here.
    you're putting sardines in a birthday cake?");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: It's for the Duke. 
    He wants them in his cake for his party.
    Anyway, how much for a can of sardines?");
        Console.WriteLine("");
        Console.WriteLine("*A stray cat walks in, following the scent of the sardines");
        Console.WriteLine("*The cat walks towards you and begins rubbing against your feet.");
        Say("Stray Cat", "Mrow?");
        Console.WriteLine("");
        Say("Garrett", "GET THAT CAT OUTTA HERE!.");
        Console.WriteLine("");
        Console.WriteLine("*Garrett grabs the cat and throws it into the harbor.");
        Console.WriteLine("");
        Say("Airborne Cat", "MROOWWW!");
        Console.WriteLine("*You hear a small splash.*");
        Console.WriteLine("");
        Say("Adventurer", "WHAT IS WRONG WITH YOU?");
        Console.WriteLine("");
        Console.WriteLine(@"Garrett: I hate the cats around here. All of them. 
    They just aren't loyal. Now then, that'll be 3 gold pieces.");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: Why I oughtta THROTTLE ya!
    If I weren't in such a hurry, I'd go get the sardines myself!
    Here's your gold, you twisted nut.");
        Console.WriteLine("");
        Say("Garrett", "Thank you for your patronage.");
        Console.WriteLine("---");
        Console.WriteLine("");
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
        Console.WriteLine(@"Adventurer: I've returned with all of the ingredients you need for the Duke's birthday cake. 
    I'll just drop these on the table here and be on my way.");
        Console.WriteLine("");
        Console.WriteLine(@"Cook: You have saved my life! 
    I can not thank you enough! 
    Wait, where are the birthday candles?");
        Console.WriteLine("");
        Say("Adventurer", "CANDLES?  You didn't say anything about candles!");
        Console.WriteLine("");
        Console.WriteLine(@"Cook: Oh, dear. They must have slipped my mind! 
    I'll also be needing 100 birthday candles for the Duke's cake.
    Could you get those as well? Pretty please?");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: I don't know. 
    There are more adventures out there for me. 
    Many far more important than baking a cake.
    I'm thinking we should just part ways here.");
        Console.WriteLine("---");
        Console.WriteLine("");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
        sixth();
    }
        
    public void sixth()
    {
            Console.WriteLine("---");
            Random rnd = new Random();
            String[] candleOptions = {"The cook does interpretive dancing hoping to woo you into helping.", "The cook offers to let you help him bake the cake if you help him.",
    "The cook falls to the ground and cries at your feet, pleading with you to help him."};
            int randomNumber = rnd.Next(0,3);
            String candleText = candleOptions[randomNumber];

            String candleChoice;

            Console.WriteLine(candleText);
            Console.WriteLine("Do you help the cook by going to pick up; Yes or No?");
            Console.Write("Your Choice: ");
            candleChoice = Console.ReadLine()!.ToLower();

            if (candleChoice == "yes" || candleChoice == "y")
            {
                Console.WriteLine("---");
                Console.WriteLine("Though you want to ditch this loser, you sigh and agree to help him.");
                Console.WriteLine("---");
                Enter("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                seventh();
            }
            else if(candleChoice == "no" || candleChoice == "n")
            {
                Console.WriteLine("---");
                Console.WriteLine("You are through doing his errands and wish him well as you leave.");
                Console.WriteLine("");
                Console.WriteLine("Congratulations!");
                Console.WriteLine("");
                Console.WriteLine("For partial completion of quest, you have earned 1 quest point.");
                Console.WriteLine("---");
                Console.WriteLine("");
                Enter("Press 'Enter' to continue.");
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
        Console.WriteLine("---");
        Say("Adventurer", "Alright, I'll make one more run for you, but that's IT!");
        Console.WriteLine("");
        Say("Cook", "You have my word! You can find all the candles at Edwin's Candle shop. He's Just outside the castle and to the right.");
        Console.WriteLine("");
        Say("Adventurer", "Thank's. I'll be on my way.");
        Console.WriteLine("---");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        eighth();
    }

    public void eighth()
    {
        string choose;

        Console.WriteLine("---");
        Console.WriteLine("*You make a mad dash for the candle shop around the corner*");
        Console.WriteLine("");
        Say("Adventurer", "Edwin, I need 100 candles for the Duke's birthday cake. What've you got?");
        Console.WriteLine("");
        Say("Edwin", "You want em' in red or blue?");
        Console.WriteLine("");
        Say("Adventurer", "It doesn't matter. I just-");
        Say("Edwin", "YES IT DOES! This is for the Duke! Jackson! Our leader! He knows everything that was, is, or will be!");
        Console.WriteLine("");
        Say("Adventurer", "Alright, fine. I'll take 100 blue candles");
        Say("Edwin", "Actually, I think his favorite color is red.");
        Console.WriteLine("---");
        Console.WriteLine("");
        Console.WriteLine("1. Go with your first choice of blue.");
        Console.WriteLine("2. Take Edwin's advice and go with red.");
        Console.Write("Options: ");
        choose = Console.ReadLine()!.ToLower();
        Console.Clear();

        switch (choose)
        {
            case "1":
            case "Go with your first choice of blue.":
                {
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Say("Adventurer", "Nope. Pretty sure he likes blue. Thank you, bye!");
                    Console.WriteLine("");
                    Say("Edwin", "YOU WILL RUE THE DAY YOU DENIED MY ADVICE! RUE. THE. DAAYYY!");
                    Console.WriteLine("");
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    ninth();
                    break;
                }
            
            case "2":
            case "Take Edwin's advice and go with red.":
                {
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Say("Adventurer", "Mmm, okay. If you're sure about this, then I'll take the red candles.");
                    Console.WriteLine("");
                    Say("Edwin", "I knew you'd see it my way. Come again, soon!");
                    Console.WriteLine("");
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    ninth();
                    break;
                }

                default:
                {
                    Enter("Unrecognizable command.  Press 'Enter' to try again.");
                    Console.ReadLine();
                    eighth(); //bringing back to beginning of the eigth method
                    break;
                }
        }
    }

    public void ninth()
    {

        string pick;

        Console.WriteLine("---");
        Console.WriteLine("Exhausted, you arrive at the castle and see party guests making their way inside.");
        Console.WriteLine("");
        Console.WriteLine("*You enter the kitchen and find the cook mixing the ingredients together.*");
        Console.WriteLine("");
        Console.WriteLine(@"Cook: Ah, you're just in time!
    Would you like to help me bake the cake?
    It could be fun... A little bit of quality time.");
        Console.WriteLine("");
        Say("Adventurer", "Oh, what the heck. It could be fun.");
        Console.WriteLine("");
        Console.WriteLine("*You both finish prepping the ingredients and fire up the oven.*");
        Console.WriteLine("");
        Say("Adventurer", "What temperature should the oven be set to?");
        Console.WriteLine("");
        Say("Cook", "450 degrees for 15 minutes.");
        Console.WriteLine("");
        Console.WriteLine(@"Adventurer: Uhh, are you sure about that? 
    That seems far too hot for a cake.
    Why not try 350 for 30 minutes?");
        Console.WriteLine("---");
        Console.WriteLine("");
        Console.WriteLine("1. Bake it at 450 for 15 minutes.");
        Console.WriteLine("2. Bake it at 350 for 30 minutes.");
        Console.Write("Options: ");
        pick = Console.ReadLine()!.ToLower();
        Console.Clear();

        switch (pick)
        {
            case "1":
            case "Bake it at 450 for 15 minutes.":
                {
                    Console.WriteLine("---");
                    Console.WriteLine(@"Cook: Whoooo's the apprentice here? 
    Besides, we don't have time for that! 
    The guests are here and the Duke will want his cake soon!
    Trust me on this one.");
                    Console.WriteLine("");
                    Say("Adventurer", "Well, alright. Here goes nothing.");
                    Console.WriteLine("");
                    Console.WriteLine("*You both place the cake onto the oven and watch anxiously.*");
                    Console.WriteLine("*15 minutes pass and you remove the cake from the oven.*");
                    Console.WriteLine("");
                    Say("Cook", "It's... Burnt...");
                    Console.WriteLine("");
                    Console.WriteLine("*You both slowly look at each other.*");
                    Console.WriteLine("");
                    Console.WriteLine("*Duke Jackson bursts into the kitchen, curious as to what's burning.*");
                    Say("Duke", "What in the world is burning in here!?");
                    Console.WriteLine("");
                    Console.WriteLine("*The Duke sees his ruined cake and squeals.*");
                    Console.WriteLine("");
                    Console.WriteLine(@"Duke: MY CAKE! MY BEAUTIFUL BIRTHDAT CAKE!
    IT'S RUINEEDDD! You two WILL PAY! GUARDS! Execute them AT ONCE!");
                    Console.WriteLine("");
                    Console.WriteLine("*You are both quickly escorted out the back of the castle.*");
                    Console.WriteLine("*Two gunshots ring out as crows fly from a nearby tree.*");
                    Console.WriteLine("");
                    Say("Duke", "What was that? Those noises?");
                    Console.WriteLine("");
                    Say("Guard", "I believe they were gunshots... From a gun, you majesty.");
                    Console.WriteLine("");
                    Say("Duke", "What's a gun?");
                    Console.WriteLine("");
                    Say("Guard", "I don't know.");
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    gameDead();
                    break;
                }

            case "2":
            case "Bake it at 350 for 30 minutes.":
                {
                    Console.WriteLine("---");
                    Console.WriteLine(@"Cook: Whoooo's the apprentice here? 
    Besides, we don't have time for that! 
    The guests are here and the Duke will want his cake soon!
    Trust me on this one.");
                    Console.WriteLine("");
                    Console.WriteLine(@"Adventurer: You've not given me many reasons to trust you.
    Step aside, nerd. I didn't come this far to mess up.
    We're doing this my way.");
                    Console.WriteLine("");
                    Console.WriteLine("*You both place the cake into the oven and watch anxiously.*");
                    Console.WriteLine("*30 minutes pass and you remove the cake from the oven.*");
                    Console.WriteLine("");
                    Console.WriteLine("*The most beautiful birthday cake garnished with fins of sardines glistens before you.*");
                    Console.WriteLine("");
                    Console.WriteLine(@"Cook: It's... PERFECT!
    This is quite possibly the best cake I have ever seen!
    Thank you, Adventurer! Quickly, let's put candles on.
    The Duke will be here any second. You got green candles, right?");
                    Console.WriteLine("");
                    Console.WriteLine("*Duke Jackson bursts in as you hold wrestle the cook into oven.*");
                    Console.WriteLine("");
                    Say("Duke", "What IS that heavenly smell!?");
                    Console.WriteLine("");
                    Console.WriteLine("*You and the Cook freeze and turn to the Duke.");
                    Console.WriteLine("");
                    Console.WriteLine(@"Duke: My cake! It's beautiful!
    This is quite posibly the most beautiful dessert
    I have ever seen in my entire life! The candles are
    placed without flaw! I wish I weren't color blind!");
                    Console.WriteLine("");
                    Console.WriteLine("*You and the Cook glance at each other, then back to the Duke.*");
                    Console.WriteLine("");
                    Say("Duke", "Guards! On your knees and bow to them!");
                    Console.WriteLine("");
                    Console.WriteLine("*You are embraced by the Duke and the party begins!*");
                    Console.WriteLine("---");
                    Console.WriteLine("");
                    Enter("Press 'Enter' to continue.");
                    Console.ReadLine();
                    megaAdventurer();
                    break;

                }

            default:
                {
                    Enter("Unrecognizable command.  Press 'Enter' to try again.");
                    Console.ReadLine();
                    ninth(); //bringing back to beginning of the eigth method
                    break;
                }

        }  
    }

    public void gameOver()
    {
        Console.WriteLine("---");
        Console.Clear();
        Console.WriteLine("*Thanks for playing!*");
        Console.WriteLine("*Try it again?*");
        Console.WriteLine("");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
        gameTitle();   
    }

    public void gameDead()
    {
        Console.WriteLine("---");
        Console.Clear();
        Console.WriteLine("Oh, dear. You are dead!");
        Console.WriteLine("*Try again?*");
        Console.WriteLine("");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
        gameTitle();
    }

    public void megaAdventurer()
    {
        Console.WriteLine("---");
        Console.Clear();
        Console.WriteLine("*Congratulations! Quest complete!*");
        Console.WriteLine("");
        Console.WriteLine("*You are rewarded 1000 gold, 5 quest points, and 800 cooking experience.");
        Console.WriteLine("");
        Console.WriteLine("---");
        Console.WriteLine("");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
        gameEpilouge();
    }

    public void gameEpilouge()
    {
        Console.WriteLine("---");
        Console.WriteLine(@"*The party continues late into the night.
    Despite the storm, fireworks can be heard exploding over the castle,
    all the way to Garrett's Fishery. He sat back in his chair, 
    feet propped up on his desk, carving a piece of wood into a mallard
    for his water fowl collection. Lightning flashes over the water as he
    peers out the window. He grumbles to himself.*");
        Console.WriteLine("");
        Say("Garrett", "Quite the storm tonight... Hmm.");
        Console.WriteLine("");
        Console.WriteLine(@"*He stands up and douses the candle as he leaves the room.
    Lightning flashes again and reveals a small silhouette
    at the end of the pier. A small, but low growl is heard.*");
        Console.WriteLine("");
        Console.WriteLine(@"*Two yellow, glowing eyes open as it's claws extend.*");
        Console.WriteLine("");
        Say("Wet & Vengeful Cat", "Mmmmmmmmmmmrowwmm.");
        Console.WriteLine("---");
        Console.WriteLine("");
        Enter("Press 'Enter' to continue");
        Console.ReadLine();
        Console.Clear();
        gameTitle();
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