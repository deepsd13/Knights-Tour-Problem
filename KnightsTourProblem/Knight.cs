using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTourProblem {
    class Knight {

        private int[] x_coor_moves = { 2, 1, -1, -2, -2, -1, 1, 2 };
        private int[] y_coor_moves = { -1, -2, -2, -1, 1, 2, 2, 1 };
        private int[,] currentPos = new int[1, 2] { { 0, 0 } };

        public int[] X_Coor_Moves {
            get { return x_coor_moves; }
            set { x_coor_moves = value; }
        }
        public int[] Y_Coor_Moves {
            get { return y_coor_moves; }
            set { y_coor_moves = value; }
        }
        public int[,] CurrentPos {
            get { return currentPos; }
            set { currentPos = value; }
        }
    }
}
