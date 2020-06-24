namespace KnightsTourProblem {
    partial class KnightsTourProblem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noOfTImesToRunProg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.x_Coor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_intellMethod = new System.Windows.Forms.Button();
            this.btn_nonIntellMethod = new System.Windows.Forms.Button();
            this.y_Coor = new System.Windows.Forms.TextBox();
            this.richTB_knightMoves = new System.Windows.Forms.RichTextBox();
            this.resultStatus = new System.Windows.Forms.StatusStrip();
            this.resultStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.resultStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Knight\'s Tour Problem!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 4;
            // 
            // noOfTImesToRunProg
            // 
            this.noOfTImesToRunProg.Location = new System.Drawing.Point(400, 67);
            this.noOfTImesToRunProg.Name = "noOfTImesToRunProg";
            this.noOfTImesToRunProg.Size = new System.Drawing.Size(49, 22);
            this.noOfTImesToRunProg.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // x_Coor
            // 
            this.x_Coor.Location = new System.Drawing.Point(267, 113);
            this.x_Coor.Name = "x_Coor";
            this.x_Coor.Size = new System.Drawing.Size(39, 22);
            this.x_Coor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Enter the number of times you want the program to run";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Enter Knight\'s Starting Position:";
            // 
            // btn_intellMethod
            // 
            this.btn_intellMethod.Location = new System.Drawing.Point(667, 232);
            this.btn_intellMethod.Name = "btn_intellMethod";
            this.btn_intellMethod.Size = new System.Drawing.Size(136, 38);
            this.btn_intellMethod.TabIndex = 15;
            this.btn_intellMethod.Text = "Intelligent Method";
            this.btn_intellMethod.UseVisualStyleBackColor = true;
            this.btn_intellMethod.Click += new System.EventHandler(this.btn_intellMethod_Click);
            // 
            // btn_nonIntellMethod
            // 
            this.btn_nonIntellMethod.Location = new System.Drawing.Point(667, 325);
            this.btn_nonIntellMethod.Name = "btn_nonIntellMethod";
            this.btn_nonIntellMethod.Size = new System.Drawing.Size(136, 43);
            this.btn_nonIntellMethod.TabIndex = 16;
            this.btn_nonIntellMethod.Text = "Non Intelligent Method";
            this.btn_nonIntellMethod.UseVisualStyleBackColor = true;
            this.btn_nonIntellMethod.Click += new System.EventHandler(this.btn_nonIntellMethod_Click);
            // 
            // y_Coor
            // 
            this.y_Coor.Location = new System.Drawing.Point(335, 113);
            this.y_Coor.Name = "y_Coor";
            this.y_Coor.Size = new System.Drawing.Size(39, 22);
            this.y_Coor.TabIndex = 17;
            // 
            // richTB_knightMoves
            // 
            this.richTB_knightMoves.Location = new System.Drawing.Point(44, 163);
            this.richTB_knightMoves.Name = "richTB_knightMoves";
            this.richTB_knightMoves.Size = new System.Drawing.Size(592, 274);
            this.richTB_knightMoves.TabIndex = 18;
            this.richTB_knightMoves.Text = "";
            // 
            // resultStatus
            // 
            this.resultStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.resultStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultStatusLbl});
            this.resultStatus.Location = new System.Drawing.Point(0, 451);
            this.resultStatus.Name = "resultStatus";
            this.resultStatus.Size = new System.Drawing.Size(815, 26);
            this.resultStatus.TabIndex = 20;
            this.resultStatus.Text = "Status";
            // 
            // resultStatusLbl
            // 
            this.resultStatusLbl.Name = "resultStatusLbl";
            this.resultStatusLbl.Size = new System.Drawing.Size(105, 20);
            this.resultStatusLbl.Text = "resultStatusLbl";
            // 
            // KnightsTourProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 477);
            this.Controls.Add(this.resultStatus);
            this.Controls.Add(this.richTB_knightMoves);
            this.Controls.Add(this.y_Coor);
            this.Controls.Add(this.btn_nonIntellMethod);
            this.Controls.Add(this.btn_intellMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x_Coor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfTImesToRunProg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "KnightsTourProblem";
            this.Text = "Knight\'s Tour Problem";
            this.Load += new System.EventHandler(this.KnightsTourProblem_Load);
            this.resultStatus.ResumeLayout(false);
            this.resultStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox noOfTImesToRunProg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x_Coor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_intellMethod;
        private System.Windows.Forms.Button btn_nonIntellMethod;
        private System.Windows.Forms.TextBox y_Coor;
        private System.Windows.Forms.RichTextBox richTB_knightMoves;
        private System.Windows.Forms.StatusStrip resultStatus;
        private System.Windows.Forms.ToolStripStatusLabel resultStatusLbl;
    }
}

