/*
 * Project Name: TicTacToe
 * Purpose: Create a turn based 2-player Tic-Tac-Toe game
 * Students: Shouhua Lu, Kuolung Cheng
 * Revision History:
 *   v1.0.0, 2024-09-24: First release
 *   v1.1.0, 2024-09-29: Refine user interface design
 *   v1.2.0, 2024-09-29: Highlight the winning line
 *   v1.3.0, 2024-09-29: Simplify the game winning logic
 */
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        // Constants for generating the grid
        private const int INIT_TOP = 50;
        private const int INIT_LEFT = 20;
        private const int WIDTH = 80;
        private const int HEIGHT = 80;
        private const int VGAP = 10; // vertical gap
        private const int HGAP = 10; // horizontal gap

        // Variables for tracking the game state
        private int index = 0; // the player's turn (even: player 1, odd: player 2)
        private int round = 0; // the round number
        private int numberOfRows; // the grid size

        // Image resources
        private Bitmap circleImage;
        private Bitmap xImage;
        private Bitmap winImage;

        public MainForm()
        {
            InitializeComponent();

            // Hide the accolade images
            picBoxPlayerOneAccolade.Hide();
            picBoxPlayerTwoAccolade.Hide();

            // Load images from embedded resource
            circleImage = Resources.PlayerCircle;
            xImage = Resources.PlayerX;
            winImage = Resources.Winner;

            picBoxCircle.Image = circleImage;
            picBoxX.Image = xImage;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Reset all status fields
            round = 0;
            textBoxRound.Text = "0";

            txtBoxPlayerOneScore.Text = "0";
            txtBoxPlayerTwoScore.Text = "0";

            picBoxPlayerOneAccolade.Image = null;
            picBoxPlayerTwoAccolade.Image = null;
            picBoxPlayerOneAccolade.Hide();
            picBoxPlayerTwoAccolade.Hide();

            // Generate a new grid based on the user's selection
            numberOfRows = int.Parse(comboBoxGridSize.Text.ToCharArray()[0].ToString());
            CreateNewGrid();
        }

        private void CreateNewGrid()
        {
            // Reset the index
            index = 0;

            // Clear the grid
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    this.Controls.RemoveByKey($"{i},{j}");
                }
            }

            // Initialize the grid
            InitializeGrid(numberOfRows);
        }

        private void InitializeGrid(int numberOfRows)
        {
            int x = INIT_LEFT;
            int y = INIT_TOP;

            // Initialize the grid
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Left = x;
                    pictureBox.Top = y;
                    pictureBox.Width = WIDTH;
                    pictureBox.Height = HEIGHT;
                    pictureBox.BackColor = Color.White;
                    pictureBox.Name = i.ToString() + "," + j.ToString();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Add the PictureBox to the form's ControlCollection
                    this.Controls.Add(pictureBox);
                    // Set up the PictureBox click event
                    pictureBox.Click += Picbox_Click;
                    x += WIDTH + HGAP;
                }

                x = INIT_LEFT;
                y += HEIGHT + VGAP;
            }
        }

        private void Picbox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            // Check if the clicked PictureBox is a free slot
            if (pictureBox != null && pictureBox.Image == null)
            {
                if (index++ % 2 == 0)
                {
                    pictureBox.Image = circleImage; // player 1
                }
                else
                {
                    pictureBox.Image = xImage; // player 2
                }
            }

            // Check the current game state after each click
            CheckGameState();
        }

        private void CheckGameState()
        {
            // PictureBox list for evaluating the winning condition
            List<PictureBox> picBoxes;

            // Check each row for the winning condition
            for (int row = 0; row < numberOfRows; row++)
            {
                picBoxes = new List<PictureBox>();

                for (int column = 0; column < numberOfRows; column++)
                {
                    picBoxes.Add(this.Controls.Find($"{row},{column}", true)[0] as PictureBox);
                }

                CheckAndProcessWinning(picBoxes);
            }

            // Check each column for the winning condition
            for (int column = 0; column < numberOfRows; column++)
            {
                picBoxes = new List<PictureBox>();

                for (int row = 0; row < numberOfRows; row++)
                {
                    picBoxes.Add(this.Controls.Find($"{row},{column}", true)[0] as PictureBox);
                }

                CheckAndProcessWinning(picBoxes);
            }

            // Check diagonal from top-left to bottom-right for the winning condition
            picBoxes = new List<PictureBox>();

            for (int row = 0; row < numberOfRows; row++)
            {
                picBoxes.Add(this.Controls.Find($"{row},{row}", true)[0] as PictureBox);
            }

            CheckAndProcessWinning(picBoxes);

            // Check diagonal from top-right to bottom-left for the winning condition
            picBoxes = new List<PictureBox>();

            for (int row = 0; row < numberOfRows; row++)
            {
                picBoxes.Add(this.Controls.Find($"{row},{numberOfRows - row - 1}", true)[0] as PictureBox);
            }

            CheckAndProcessWinning(picBoxes);

            // Check if it's a draw
            if (CheckIfDraw())
            {
                // No winner this round
                MessageBox.Show("It is draw this round");

                round++;
                textBoxRound.Text = round.ToString();

                // Reset the grid
                CreateNewGrid();
            }
        }

        private void CheckAndProcessWinning(List<PictureBox> picBoxes)
        {
            // Check if the current line is a winning line
            if (IsWinningLine(picBoxes))
            {
                // Process the winning line
                ProcessWinningLine(picBoxes);
            }
        }

        private bool IsWinningLine(List<PictureBox> picBoxes)
        {
            // Check if the number of PictureBoxes equals the row count of the grid,
            // and the first PictureBox has an image
            if (picBoxes.Count == numberOfRows && picBoxes[0].Image != null)
            {
                foreach (var box in picBoxes)
                {
                    // If any PictureBox has a different image, it's not a winning line
                    if (box.Image != picBoxes[0].Image)
                    {
                        return false;
                    }
                }

                // IF all PictureBoxes have the same image, it's a winning line
                return true;
            }

            return false;
        }

        private void ProcessWinningLine(List<PictureBox> picBoxes)
        {
            // Highlight the winning line
            HighlightWinningLine(picBoxes);
            
            // Update the winning player's score
            SetGameScore(picBoxes[0].Image);
            return;
        }

        private void HighlightWinningLine(List<PictureBox> picBoxes)
        {
            foreach (var box in picBoxes)
            {
                box.BackColor = Color.Gold;
            }
        }

        private bool CheckIfDraw()
        {
            PictureBox picBoxtarget;

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    picBoxtarget = this.Controls.Find($"{i},{j}", true)[0] as PictureBox;
                    
                    // If any PictureBox is empty, it's not a draw
                    if (picBoxtarget.Image == null)
                    {
                        return false;
                    }
                }
            }

            // If no PictureBox is empty, and no one wins, it's a draw
            return true;
        }

        private void SetGameScore(Image image)
        {
            // Current scores of each player
            int playerOneScore = int.Parse(txtBoxPlayerOneScore.Text);
            int playerTwoScore = int.Parse(txtBoxPlayerTwoScore.Text);

            // Determine which player won based on the image
            if (image == circleImage) // player 1 won
            {
                MessageBox.Show("Player 1 is the winner for this round");
                playerOneScore++;
                txtBoxPlayerOneScore.Text = playerOneScore.ToString();
            }
            else if (image == xImage) // player 2 won
            {
                MessageBox.Show("Player 2 is the winner for this round");
                playerTwoScore++;
                txtBoxPlayerTwoScore.Text = playerTwoScore.ToString();
            }

            // Show the accolade image for the higher score player
            if (playerOneScore > playerTwoScore) // show player 1's accolade image
            {
                picBoxPlayerOneAccolade.Image = winImage;
                picBoxPlayerOneAccolade.Show();

                picBoxPlayerTwoAccolade.Image = null;
                picBoxPlayerTwoAccolade.Hide();
            }
            else if (playerOneScore < playerTwoScore) // show player 2's accolade image
            {
                picBoxPlayerTwoAccolade.Image = winImage;
                picBoxPlayerTwoAccolade.Show();

                picBoxPlayerOneAccolade.Image = null;
                picBoxPlayerOneAccolade.Hide();
            }
            // Hide the accolade images if the scores are tied
            else
            {
                picBoxPlayerOneAccolade.Image = null;
                picBoxPlayerOneAccolade.Hide();

                picBoxPlayerTwoAccolade.Image = null;
                picBoxPlayerTwoAccolade.Hide();
            }

            round++;
            textBoxRound.Text = round.ToString();

            // Reset the grid
            CreateNewGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        private void comboBoxGridSize_SelectedValueChanged(object sender, EventArgs e)
        {
            // Changing the grid size will be considered as start a new game
            btnNewGame_Click(sender, e);
        }
    }
}
