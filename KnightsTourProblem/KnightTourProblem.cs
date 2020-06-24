using System;
using System.Windows.Forms;

namespace KnightsTourProblem {
    public partial class KnightsTourProblem : Form {
        public KnightsTourProblem() {
            InitializeComponent();
        }

        private void KnightsTourProblem_Load(object sender, EventArgs e) {
            // knights default position
            x_Coor.Text = "0";
            y_Coor.Text = "0";
            resultStatusLbl.Text = "";
        }

        private void btn_intellMethod_Click(object sender, EventArgs e) {
            try {
                ValidateUserInput();
                int run = Convert.ToInt32(noOfTImesToRunProg.Text);
                int x = Convert.ToInt32(x_Coor.Text);
                int y = Convert.ToInt32(y_Coor.Text);

                richTB_knightMoves.Clear();

                IntelligentMethod intellMethd = new IntelligentMethod();
                intellMethd.runMethod(intellMethd, run, x, y, richTB_knightMoves, resultStatusLbl);

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message + " Please check your inputs and try again!", "ERROR!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (IndexOutOfRangeException ex) {
                MessageBox.Show(ex.Message, "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_nonIntellMethod_Click(object sender, EventArgs e) {
            try {
                ValidateUserInput();
                int run = Convert.ToInt32(noOfTImesToRunProg.Text);
                int x = Convert.ToInt32(x_Coor.Text);
                int y = Convert.ToInt32(y_Coor.Text);

                richTB_knightMoves.Clear();

                NonIntelligentMethod nonIntellMethd = new NonIntelligentMethod();
                nonIntellMethd.runMethod(nonIntellMethd, run, x, y, richTB_knightMoves, resultStatusLbl);

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message + " Please check your inputs and try again!", "ERROR!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (IndexOutOfRangeException ex) {
                MessageBox.Show(ex.Message, "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "ERROR!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ValidateUserInput() {

            if (noOfTImesToRunProg.Text == "") {
                throw new Exception("Please enter the number of times you want the program to run!");
            } else if (Convert.ToInt32(x_Coor.Text) < 0 || Convert.ToInt32(x_Coor.Text) >= 8 || Convert.ToInt32(y_Coor.Text) < 0 ||
                     Convert.ToInt32(y_Coor.Text) >= 8) {
                throw new IndexOutOfRangeException("The knights coordinate needs to be between 0 and 7!");
            }else if(Convert.ToInt32(noOfTImesToRunProg.Text)<1){
                throw new Exception("The number of times the program should run must be a postive number greater than 0!");
            }
        }

    }
}

