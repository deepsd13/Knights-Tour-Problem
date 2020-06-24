using System;
using System.IO;


namespace KnightsTourProblem {

    class NonIntelligentMethod : Method {

        public override void makeNextMove() {


            calculateNextPossibleMoves();

            if (NextMoves.Count != 0) {
                Random rnd = new Random();
                int nextMove = rnd.Next(0, NextMoves.Count);
                NextX_Move = NextMoves[nextMove][0];
                NextY_Move = NextMoves[nextMove][1];

                Result[NextX_Move, NextY_Move] = MoveNo;
                Knight.CurrentPos[0, 0] = NextX_Move;
                Knight.CurrentPos[0, 1] = NextY_Move;
                MoveNo++;
                NextMoves.Clear();
            }
        }

        public override void writeToFile(int trials, int[] moves) {
            string file = @"..\..\DeepShahNonIntelligentMethod.txt";
            File.WriteAllText(file, string.Empty); //clearing the file before writing to it

            string[] result = new string[trials];

            for (int i = 1; i <= trials; i++) {
                result[i - 1] = "Trial " + i + ": The knight was able to successfully touch " + moves[i-1] + " squares";
            }

            File.WriteAllLines(file, result);
        }
    }
}
