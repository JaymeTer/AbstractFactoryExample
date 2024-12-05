using AbstractFactoryExample;
using System;


//Which structure/algorithm/pattern you have chosen. - Abstract Factory
//What your project aims to demonstrate or solve. - Its a examoke of this design pattern being used for nation stats in a fantasy game
//In what situations would your design fail to meet expectations. - To many factories in a large game, or if the stats need alot of user input it may not be ideal.
//In what situations would your design exceed expectations. - Very easy to add new nations to your game with a few clicks.
internal class Program
{
    //simple UI
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a factory:");
        Console.WriteLine("1. EastLandFactory");
        Console.WriteLine("2. SouthLandFactory");
        Console.Write("Enter your choice (1 or 2): ");

        
        string choice = Console.ReadLine();

        IFactory factory; //The main show

        
        if (choice == "1")
        {
            factory = new EastLandFactory();
        }
        else if (choice == "2")
        {
            factory = new SouthLandFactory();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting program.");
            return;
        }

        //Factories A and B
        ILanguage language = factory.CreateLanguage();
        INation nation = factory.CreateNation();

        //Product A and B
        language.Greet();
        Console.WriteLine("Total Military Power: " + nation.GetMilitaryPower());
        Console.WriteLine("Race Ratio: " + string.Join(", ", nation.ListRaceRatio()));

        //Exit
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
