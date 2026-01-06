using System.Reflection.Metadata.Ecma335;

namespace Dictionaries;

class Room
{
    internal int x, y;
    internal string[] level;

    internal Room(int x, int y, string [] level)
    {
        this.x = x;
        this.y = y;
        this.level = level;
    }

    internal Function GetRoomLocationKey()
    {
        return $"{x}, {y}";
    }
} 