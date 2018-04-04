

using System;

namespace Checkers 
{ 
    public class Board 
    { 
        public static int[,] Field = new int[8,8]; 
        public void InitialiseBoard() 
        { 
            for (var i = 0; i < 8; i++)
            for (var j = 0; j < 8; j++)
                if (i + j % 2 == 0)
                {
                    Field[i, j] = 0;
                }
                else Field[i, j] = 1;
        } 

        public bool CheckJump(Player player, Tuple<int, int> position) 
        { 
// TODO: think about it! 
            return true; 
        } 
    } 
}