using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        private static string _username;
        private static List<Room> _rooms;
        
        static void Main(string[] args)
        {
            // TODO:
            // Title
            // Rooms
            // Connected Rooms
            // Story / Dialogue
            // Theme
            // Input
            // Obstacles

            _rooms = new List<Room>();

            Room room = new Room();
            room.Description = "My Test Room, it's empty.";
            
            Room room2 = new Room
            {
                Description = "This room smells funny."
            };

            room.ConnectRooms(Direction.Left, room2);
            
            _rooms.Add(room);
            _rooms.Add(room2);
            
            Console.WriteLine("Hello, what is your name?");
            _username = Console.ReadLine();

            Console.WriteLine($"Hello {_username}, do you wanna go on an adventure?" +
                              $"{Environment.NewLine}" +
                              "[Y]es or [N]o");
            
            ConsoleKeyInfo userInput = Console.ReadKey(true);
            if (userInput.KeyChar == 'y')
            {
                while (true)
                {
                    
                }
            }

            Console.WriteLine("Ok then.");
        }
    }
}