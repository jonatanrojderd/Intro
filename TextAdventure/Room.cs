using System.Collections.Generic;

namespace TextAdventure
{
    /// <summary>
    /// This class is used to define a Room.
    /// </summary>
    public class Room
    {
        /// <summary>
        /// The description that can be used to display text in the Console.
        /// </summary>
        public string Description;
        
        /// <summary>
        /// The connected rooms.
        /// </summary>
        public Dictionary<Direction, Room> ConnectedRooms;

        // A parameterless Constructor that will initialize the ConnectedRooms field
        // with an empty Dictionary.
        public Room()
        {
            ConnectedRooms = new Dictionary<Direction, Room>();
        }

        // A Constructor with one parameter to assign the Description field at creation.
        public Room(string description)
        {
            Description = description;
            ConnectedRooms = new Dictionary<Direction, Room>();
        }

        /// <summary>
        /// Connect the specified Room and Direction to the Room calling this method.
        /// This will also add itself as a connected room with Backward as it's Direction.
        /// </summary>
        /// <param name="direction">The direction to the next room.</param>
        /// <param name="room">The room to connect.</param>
        public void ConnectRooms(Direction direction, Room room)
        {
            ConnectedRooms.Add(direction, room);
            room.ConnectedRooms.Add(Direction.Backward, this);
        }
    }
}