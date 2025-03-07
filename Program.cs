using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AcornQuest14
    {
        class Program
        {
            static void Main(string[] args)
            {
                Game game = new Game();
                game.Start();
            }
        }

        class Game
        {
            private List<string> inventory = new List<string>();
            private Dictionary<string, string> puzzles = new Dictionary<string, string>
        {
            { "key", "Solve the riddle: What has keys but can't open locks?" },
            { "map", "Solve the riddle: What can be seen in the middle of March and April that can't be seen at the beginning or end of either month?" },
            { "lantern", "Solve the riddle: I speak without a mouth and hear without ears. I have no body, but I come alive with wind. What am I?" }
        };

            public void Start()
            {
                Console.WriteLine("Welcome to Acorn Quest!");
                Console.WriteLine("Find the key, map, and lantern to open the door to the acorns.");

                foreach (var puzzle in puzzles)
                {
                    SolvePuzzle(puzzle.Key, puzzle.Value);
                }

                if (inventory.Contains("key") && inventory.Contains("map") && inventory.Contains("lantern"))
                {
                    Console.WriteLine("Congratulations! You have found all the items and opened the door to the acorns!");
                }
                else
                {
                    Console.WriteLine("You did not find all the items. Try again!");
                }
            }

            private void SolvePuzzle(string item, string riddle)
            {
                Console.WriteLine(riddle);
                string answer = Console.ReadLine().ToLower();

                if (IsCorrectAnswer(item, answer))
                {
                    Console.WriteLine($"Correct! You have found the {item}.");
                    inventory.Add(item);
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Try again.");
                    SolvePuzzle(item, riddle);
                }
            }

            private bool IsCorrectAnswer(string item, string answer)
            {
                switch (item)
                {
                    case "key":
                        return answer == "piano";
                    case "map":
                        return answer == "r";
                    case "lantern":
                        return answer == "echo";
                    default:
                        return false;
                }
            }
        }
    }


    

