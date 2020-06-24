using System;
using System.Collections.Generic;

namespace KnightsTourProblem {
    abstract partial class Method {

        private int[,] result = new int[8, 8];
        private List<int[]> nextMoves = new List<int[]>();
        private Knight knight = new Knight();
        private int nextX_move, nextY_move, moveNo;


        public int[,] Result {
            get { return result; }
            set { result = value; }
        }
        public List<int[]> NextMoves {
            get { return nextMoves; }
            set { nextMoves = value; }
        }

        public Knight Knight {
            get { return knight; }
            set { knight = value; }
        }

        public int MoveNo {
            get { return moveNo; }
            set { moveNo = value; }
        }

        public int NextX_Move {
            get { return nextX_move; }
            set { nextX_move = value; }
        }
        public int NextY_Move {
            get { return nextY_move; }
            set { nextY_move = value; }
        }

        public abstract void makeNextMove();
        public abstract void writeToFile(int trials, int[] moves);

        private bool possibleMoves() {

            for (int i = 0; i < 8; i++) {
                NextX_Move = Knight.CurrentPos[0, 0] + Knight.X_Coor_Moves[i];
                NextY_Move = Knight.CurrentPos[0, 1] + Knight.Y_Coor_Moves[i];

                if (NextX_Move >= 0 && NextX_Move < 8 &&
                    NextY_Move >= 0 && NextY_Move < 8 &&
                    Result[NextX_Move, NextY_Move] == 0) {

                    return true;
                }
            }
            return false;

        }

        private void shuffleCoor() {
            for (int i = 0; i < 8; i++) {
                Random rnd = new Random();
                int rand = rnd.Next(0, 8);
                int tempX = Knight.X_Coor_Moves[i];
                int tempY = Knight.Y_Coor_Moves[i];

                //shuffling x coordinates
                Knight.X_Coor_Moves[i] = Knight.X_Coor_Moves[rand];
                Knight.X_Coor_Moves[rand] = tempX;

                //shuffling y coordinates
                Knight.Y_Coor_Moves[i] = Knight.Y_Coor_Moves[rand];
                Knight.Y_Coor_Moves[rand] = tempY;
            }
        }

        public void calculateNextPossibleMoves() {
            shuffleCoor();
            for (int i = 0; i < 8; i++) {
                nextX_move = Knight.CurrentPos[0, 0] + Knight.X_Coor_Moves[i];
                nextY_move = Knight.CurrentPos[0, 1] + Knight.Y_Coor_Moves[i];

                if (nextX_move >= 0 && nextX_move < 8 &&
                    nextY_move >= 0 && nextY_move < 8 &&
                    Result[nextX_move, nextY_move] == 0) {
                    NextMoves.Add(new int[] { nextX_move, nextY_move });
                }
            }
        }

       
    }
}
