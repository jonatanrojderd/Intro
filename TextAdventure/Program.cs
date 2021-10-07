using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class Program
    {
        // Declare private fields, these can be used anywhere inside the Program class.
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

            /* Example on how to define and initialize a custom created type. (The Room class) */
            Room startingRoom = new Room();
            startingRoom.Description = "My Test Room, it's empty.";

            // This is called Object Initializer.
            Room anotherRoom = new Room
            {
                Description = "This room smells funny."
            };

            Room theThirdRoom = new Room("This is a third room.");

            startingRoom.ConnectRooms(Direction.Left, anotherRoom);
            anotherRoom.ConnectRooms(Direction.Forward, theThirdRoom);

            // Initialize the List of Rooms, this is called Collection Initializer.
            _rooms = new List<Room>
            {
                startingRoom,
                anotherRoom,
                theThirdRoom
            };

            Console.WriteLine("Hello, what is your name?");

            // Store the input that the User enters into the _username field.
            _username = Console.ReadLine();

            Console.WriteLine($"Hello {_username}, do you wanna go on an adventure?" +
                              $"{Environment.NewLine}" +
                              "[Y]es or [N]o" +
                              $"{Environment.NewLine}");

            // BUG: There's a bug here, what happens if the user doesn't press Y or N?
            ConsoleKeyInfo userInput = Console.ReadKey(true);
            if (userInput.KeyChar == 'n')
            {
                Console.WriteLine("Ok then.");
                return;
            }

            if (userInput.KeyChar == 'y')
            {
                Room currentRoom = _rooms[0];
                while (true)
                {
                    Console.WriteLine(currentRoom.Description);
                    Console.WriteLine($"Where do you want to go?{Environment.NewLine}");

                    /* Iterate through the Connected Rooms Dictionary in the Current Room object
                     * and display the possible Directions in that Room.
                     */
                    foreach (var connectedRoom in currentRoom.ConnectedRooms)
                    {
                        Console.WriteLine(connectedRoom.Key);
                    }

                    /* Get the input from the User and try to parse the value,
                     * using Enum.TryParse( ... ) - if it fails, then display a message.
                     *
                     * The second value is true because we don't want
                     * case sensitivity when we're trying to parse the input.
                     * 
                     * (Note that we can use the var keyword instead of the actual type
                     *  IF the variable is defined and assigned at the same time).
                     */
                    Direction direction;
                    var input = Console.ReadLine();
                    while (!Enum.TryParse(input, true, out direction))
                    {
                        Console.WriteLine($"I don't know what {input} is.");
                        input = Console.ReadLine();
                    }

                    /* Iterate through the Connected Rooms in the Current Room,
                     * and if the selected direction match any Direction (connectedRoom.Key) in the Dictionary
                     * then set that Room (connectedRoom.Value) as the Current Room.
                     */
                    foreach (var connectedRoom in currentRoom.ConnectedRooms)
                    {
                        if (connectedRoom.Key.Equals(direction))
                        {
                            currentRoom = connectedRoom.Value;
                        }
                    }

                    /* Here we use Console.Write( ... ) instead of Console.WriteLine( ... ),
                     * because we might not want to have two new lines when using the
                     * Environment.NewLine property (or by writing '\n').
                    */
                    Console.Write(Environment.NewLine);
                }
            }
        }
    }
}