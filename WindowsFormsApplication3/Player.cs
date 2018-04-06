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
<<<<<<< HEAD
          //  Board.Field[destinationX, destinationY] = Color;
=======
            Board.Field[destinationX, destinationY] = Color;
>>>>>>> 7c7eff38e02e32b22bbc9ebb20e20f2de68e6aed
        }
    }
}