using System;

namespace Checkers
{
    public class Draught : Player
    {
        public (int X, int Y) Position;
        public string Image { get; private set; }

        public Draught(string name, Color color, int x, int y, string image) : base(name, color)
        {
            Image = image;
            Position.X = x;
            Position.Y = y;
        }
    }
}