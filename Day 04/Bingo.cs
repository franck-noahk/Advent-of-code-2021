using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Day_04
{
    class Bingo
    {
#region Properties
        public int[] NumbersCalled { get; set; }

        public List<int[]> Boards { get; set; }

        private List<bool[]> BoardsActive { get; set; }

        private bool EndGame { get; set; }

        private int[] WinningBoardNumbers { get; set; }

        private bool[] WinningBoardCalled { get; set; }


#endregion



#region Public Methods
        public void PlayGame()
        {
            foreach (int Number in NumbersCalled)
            {
                if (EndGame == false)
                {
                    NumberInBoard (Number);
                    IsGameOver();
                }
                else
                {
                    Console.WriteLine(CalculateFinalNumber());
                }
            }
        }


#endregion



#region Private Methods
        private void NumberInBoard(int NumberCalled)
        {
            // Looping through Boards
            for (int j = 0; j < Boards.Count; j++)
            {
                // Looping through the items in the boards
                for (int i = 0; i < Boards[j].Length; i++)
                {
                    if (Boards[j][i] == NumberCalled)
                    {
                        BoardsActive[j][i] = true;
                    }
                }
            }
        }

        private void IsGameOver()
        {
            for (int i = 0; i < Boards.Count; i++)
            {
                if (
                    IsBingoByRow(BoardsActive[i]) ||
                    IsBingoByColumn(BoardsActive[i])
                )
                {
                    EndGame = true;
                    WinningBoardNumbers = Boards[i];
                    WinningBoardCalled = BoardsActive[i];
                }
            }
        }

        private bool IsBingoByRow(bool[] bools)
        {
            bool toReturn = false;

            for (int i = 0; i < bools.Length; i++)
            {
                if (i % 5 == 0 && i < bools.Length - 5)
                {
                    if (
                        bools[i] &&
                        bools[i + 1] &&
                        bools[i + 2] &&
                        bools[i + 3] &&
                        bools[i + 4]
                    )
                    {
                        toReturn = true;
                    }
                }
            }

            return toReturn;
        }

        private bool IsBingoByColumn(bool[] bools)
        {
            bool toReturn = false;

            for (int i = 0; i < 5; i++)
            {
                if (
                    bools[i] &&
                    bools[i + 5] &&
                    bools[i + 10] &&
                    bools[i + 15] &&
                    bools[i + 20]
                )
                {
                    toReturn = true;
                }
            }

            return toReturn;
        }

        private int CalculateFinalNumber()
        {
            int ToReturn = 0;

            int called = 0;
            int notCalled = 0;

            for (int i = 0; i < WinningBoardCalled.Length; i++)
            {
                if (WinningBoardCalled[i])
                {
                    called += WinningBoardNumbers[i];
                }
                else
                {
                    notCalled += WinningBoardNumbers[i];
                }
            }

            ToReturn = called * notCalled;

            return ToReturn;
        }
#endregion
    }
}
