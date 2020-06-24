using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace KnightsTourProblem {
    abstract partial class Method {

        public void runMethod(Method met, int run, int x, int y, RichTextBox rTb, ToolStripStatusLabel resultlbl) {

            int[] moves = new int[run]; //stores total moves made in each runs
            double totalMoves = 0; //combination of all moves made in each runs.

            setToDefault(met, x, y);

            for (int k = 1; k <= run; k++) {
                while (met.possibleMoves()) {
                    met.makeNextMove();
                }
                rTb.Text += "Trial " + k + " :\n\n";
                met.printResult(rTb);

                moves[k - 1] = moveNo-1;
                setToDefault(met, x, y);


            }

            for (int i = 0; i < moves.Length; i++) {
                totalMoves += moves[i];
            }

            met.writeToFile(run, moves);

            if (run > 1) {

                double average = totalMoves / run;
                double standardDev = met.calculateSDA(average, run, moves);

                resultlbl.Text = string.Format("The average is {0: 0.00} and the standard deviation is {1: 0.00}", average, standardDev);
            } else {
                resultlbl.Text = "";
            }

        }

        private void printResult(RichTextBox rchTb) {

            //printing all the moves knight made
            for (int i = 0; i < result.GetLength(0); i++) {
                for (int j = 0; j < result.GetLength(1); j++) {
                    rchTb.Text += (result[i, j] + "\t");
                }
                rchTb.Text += "\n";
            }
            rchTb.Text += "\n\n";
        }

        private double calculateSDA(double average, int run, int[] moves) {
            double mean = 0, variance, standarDev;

            for (int i = 0; i < moves.Length; i++) {
                mean += Math.Pow(moves[i] - average, 2);
            }

            variance = mean / run;
            standarDev = Math.Sqrt(variance);

            return standarDev;
        }

        public void  setToDefault(Method met, int x, int y) {

            for (int i = 0; i < met.Result.GetLength(0); i++) {
                for (int j = 0; j < met.Result.GetLength(1); j++) {
                    met.Result[i, j] = 0;
                }
            }

            met.Result[x, y] = 1;
            met.Knight.CurrentPos[0, 0] = x;
            met.Knight.CurrentPos[0, 1] = y;
            met.MoveNo = 2;

        }
    }
}
