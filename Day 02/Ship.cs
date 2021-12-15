
using System;

namespace Day_02
{
    public static class Ship
    {
        public int Position { get; set; }
        public int depth { get; set; }

        public Ship(int StartingPosition = 0, int StartingDepth = 0)
        {
            this.Position = StartingPosition;
            this.depth = StartingDepth;
        }   

        public void forward(int numberToMove){
            Position += numberToMove;
        }

        public void up(int numberToMove){
            depth -= numberToMove;
        }

        public void down(int numberToMove){
            depth += numberToMove;
        }

        public int getEndResult(){
            return Position * depth;
        }

    }
}
