namespace Checkers 
{ 
    public class Player 
    { 
        public readonly string Name;
        public Color Color;
// black = 1; blackQueen = 11; 

 
        public bool Queen; 
        public bool IsQueen 
        { 
            get => Queen;
            set 
            { 
                Queen = value;
                var c = (int)Color * 11;
                Color = (Color) c;
            }

        } 
        public Player(string name, Color color) 
        { 
            Name = name; 
            Color = color; 
        } 
        public void Move(int destinationX, int destinationY) 
        { 
            Board.Field[destinationX, destinationY] = (int)Color; 
        } 
    } 
}