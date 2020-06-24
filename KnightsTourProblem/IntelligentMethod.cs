using System;
using System.Collections.Generic;
using System.IO;


namespace KnightsTourProblem {
   partial class IntelligentMethod : Method {

        public override void makeNextMove() {

            calculateNextPossibleMoves();

            if (NextMoves.Count != 0) {

                int[,] nextMoveCoor = getLeastAccessibilityCoor(NextMoves);

                NextX_Move = nextMoveCoor[0, 0];
                NextY_Move = nextMoveCoor[0, 1];

                Result[NextX_Move, NextY_Move] = MoveNo;
                Knight.CurrentPos[0, 0] = NextX_Move;
                Knight.CurrentPos[0, 1] = NextY_Move;
                MoveNo++;
                NextMoves.Clear();
            }
        }

        public int[,] getLeastAccessibilityCoor(List<int[]> nextMoves) {
            int[,] leastAccessibilityCoor = { { nextMoves[0][0], nextMoves[0][1] } };

            for (int i = 0; i < nextMoves.Count; i++) {
                int x_coor = nextMoves[i][0];
                int y_coor = nextMoves[i][1];
                if (getAccessibilityNumber(x_coor, y_coor) <
                    getAccessibilityNumber(leastAccessibilityCoor[0, 0], leastAccessibilityCoor[0, 1])) {
                    leastAccessibilityCoor[0, 0] = x_coor;
                    leastAccessibilityCoor[0, 1] = y_coor;
                } else if (getAccessibilityNumber(x_coor, y_coor) ==
                    getAccessibilityNumber(leastAccessibilityCoor[0, 0], leastAccessibilityCoor[0, 1])) {
                    Random rnd = new Random();
                    int rand = rnd.Next();
                    if (rand % 2 == 0) {
                        leastAccessibilityCoor[0, 0] = x_coor;
                        leastAccessibilityCoor[0, 1] = y_coor;
                    }
                }
            }

            return leastAccessibilityCoor;
        }

        public int getAccessibilityNumber(int x_coor, int y_coor) {

            int[,] accessibility = {{2, 3, 4, 4, 4, 4, 3, 2},
                                    {3, 4, 6, 6, 6, 6, 4, 3},
                                    {4, 6, 8, 8, 8, 8, 6, 4},
                                    {4, 6, 8, 8, 8, 8, 6, 4},
                                    {4, 6, 8, 8, 8, 8, 6, 4},
                                    {4, 6, 8, 8, 8, 8, 6, 4},
                                    {3, 4, 6, 6, 6, 6, 4, 3},
                                    {2, 3, 4, 4, 4, 4, 3, 2}};
            return accessibility[x_coor, y_coor];
        }

        public override void writeToFile(int trials, int[] moves) {
            string file = @"..\..\DeepShahIntelligentMethod.txt";

            File.WriteAllText(file, string.Empty); //clearing the file before writing to it
            string[] result =  new string[trials];

            for( int i = 1;i<=trials; i++) {
                result[i - 1] = "Trial " + i + ": The knight was able to successfully touch " + moves[i-1]+" squares";
            }

            File.WriteAllLines(file, result);


        }
    }
}
