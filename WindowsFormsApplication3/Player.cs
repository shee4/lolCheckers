using System.Drawing;

namespace WindowsFormsApplication3
{
    public class Player
    {
        public readonly string Name;
        public int Color = 0;
        // black = 1; 
        // white = 2; 
        // null = 0; 
        public bool Queen = false;
        public bool IsQueen
        { get; set; }
        public Player(string name, int color)
        {
            this.Name = name;
            this.Color = color;
        }
        public void Move(int destinationX, int destinationY)
        {
          //  Board.Field[destinationX, destinationY] = Color;
        }
    }
}