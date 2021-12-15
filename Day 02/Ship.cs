
using System;

namespace Day_02
{
    public class Ship
    {
        public int Position { get; set; }
        public int depth { get; set; }
        public int aim { get; set; }

        public Ship(int StartingPosition = 0, int StartingDepth = 0)
        {
            this.Position = StartingPosition;
            this.depth = StartingDepth;
        }   

        public void forward(int numberToMove){
            Position += numberToMove;
            depth += numberToMove * aim;
        }

        public void up(int numberToMove){
            aim -= numberToMove;
        }

        public void down(int numberToMove){
            aim += numberToMove;
        }

        public int getEndResult(){
            Console.WriteLine($"Position: {Position}\tDepth:{depth}\tAim: {aim}");
            return Position * depth;
        }
        override
        public String ToString(){
            return $"Depth: {depth}\tPosition: {Position}";
        }

    }
}
