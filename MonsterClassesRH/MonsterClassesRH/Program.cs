using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClassesRH
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOpeningScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static LavaMonster InitializeLavaMonster()
        {
            return new LavaMonster()
            {
                Id = 444,
                Name = "Johannes",
                Age = 420,
                IsActive = true,
                HasFury = true

            };
        }


        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 357,
                Name = "Lannerbeck",
                Age = 500,
                HasGills = true,
                IsActive = true,
                SeaName = "Crystal Lake"

            };

        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 400,
                Name = "Yngwie",
                Age = 500,
                IsActive = true,
                HasSpaceShip = true
            };
        }

        private static void DisplayMenu()
        {
            DisplayHeader("Menu");
            bool exiting = false;

            string menuchoice;
            SeaMonster Lannerbeck = InitializeSeaMonster();
            SpaceMonster Yngwie = InitializeSpaceMonster();
            LavaMonster Johannes = InitializeLavaMonster();

            while (!exiting)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                DisplayHeader("Main Menu");
                Console.WriteLine();
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine();
                Console.WriteLine("2) Exit");
                Console.WriteLine();
                Console.WriteLine("Enter Choice");
                Console.WriteLine();
                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {
                    case "1":Console.Clear();
                        DisplayMonsterInfoScreen(Lannerbeck, Yngwie, Johannes);
                        break;
                    case "2":exiting = true;                
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid choice");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } 
        }

        static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, LavaMonster lavaMonster)
        {
            DisplayHeader("Monster Info");

            DisplaySeaMonster(seaMonster);

            Console.WriteLine();

            DisplaySpaceMonster(spaceMonster);

            Console.WriteLine();

            DisplayLavaMonster(lavaMonster);

            Console.WriteLine();


            DisplayContinuePrompt();
        }

        static void DisplayLavaMonster(LavaMonster lavaMonster)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            DisplayHeader("Monster Info");

            Console.WriteLine(">> Lava Monster");
            Console.WriteLine();
            Console.WriteLine($"Id: {lavaMonster.Id}");
            Console.WriteLine();
            Console.WriteLine($"Name: {lavaMonster.Name}");
            Console.WriteLine();
            Console.WriteLine($"Age: {lavaMonster.Age} Years Old");
            Console.WriteLine();
            Console.WriteLine($"Is Active: {(lavaMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Is Happy: {(lavaMonster.IsHungry() ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Has Fury: {(lavaMonster.HasFury ? "Yes" : "No")}");
            Console.WriteLine();


            lavaMonster.Greeting();

            Console.WriteLine($"You attack {lavaMonster.Name}, and they {lavaMonster.MonsterBattleResponse()}");
            Console.WriteLine();

            lavaMonster.Farewell();

            Console.ReadKey();

            Console.Clear();
        }

        static void DisplaySpaceMonster(SpaceMonster spaceMonster)
        {
            Console.ForegroundColor = ConsoleColor.White;

            DisplayHeader("Monster Info");

            Console.WriteLine(">> Space Monster");
            Console.WriteLine();
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine();
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine();
            Console.WriteLine($"Age: {spaceMonster.Age} Years Old");
            Console.WriteLine();
            Console.WriteLine($"Is Active: {(spaceMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Is Happy: {(spaceMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Is Hungry: {(spaceMonster.IsHungry() ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Has Spaceship: {(spaceMonster.HasSpaceShip ? "Yes" : "No")}");
            Console.WriteLine();

            spaceMonster.Greeting();

            Console.WriteLine($"You attack {spaceMonster.Name}, and they {spaceMonster.MonsterBattleResponse()}");
            Console.WriteLine();

            spaceMonster.Farewell();

            Console.ReadKey();

            Console.Clear();
        }

        private static void DisplaySeaMonster(SeaMonster seaMonster)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            DisplayHeader("Monster Info");

            Console.WriteLine(">> Sea Monster");
            Console.WriteLine();
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine();
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine();
            Console.WriteLine($"Age: {seaMonster.Age} Years Old");
            Console.WriteLine();
            Console.WriteLine($"Is Active: {(seaMonster.IsActive ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Is Happy: {(seaMonster.IsHappy() ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Is Hungry: {(seaMonster.IsHungry() ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Has Gills: {(seaMonster.HasGills ? "Yes" : "No")}");
            Console.WriteLine();
            Console.WriteLine($"Home Sea: {seaMonster.SeaName}");
            Console.WriteLine();

            seaMonster.Greeting();

            Console.WriteLine($"You attack {seaMonster.Name}, and they {seaMonster.MonsterBattleResponse()}");

            seaMonster.Farewell();

            Console.ReadKey();

            Console.Clear();
        }


        #region HELPER METHODS

        /// <summary>
        /// display opening screen
        /// </summary>
        static void DisplayOpeningScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine("\t\tWelcome to My monster app.");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display closing screen
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("\t\tThank You for using My monster application.");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// display header
        /// </summary>
        static void DisplayHeader(string headerTitle)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerTitle);
            Console.WriteLine();
        }

        #endregion
    }
}
