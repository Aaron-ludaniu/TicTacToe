namespace TicTacToe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGridSize = new Label();
            lblRound = new Label();
            lblScoreBoard = new Label();
            textBoxRound = new TextBox();
            lblPlayerOne = new Label();
            lblPlayerTwo = new Label();
            btnNewGame = new Button();
            btnExit = new Button();
            picBoxCircle = new PictureBox();
            txtBoxPlayerOneScore = new TextBox();
            txtBoxPlayerTwoScore = new TextBox();
            picBoxPlayerOneAccolade = new PictureBox();
            picBoxX = new PictureBox();
            picBoxPlayerTwoAccolade = new PictureBox();
            comboBoxGridSize = new ComboBox();
            groupBoxPlayerOne = new GroupBox();
            groupBoxPlayerTwo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayerOneAccolade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayerTwoAccolade).BeginInit();
            groupBoxPlayerOne.SuspendLayout();
            groupBoxPlayerTwo.SuspendLayout();
            SuspendLayout();
            // 
            // lblGridSize
            // 
            lblGridSize.AutoSize = true;
            lblGridSize.BackColor = Color.Indigo;
            lblGridSize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridSize.ForeColor = SystemColors.Control;
            lblGridSize.Location = new Point(862, 49);
            lblGridSize.Name = "lblGridSize";
            lblGridSize.Size = new Size(133, 38);
            lblGridSize.TabIndex = 0;
            lblGridSize.Text = "Grid Size";
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.BackColor = Color.Indigo;
            lblRound.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRound.ForeColor = SystemColors.Control;
            lblRound.Location = new Point(862, 114);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(102, 38);
            lblRound.TabIndex = 1;
            lblRound.Text = "Round";
            // 
            // lblScoreBoard
            // 
            lblScoreBoard.BackColor = Color.Indigo;
            lblScoreBoard.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreBoard.ForeColor = SystemColors.Control;
            lblScoreBoard.Location = new Point(862, 174);
            lblScoreBoard.Name = "lblScoreBoard";
            lblScoreBoard.Size = new Size(358, 64);
            lblScoreBoard.TabIndex = 2;
            lblScoreBoard.Text = "Score Board";
            lblScoreBoard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxRound
            // 
            textBoxRound.BackColor = Color.Indigo;
            textBoxRound.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxRound.ForeColor = SystemColors.Control;
            textBoxRound.Location = new Point(1017, 111);
            textBoxRound.Name = "textBoxRound";
            textBoxRound.ReadOnly = true;
            textBoxRound.Size = new Size(202, 45);
            textBoxRound.TabIndex = 20;
            textBoxRound.Text = "0";
            textBoxRound.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPlayerOne
            // 
            lblPlayerOne.BackColor = Color.White;
            lblPlayerOne.BorderStyle = BorderStyle.FixedSingle;
            lblPlayerOne.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerOne.ForeColor = Color.Indigo;
            lblPlayerOne.Location = new Point(0, -3);
            lblPlayerOne.Name = "lblPlayerOne";
            lblPlayerOne.Size = new Size(183, 54);
            lblPlayerOne.TabIndex = 5;
            lblPlayerOne.Text = "Player 1";
            lblPlayerOne.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwo
            // 
            lblPlayerTwo.BackColor = Color.White;
            lblPlayerTwo.BorderStyle = BorderStyle.FixedSingle;
            lblPlayerTwo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerTwo.ForeColor = Color.Indigo;
            lblPlayerTwo.Location = new Point(0, -3);
            lblPlayerTwo.Name = "lblPlayerTwo";
            lblPlayerTwo.Size = new Size(175, 54);
            lblPlayerTwo.TabIndex = 6;
            lblPlayerTwo.Text = "Player 2";
            lblPlayerTwo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = Color.Indigo;
            btnNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewGame.ForeColor = SystemColors.Control;
            btnNewGame.Location = new Point(862, 592);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(358, 58);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "Start a New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Indigo;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(862, 674);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(358, 52);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // picBoxCircle
            // 
            picBoxCircle.BackColor = Color.White;
            picBoxCircle.Location = new Point(49, 75);
            picBoxCircle.Name = "picBoxCircle";
            picBoxCircle.Size = new Size(84, 73);
            picBoxCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCircle.TabIndex = 9;
            picBoxCircle.TabStop = false;
            // 
            // txtBoxPlayerOneScore
            // 
            txtBoxPlayerOneScore.BackColor = Color.White;
            txtBoxPlayerOneScore.BorderStyle = BorderStyle.None;
            txtBoxPlayerOneScore.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxPlayerOneScore.ForeColor = Color.Indigo;
            txtBoxPlayerOneScore.Location = new Point(5, 149);
            txtBoxPlayerOneScore.Name = "txtBoxPlayerOneScore";
            txtBoxPlayerOneScore.ReadOnly = true;
            txtBoxPlayerOneScore.Size = new Size(172, 63);
            txtBoxPlayerOneScore.TabIndex = 11;
            txtBoxPlayerOneScore.Text = "0";
            txtBoxPlayerOneScore.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxPlayerTwoScore
            // 
            txtBoxPlayerTwoScore.BackColor = Color.White;
            txtBoxPlayerTwoScore.BorderStyle = BorderStyle.None;
            txtBoxPlayerTwoScore.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxPlayerTwoScore.ForeColor = Color.Indigo;
            txtBoxPlayerTwoScore.Location = new Point(5, 149);
            txtBoxPlayerTwoScore.Name = "txtBoxPlayerTwoScore";
            txtBoxPlayerTwoScore.ReadOnly = true;
            txtBoxPlayerTwoScore.Size = new Size(165, 63);
            txtBoxPlayerTwoScore.TabIndex = 12;
            txtBoxPlayerTwoScore.Text = "0";
            txtBoxPlayerTwoScore.TextAlign = HorizontalAlignment.Center;
            // 
            // picBoxPlayerOneAccolade
            // 
            picBoxPlayerOneAccolade.BackColor = Color.White;
            picBoxPlayerOneAccolade.Location = new Point(43, 216);
            picBoxPlayerOneAccolade.Name = "picBoxPlayerOneAccolade";
            picBoxPlayerOneAccolade.Size = new Size(98, 84);
            picBoxPlayerOneAccolade.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayerOneAccolade.TabIndex = 13;
            picBoxPlayerOneAccolade.TabStop = false;
            // 
            // picBoxX
            // 
            picBoxX.BackColor = Color.White;
            picBoxX.Location = new Point(43, 75);
            picBoxX.Name = "picBoxX";
            picBoxX.Size = new Size(84, 73);
            picBoxX.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxX.TabIndex = 14;
            picBoxX.TabStop = false;
            // 
            // picBoxPlayerTwoAccolade
            // 
            picBoxPlayerTwoAccolade.BackColor = Color.White;
            picBoxPlayerTwoAccolade.Location = new Point(36, 216);
            picBoxPlayerTwoAccolade.Name = "picBoxPlayerTwoAccolade";
            picBoxPlayerTwoAccolade.Size = new Size(98, 84);
            picBoxPlayerTwoAccolade.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayerTwoAccolade.TabIndex = 15;
            picBoxPlayerTwoAccolade.TabStop = false;
            // 
            // comboBoxGridSize
            // 
            comboBoxGridSize.BackColor = Color.Indigo;
            comboBoxGridSize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxGridSize.ForeColor = SystemColors.Control;
            comboBoxGridSize.FormattingEnabled = true;
            comboBoxGridSize.Items.AddRange(new object[] { "3 * 3", "5 * 5" });
            comboBoxGridSize.Location = new Point(1017, 46);
            comboBoxGridSize.Name = "comboBoxGridSize";
            comboBoxGridSize.Size = new Size(202, 46);
            comboBoxGridSize.TabIndex = 0;
            comboBoxGridSize.Text = "3 * 3";
            comboBoxGridSize.SelectedValueChanged += comboBoxGridSize_SelectedValueChanged;
            // 
            // groupBoxPlayerOne
            // 
            groupBoxPlayerOne.BackColor = Color.White;
            groupBoxPlayerOne.Controls.Add(lblPlayerOne);
            groupBoxPlayerOne.Controls.Add(picBoxPlayerOneAccolade);
            groupBoxPlayerOne.Controls.Add(picBoxCircle);
            groupBoxPlayerOne.Controls.Add(txtBoxPlayerOneScore);
            groupBoxPlayerOne.Location = new Point(862, 241);
            groupBoxPlayerOne.Name = "groupBoxPlayerOne";
            groupBoxPlayerOne.Size = new Size(188, 317);
            groupBoxPlayerOne.TabIndex = 17;
            groupBoxPlayerOne.TabStop = false;
            // 
            // groupBoxPlayerTwo
            // 
            groupBoxPlayerTwo.BackColor = Color.White;
            groupBoxPlayerTwo.Controls.Add(lblPlayerTwo);
            groupBoxPlayerTwo.Controls.Add(txtBoxPlayerTwoScore);
            groupBoxPlayerTwo.Controls.Add(picBoxX);
            groupBoxPlayerTwo.Controls.Add(picBoxPlayerTwoAccolade);
            groupBoxPlayerTwo.Location = new Point(1044, 241);
            groupBoxPlayerTwo.Name = "groupBoxPlayerTwo";
            groupBoxPlayerTwo.Size = new Size(176, 317);
            groupBoxPlayerTwo.TabIndex = 18;
            groupBoxPlayerTwo.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1316, 768);
            Controls.Add(groupBoxPlayerTwo);
            Controls.Add(groupBoxPlayerOne);
            Controls.Add(comboBoxGridSize);
            Controls.Add(btnExit);
            Controls.Add(btnNewGame);
            Controls.Add(textBoxRound);
            Controls.Add(lblScoreBoard);
            Controls.Add(lblRound);
            Controls.Add(lblGridSize);
            Name = "MainForm";
            Text = "Group16_Lu_Cheng";
            ((System.ComponentModel.ISupportInitialize)picBoxCircle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayerOneAccolade).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxX).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayerTwoAccolade).EndInit();
            groupBoxPlayerOne.ResumeLayout(false);
            groupBoxPlayerOne.PerformLayout();
            groupBoxPlayerTwo.ResumeLayout(false);
            groupBoxPlayerTwo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGridSize;
        private Label lblRound;
        private Label lblScoreBoard;
        private TextBox textBoxRound;
        private ListBox listBox1;
        private Label lblPlayerOne;
        private Label lblPlayerTwo;
        private Button btnNewGame;
        private Button btnExit;
        private PictureBox picBoxCircle;
        private TextBox txtBoxPlayerOneScore;
        private TextBox txtBoxPlayerTwoScore;
        private PictureBox picBoxPlayerOneAccolade;
        private PictureBox picBoxX;
        private PictureBox picBoxPlayerTwoAccolade;
        private ComboBox comboBoxGridSize;
        private GroupBox groupBoxPlayerOne;
        private GroupBox groupBoxPlayerTwo;
    }
}
