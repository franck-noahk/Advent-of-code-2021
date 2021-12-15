
using System;

namespace Day_02
{
    public class Ship
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
            Console.WriteLine(this.ToString());
        }

        public void up(int numberToMove){
            depth -= numberToMove;
            Console.WriteLine(this.ToString());
        }

        public void down(int numberToMove){
            depth += numberToMove;
            Console.WriteLine(this.ToString());
        }

        public int getEndResult(){
            Console.WriteLine(this.GetType());
            return Position * depth;
        }
        override
        public String ToString(){
            return $"Depth: {depth}\tPosition: {Position}";
        }

    }
}
