using System.Collections.Generic;

namespace TextAdventure
{
    public class Room
    {
        public string Description;
        public Dictionary<Direction, Room> ConnectedRooms;

        public void ConnectRooms(Direction direction, Room room)
        {
            ConnectedRooms?.Add(direction, room);
            room.ConnectedRooms?.Add(Direction.Backward, this);
            
            /* Is the same as the above.
             
            if (ConnectedRooms != null)
            {
                ConnectedRooms.Add(direction, room);
            }
            */
        }
    }
}